''' <summary>
''' The initial class for the software. Stores all XLSets, their names, and a dictionary of variables
''' </summary>
''' <remarks></remarks>
Public Class Multigraph

    Private _setList As List(Of XLSet)
    Private _varDict As Dictionary(Of String, Tuple(Of List(Of Integer), List(Of Long)))
    Private _numSets As Integer
    Private _nameList As List(Of String)
    Private _plotSetup As PlotSetup
    Private _varWin As VarMap
    Private _filWin As Filter
    Private _cmdDict As Dictionary(Of String, Command)
    'Private _cmdLibs As List(Of CmdLib)
    Private _mySet As XLSet

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        LoadMG()
        _plotSetup = Nothing 'for saving plot setup configuration I THINK
        _cmdDict = New Dictionary(Of String, Command)
        '_cmdLibs = New List(Of CmdLib)
        'add built-ins to command dictionary
        _cmdDict.Add("ADD", New Add)
        _cmdDict.Add("AND", New AndCmd)
        _cmdDict.Add("CONTAINS", New Contains)
        _cmdDict.Add("DIV", New Divide)
        _cmdDict.Add("EQUALS", New Equals)
        _cmdDict.Add("GREATER", New GreaterThan)
        _cmdDict.Add("GEQUALS", New GreaterThanEq)
        _cmdDict.Add("ID", New Identity)
        _cmdDict.Add("LESS", New LessThan)
        _cmdDict.Add("LEQUALS", New LessThanEq)
        _cmdDict.Add("MULT", New Multiply)
        _cmdDict.Add("NOT", New NotCmd)
        _cmdDict.Add("OR", New OrCmd)
        _cmdDict.Add("SUB", New Subtract)
        _cmdDict.Add("XOR", New XorCmd)
    End Sub
    ''' <summary>
    ''' The list of all XLSets
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SetList() As List(Of XLSet)
        Get
            Return _setList
        End Get
        Set(value As List(Of XLSet))
            _setList = value
        End Set
    End Property
    ''' <summary>
    ''' A dictionary mapping all variables to XLSets and their column positions
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property VarDict() As Dictionary(Of String, Tuple(Of List(Of Integer), List(Of Long)))
        Get
            Return _varDict
        End Get
        Set(value As Dictionary(Of String, Tuple(Of List(Of Integer), List(Of Long))))
            _varDict = value
        End Set
    End Property
    ''' <summary>
    ''' The number of total sets in SetList; saves time referencing list.count
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NumSets() As Integer
        Get
            Return _numSets
        End Get
        Set(value As Integer)
            _numSets = value
        End Set
    End Property
    ''' <summary>
    ''' number of command libs
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CmdDict() As Dictionary(Of String, Command)
        Get
            Return _cmdDict
        End Get
    End Property
    ' ''' <summary>
    ' ''' number of commands
    ' ''' </summary>
    ' ''' <value></value>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public ReadOnly Property CmdLibs() As List(Of CmdLib)
    '    Get
    '        Return _cmdLibs
    '    End Get
    'End Property
    ''' <summary>
    ''' A list of XLSet names
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NameList() As List(Of String)
        Get
            Return _nameList
        End Get
        Set(value As List(Of String))
            _nameList = value
        End Set
    End Property
    ''' <summary>
    ''' active set in Filter
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MySet As XLSet
        Get
            If IsNothing(_filWin) Then
                Return Nothing
            Else
                Return _filWin.MySet
            End If
        End Get
    End Property
    ''' <summary>
    ''' load Multigraph from file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadMG()
        Try
            Dim format As Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim stream As IO.Stream
            format = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            stream = New IO.FileStream("C:\Users\sean.EPISINC\Documents\Github\MultigraphVB\MG.mg", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
            Dim MG As MGSave = DirectCast(format.Deserialize(stream), Object)
            stream.Close()

            _setList = MG.SetList
            _varDict = MG.VarDict
            _numSets = MG.NumSets
            _nameList = MG.NameList
        Catch
            _setList = New List(Of XLSet)
            _varDict = New Dictionary(Of String, Tuple(Of List(Of Integer), List(Of Long)))
            _numSets = 0
            _nameList = New List(Of String)
        End Try
    End Sub
    ''' <summary>
    ''' Checks whether an Excel workbook is open.
    ''' </summary>
    ''' <param name="szBookName"></param>
    ''' <param name="xl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function BIsBookOpen(ByRef szBookName As String, ByRef xl As Microsoft.Office.Interop.Excel.Application) As Boolean
        On Error Resume Next
        Return Not (xl.Workbooks(szBookName) Is Nothing)
    End Function
    ''' <summary>
    ''' Creates an file dialog object to pick files.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitializeOpenFileDialog()
        ' Set the file dialog to filter for graphics files. 
        OpenFileDialog1.Filter = _
                "Comma-Separated Values(*.csv)|*.csv"

        ' Allow the user to select multiple images. 
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Title = "File Selector"
        'Sets init file dialog dir. Change so user can set.
        OpenFileDialog1.InitialDirectory = My.Settings.Path
    End Sub
    ''' <summary>
    ''' Calls importData when user clicks "Import Data" button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub IData_Click(sender As Object, e As EventArgs) Handles IData.Click
        Dim xl As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
        Try
            ImportData(xl)
            xl.Quit()
            If Not IsNothing(_varWin) Then
                _varWin.Close()
                _varWin = New VarMap()
                _varWin.Show()
            End If
            If Not IsNothing(_filWin) Then
                _filWin.RefreshList()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Import Error")
            For Each wb In xl.Workbooks
                wb.Close()
            Next
            xl.Visible = False
            xl.DisplayAlerts = True
            xl.Quit()
            Exit Sub
        End Try
    End Sub
    ''' <summary>
    ''' Imports Excel csv files to xlSet objects and creates a dictionary of variable names to xlSets and column indices.
    ''' </summary>
    ''' <param name="xl"></param>
    ''' <remarks>Method can encounter exceptions when opening files.</remarks>
    Private Sub ImportData(ByRef xl As Microsoft.Office.Interop.Excel.Application)
        Dim loadwbk As Microsoft.Office.Interop.Excel.Workbook
        Dim lwksht As Microsoft.Office.Interop.Excel.Worksheet
        Dim data As DataTable
        Dim endRow As Long
        Dim endCol As Long
        Dim safeName As String
        Dim parseName As Array
        Dim dataSet As XLSet
        Dim varName As String
        Dim BadFormat As Boolean = False
        Dim NoFiles As Boolean

        'Debug only
        'xl.Visible = True
        xl.DisplayAlerts = False

        InitializeOpenFileDialog()
        OpenFileDialog1.ShowDialog()
        NoFiles = (OpenFileDialog1.FileNames.Count = 0)
        For Each fname In OpenFileDialog1.FileNames
            'check if book open. If it is, don't reopen.
            If Not BIsBookOpen(fname, xl) Then
                loadwbk = xl.Workbooks.Open(fname)
            Else
                loadwbk = xl.Workbooks(fname)
            End If
            'If book successfully opened
            If Not IsNothing(loadwbk) Then
                parseName = Nothing
                Try
                    'check if os is Mac
                    If InStr(UCase(xl.OperatingSystem), "MAC") <> 0 Then
                        parseName = Split(fname, ":")
                    Else
                        parseName = Split(fname, "\")
                    End If
                    safeName = parseName(UBound(parseName))
                Catch ex As Exception
                    MessageBox.Show("Error determining operating system.", "OS Error")
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try
                'did not warn user that file is duplicate
                If Not NameList.Contains(safeName) Then
                    'import was success, increment numSets
                    NumSets += 1
                    lwksht = loadwbk.ActiveSheet
                    'last row and column in sheet
                    endRow = lwksht.Cells(lwksht.Rows.Count, 1).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Row
                    endCol = lwksht.Cells(1, lwksht.Columns.Count).End(Microsoft.Office.Interop.Excel.XlDirection.xlToLeft).Column
                    'if blanks are detected in first row/column, notify user. If RemoveBlanks is true, remove them
                    For i = 1 To endCol
                        If String.IsNullOrWhiteSpace(lwksht.Cells(1, i).Value) Then
                            BadFormat = True
                            If My.Settings.RemoveBlanks Then
                                Dim range As Microsoft.Office.Interop.Excel.Range
                                range = lwksht.Range(lwksht.Cells(1, i), lwksht.Cells(endRow, endCol - 1))
                                range.Value = lwksht.Range(lwksht.Cells(1, i + 1), lwksht.Cells(endRow, endCol)).Value
                                endCol -= 1
                            End If
                        End If
                    Next
                    For i = 1 To endRow
                        If String.IsNullOrWhiteSpace(lwksht.Cells(i, 1).Value) Then
                            BadFormat = True
                            If My.Settings.RemoveBlanks Then
                                Dim range As Microsoft.Office.Interop.Excel.Range
                                range = lwksht.Range(lwksht.Cells(i, 1), lwksht.Cells(endRow - 1, endCol))
                                range.Value = lwksht.Range(lwksht.Cells(i + 1, 1), lwksht.Cells(endRow, endCol)).Value
                                endRow -= 1
                            End If
                        End If
                    Next
                    dataSet = New XLSet
                    ''data block includes header row, possible clean-up later
                    'data = lwksht.Range(lwksht.Cells(1, 1), lwksht.Cells(endRow, endCol)).Value
                    'make new datatable
                    data = New DataTable
                    'add blank var
                    dataSet.VarList.Add("")
                    If Not VarDict.ContainsKey("") Then
                        VarDict.Add("", Tuple.Create(New List(Of Integer) From {NumSets - 1}, New List(Of Long) From {0}))
                    Else
                        VarDict.Item("").Item1.Add(NumSets - 1)
                        VarDict.Item("").Item2.Add(0)
                    End If
                    'add all var entries to dict in format varName: {ID},{colNum}, and also add varName to set's var list
                    For i = 1 To endCol
                        varName = lwksht.Cells(1, i).Value.Trim
                        'add name of var to varlist
                        dataSet.VarList.Add(varName)
                        'add name to vardict
                        If Not VarDict.ContainsKey(varName) Then
                            VarDict.Add(varName, Tuple.Create(New List(Of Integer) From {NumSets - 1}, New List(Of Long) From {i}))
                        Else
                            VarDict.Item(varName).Item1.Add(NumSets - 1)
                            VarDict.Item(varName).Item2.Add(i)
                        End If
                        'add var column in datatable
                        data.Columns.Add(varName)
                    Next
                    'add all non-header rows to datatable
                    For i = 2 To endRow
                        Dim x(endCol - 1) As Object
                        For j = 1 To endCol
                            x(j - 1) = lwksht.Cells(i, j).Value
                        Next
                        data.Rows.Add(x)
                    Next
                    loadwbk.Close()
                    'set XLSet properties
                    NameList.Add(safeName)
                    dataSet.Name = safeName
                    dataSet.ID = NumSets - 1
                    dataSet.Vars = endCol
                    dataSet.Entries = endRow - 1
                    dataSet.Data = data
                    'add to master list
                    _setList.Add(dataSet)
                End If
            Else
                MessageBox.Show("Could not import file " & fname & ". Check that files exists, and try again.", "Import Error")
            End If
        Next
        OpenFileDialog1.Dispose()
        If BadFormat Then
            MessageBox.Show("One or more blanks were detected in the header row or the first column of at least one csv file. To ensure data integrity, please remove any spaces in csv files.", "Format Warning")
        End If
        If Not NoFiles Then
            MessageBox.Show("Import done!", "Success")
        End If
        'Debug only
        'xl.Visible = False
        xl.DisplayAlerts = True
    End Sub
    ''' <summary>
    ''' Opens property window when user clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PButton_Click(sender As Object, e As EventArgs) Handles Props.Click
        Dim propWin = New Props()
        propWin.Show()
    End Sub
    ''' <summary>
    ''' Opens VarMap when user clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub VMap_Click(sender As Object, e As EventArgs) Handles VMap.Click
        _varWin = New VarMap()
        _varWin.Show()
    End Sub
    ''' <summary>
    ''' Opens plotting tool
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PlotButton_Click(sender As Object, e As EventArgs) Handles Plot.Click
        Dim plotWin As PlotSetup

        If IsNothing(_plotSetup) Then
            plotWin = New PlotSetup
        Else
            plotWin = New PlotSetup(_plotSetup)
        End If
        plotWin.ShowDialog()
        _plotSetup = New PlotSetup(plotWin)
        plotWin.Dispose()
    End Sub
    ''' <summary>
    ''' Open options window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Ops_Click(sender As Object, e As EventArgs) Handles Ops.Click
        Dim ODialog As OpDialog = New OpDialog()
        ODialog.ShowDialog()
        ODialog.SaveOps()
        ODialog.Dispose()
    End Sub
    ''' <summary>
    ''' Open filtering window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Filter_Click(sender As Object, e As EventArgs) Handles Filter.Click
        _filWin = New Filter(_mySet)
        _filWin.ShowDialog()
        _mySet = _filWin.MySet
        _filWin.Dispose()
    End Sub
    ''' <summary>
    ''' Find command using name
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LookupCmd(name As String) As Command
        Try
            Return _cmdDict.Item(name.ToUpper.Trim)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' Add command using name
    ''' </summary>
    ''' <param name="cmd"></param>
    ''' <remarks></remarks>
    Public Sub AddCmd(cmd As UserCommand)
        Dim name As String = cmd.Name
        _cmdDict.Add(name.ToUpper.Trim, cmd)
        _filWin.VarBox.Items.Add(name)
    End Sub
    ' ''' <summary>
    ' ''' finds a cmdlib by name
    ' ''' </summary>
    ' ''' <param name="name"></param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function LookupCmdLib(name As String) As CmdLib
    '    For Each cmdLib In _cmdLibs
    '        If cmdLib.Name.ToUpper.Trim = name.ToUpper.Trim Then
    '            Return cmdLib
    '        End If
    '    Next
    '    Return Nothing
    'End Function
    ' ''' <summary>
    ' ''' adds cmdLib to list
    ' ''' </summary>
    ' ''' <param name="cmdLib"></param>
    ' ''' <remarks></remarks>
    'Public Sub AddCmdLib(cmdLib As CmdLib)
    '    _cmdLibs.Add(cmdLib)
    '    _filWin.ComBox.Items.Add(cmdLib.ShortName)
    'End Sub
    ' ''' <summary>
    ' ''' load cmdlib from file
    ' ''' </summary>
    ' ''' <param name="name"></param>
    ' ''' <remarks></remarks>
    'Public Sub LoadCmdLib(name As String)
    '    Dim format As Runtime.Serialization.Formatters.Binary.BinaryFormatter
    '    Dim stream As IO.Stream
    '    format = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
    '    stream = New IO.FileStream(name, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
    '    Dim cmdlib As CmdLib = DirectCast(format.Deserialize(stream), Object)
    '    stream.Close()

    '    AddCmdLib(cmdlib)
    '    Dim exclude As Boolean
    '    For Each cmd In cmdlib.Commands
    '        exclude = False
    '        If _cmdDict.ContainsKey(cmd.Name) Then
    '            Dim cmdDiag As CmdAddDialog = New CmdAddDialog(cmd.Name)
    '            cmdDiag.ShowDialog()
    '            exclude = cmdDiag.Exclude
    '            cmd.Name = cmdDiag.Name
    '            cmdDiag.Dispose()
    '        End If
    '        If Not exclude Then
    '            cmd.RefreshFunc()
    '            AddCmd(cmd)
    '        End If
    '    Next
    'End Sub
    ''' <summary>
    ''' Determine whether string is a variable name
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsVar(name As String) As Boolean
        For Each key In _varDict.Keys
            If key.ToUpper.Trim = name.ToUpper.Trim Then
                Return True
            End If
        Next
        Return False
    End Function
    ''' <summary>
    ''' save multigraph before close
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Multigraph_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim MG = New MGSave
    End Sub
End Class
