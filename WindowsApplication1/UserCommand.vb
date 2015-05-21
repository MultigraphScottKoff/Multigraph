''' <summary>
''' Commands are user-defined expressions used for filtering and variable creation.
''' </summary>
''' <remarks></remarks>
<Serializable> Public Class UserCommand
    Inherits Command

    Private _tuple As Tuple(Of String, List(Of Object))
    Private _numArgs As Integer
    <NonSerialized> Private _parse As String
    ''' <summary>
    ''' create new Command object
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(parse As String, name As String)
        'figure out cleaner way to do this
        MyBase.New()
        If Not IsNothing(Multigraph.LookupCmd(name)) Then
            Me.Name = Nothing
        Else
            Me.Name = name.Trim
            _numArgs = 0
            _parse = parse
            'Me.Parent = Nothing
            _tuple = ParseStatement(name)
            'testing
            'MsgBox(printTuple(_tuple, "The tuple is "))
            If IsNothing(_tuple) Then
                Me.Name = Nothing
            Else
                'first element in tuple's item2 is always a tuple
                Func = ParseToFunction(_tuple.Item2(0))
                If IsNothing(Func) Then
                    Me.Name = Nothing
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' tuple of usercommand
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MyTuple As Tuple(Of String, List(Of Object))
        Get
            Return _tuple
        End Get
    End Property
    ''' <summary>
    ''' recreates Func after load
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RefreshFunc()
        Func = ParseToFunction(_tuple.Item2(0))
    End Sub
    ''' <summary>
    ''' determine underlying command tuple from statement text
    ''' </summary>
    ''' <param name="name"></param>
    ''' <remarks></remarks>
    Private Function ParseStatement(name As String) As Tuple(Of String, List(Of Object))
        Dim store As String = ""
        Dim fChar As Char
        Dim myTuple = Tuple.Create(name, New List(Of Object))

        Try
            'make sure to catch errors
            While _parse.Length > 0
                fChar = _parse.First
                'parse tracker for testing
                'MsgBox(store & "|" & _parse & " : " & fChar)
                _parse = _parse.Substring(1)
                If fChar = "("c Then
                    'store is a function name, add new function
                    Dim parseTuple As Tuple(Of String, List(Of Object)) = ParseStatement(store.Trim)
                    If IsNothing(parseTuple) Then
                        Return Nothing
                    Else
                        myTuple.Item2.Add(parseTuple)
                        store = ""
                    End If
                ElseIf fChar = ","c Or fChar = ")"c Then
                    'store is either a var name or constant value
                    'store is blank
                    Dim blank As Boolean = store.Trim = ""
                    'store is defined variable
                    Dim DefVar As Boolean = Multigraph.IsVar(store)
                    'store is undefined variable (#)
                    Dim UndefVar As Boolean = (store.Trim = "#"c)
                    If UndefVar AndAlso DefVar Then
                        MessageBox.Show("Cannot use defined variables with the undetermined variable identifier #. Please choose one format.", "Variable Parsing")
                        Return Nothing
                    ElseIf UndefVar Then
                        'store is #, mark index of first argument
                        myTuple.Item2.Add(New varIndex(_numArgs))
                        _numArgs += 1
                    ElseIf Not blank Then
                        If DefVar Then
                            'store is a var name, add as placeholder
                            myTuple.Item2.Add(New varIndex(store))
                        Else
                            'store is a constant, add as is
                            Dim constant As Object = ParseConst(store.Trim)
                            If IsNothing(constant) Then
                                Return Nothing
                            Else
                                myTuple.Item2.Add(constant)
                            End If
                        End If
                    End If
                    store = ""
                    If fChar = ")"c Then
                        If _parse.Length > 1 AndAlso _parse.First = ","c Then
                            _parse = _parse.Substring(1)
                        End If
                        Return myTuple
                    End If
                Else
                    store = String.Concat(store.Trim, fChar)
                End If
            End While

            Return myTuple
        Catch ex As Exception
            MessageBox.Show("Statement had invalid syntax. Make sure commas, parentheses, and variable names are used correctly.", "Parse Error")
            Return Nothing
        End Try

    End Function
    ''' <summary>
    ''' Determine type of const and pass it correctly
    ''' </summary>
    ''' <param name="constant"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ParseConst(constant As String) As Object
        Dim result As Object = Nothing
        'remove white-space
        constant = constant.Trim()

        If constant.First = Chr(34) And constant.Last = Chr(34) Then
            'chr(34) = "   Is it a string?
            result = constant.Substring(1, constant.Length - 2)
        ElseIf IsNumeric(constant) Then
            result = CDbl(constant)
        ElseIf constant.ToUpper = "TRUE" Then
            result = True
        ElseIf constant.ToUpper = "FALSE" Then
            result = False
        Else
            MessageBox.Show("One of the constants you have chosen is not an acceptable data type.", "Invalid Constant")
        End If
        Return result
    End Function
    ''' <summary>
    ''' parses tuple statement to function
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ParseToFunction(tuple As Tuple(Of String, List(Of Object))) As Func(Of List(Of Object), Object)
        Dim myFunc As Func(Of List(Of Object), Object)

        myFunc = Function(list As List(Of Object))
                     Dim name As String = tuple.Item1.Trim.ToUpper
                     Dim doLoop As Boolean = list(0) AndAlso ContainsDefVar(tuple)
                     list(0) = False
                     Dim numRows As Long
                     If doLoop Then
                         If IsNothing(Multigraph.MySet) Then
                             MessageBox.Show("A dataset must be selected to use variable references.", "No Dataset")
                             Return Nothing
                         Else
                             numRows = list(1)
                         End If
                     Else
                         numRows = 1
                     End If
                     Dim out As Object
                     Dim output As List(Of Object) = New List(Of Object)
                     For n = 0 To numRows - 1
                         If doLoop Then
                             list(1) = n
                         End If
                         Dim obj
                         Dim vIndex As varIndex
                         Dim argTuple As Tuple(Of String, List(Of Object))
                         Dim nextList As List(Of Object) = New List(Of Object)
                         nextList.Add(False)
                         nextList.Add(list(1))
                         Dim cmd As Command
                         If _numArgs <> list.Count - 2 Then
                             MessageBox.Show("Command " & tuple.Item1 & " was passed an incorrect number of arguments.", "Argument Number Error")
                             Return Nothing
                         Else
                             For i = 0 To tuple.Item2.Count - 1
                                 obj = tuple.Item2(i)
                                 If obj.GetType() = GetType(varIndex) Then
                                     vIndex = obj
                                     If vIndex.Index = -1 Then
                                         nextList.Add(Multigraph.MySet.Data.Rows(list(1)).Item(vIndex.Name))
                                     Else
                                         nextList.Add(list(vIndex.Index))
                                     End If
                                 ElseIf obj.GetType() = GetType(Tuple(Of String, List(Of Object))) Then
                                     argTuple = obj
                                     out = ParseToFunction(argTuple)(list)
                                     If IsNothing(out) Then
                                         Return Nothing
                                     End If
                                     nextList.Add(out(0))
                                 Else
                                     nextList.Add(obj)
                                 End If
                             Next
                             cmd = Multigraph.LookupCmd(tuple.Item1)
                             If IsNothing(cmd) Then
                                 MessageBox.Show("Command " & tuple.Item1 & " does not exist. Please check that the corresponding command library has been loaded.", "Command doesn't exist.")
                                 Return Nothing
                             End If
                             out = cmd.Func(nextList)
                             If IsNothing(out) Then
                                 Return Nothing
                             End If
                             output.Add(out(0))
                         End If
                     Next
                     Return output
                 End Function
        Return myFunc
    End Function
    ' ''' <summary>
    ' ''' determines whether tuple has a defined variable
    ' ''' </summary>
    ' ''' <param name="tuple"></param>
    ' ''' <returns></returns>
    '' ''' <remarks></remarks>
    'Private Function ContainsDefVar(tuple As Tuple(Of String, List(Of Object))) As Boolean
    '    Dim ItemList As List(Of Object) = tuple.Item2
    '    For i = 0 To ItemList.Count - 1
    '        If ItemList(i).GetType = GetType(varIndex) Then
    '            Dim var As varIndex = ItemList(i)
    '            If var.Index = -1 Then
    '                Return True
    '            End If
    '        ElseIf ItemList(i).GetType = GetType(Tuple(Of String, List(Of Object))) Then
    '            Dim cmd = Multigraph.LookupCmd(ItemList(i).Item1)
    '            If cmd.GetType = GetType(UserCommand) Then
    '                Dim ucmd As UserCommand = cmd
    '                Return ContainsDefVar(ucmd.MyTuple.Item2(0))
    '            Else
    '                Return ContainsDefVar(ItemList(i))
    '            End If
    '        End If
    '    Next
    '    Return False
    'End Function
    ''' <summary>
    ''' determines whether tuple has a defined variable
    ''' </summary>
    ''' <param name="tuple"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ContainsDefVar(tuple As Tuple(Of String, List(Of Object))) As Boolean
        Dim argList As List(Of Object) = tuple.Item2
        If argList.Count = 0 Then
            Dim cmd = Multigraph.LookupCmd(tuple.Item1)
            If cmd.GetType = GetType(UserCommand) Then
                Dim ucmd As UserCommand = cmd
                Return ContainsDefVar(ucmd.MyTuple)
            End If
        Else
            For i = 0 To argList.Count - 1
                If argList(i).GetType = GetType(Tuple(Of String, List(Of Object))) Then
                    Return ContainsDefVar(argList(i))
                ElseIf argList(i).GetType = GetType(varIndex) Then
                    Dim var As varIndex = argList(i)
                    If var.Index = -1 Then
                        Return True
                    End If
                End If
            Next
        End If
        Return False
    End Function
    ''' <summary>
    ''' testing only
    ''' </summary>
    ''' <param name="tuple"></param>
    ''' <param name="myString"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function printTuple(tuple As Tuple(Of String, List(Of Object)), myString As String) As String
        myString = myString & tuple.Item1 & ":"
        For Each item In tuple.Item2
            If TypeOf item Is Tuple(Of String, List(Of Object)) Then
                myString = printTuple(item, myString)
            Else
                myString = myString & item & ","
            End If
        Next
        Return myString
    End Function

End Class
