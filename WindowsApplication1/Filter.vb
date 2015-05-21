Public Class Filter

    Private _setList As List(Of XLSet)
    Private _cmd As UserCommand
    Private _mySet As XLSet
    Private _oldSet As XLSet
    Private _changed As Boolean = False

    ''' <summary>
    ''' initialize form to filter sets and create new
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(mySet As XLSet)

        ' This call is required by the designer.
        InitializeComponent()
        If Not IsNothing(mySet) Then
            _mySet = New XLSet(mySet)
            _oldSet = mySet
            LoadSet()
            SetBox.Text = _mySet.Name
        End If
        RefreshList()

    End Sub
    ''' <summary>
    ''' active xlSet
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MySet As XLSet
        Get
            Return _mySet
        End Get
    End Property
    ''' <summary>
    ''' load a set for datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadSet()
        DataGridView1.DataSource = _mySet.Data
        For i = 0 To _mySet.Vars - 1
            VarBox.Items.Add(_mySet.VarList(i))
        Next
    End Sub
    ''' <summary>
    ''' repopulate dropdowns
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RefreshList()
        SetBox.Items.Clear()
        ComBox.Items.Clear()
        'ComLibBox.Items.Clear()
        _setList = Multigraph.SetList
        For i = 0 To _setList.Count - 1
            SetBox.Items.Add(_setList(i).Name)
        Next
        'ComLibBox.Items.Add("ALL")
        'For i = 0 To Multigraph.CmdLibs.Count - 1
        '    ComLibBox.Items.Add(Multigraph.CmdLibs(i).Name)
        'Next
        For Each key In Multigraph.CmdDict.Keys
            ComBox.Items.Add(Multigraph.CmdDict.Item(key).Name)
        Next
    End Sub
    ''' <summary>
    ''' user picks a set to filter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SetBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SetBox.SelectedIndexChanged
        _oldSet = _setList(SetBox.SelectedIndex)
        _mySet = New XLSet(_oldSet)
        LoadSet()
        NameBox.Text = _mySet.Name
    End Sub
    ''' <summary>
    ''' raises changed flag when cell edited
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        _changed = True
    End Sub
    ''' <summary>
    ''' saves set
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveSet(name As String)
        Dim VarDict As Dictionary(Of String, Tuple(Of List(Of Integer), List(Of Long))) = Multigraph.VarDict
        Dim varName As String
        Dim isGood As Boolean = False

        If Not IsNothing(_mySet) AndAlso Not Multigraph.NameList.Contains(name) Then
            isGood = True
            Dim newSet As XLSet = New XLSet()
            newSet.Name = name
            Multigraph.NameList.Add(name)
            Multigraph.NumSets += 1
            newSet.ID = Multigraph.NumSets - 1
            _oldSet = newSet
            Multigraph.SetList.Add(_oldSet)
        ElseIf IsNothing(_mySet) Then
            MessageBox.Show("Please load an existing set before saving.", "Save Error")
        ElseIf name = _mySet.Name Then
            isGood = True
        Else
            MessageBox.Show("Please choose a unique name for your new set.", "Save Error")
        End If
        If isGood Then
            Dim dt As DataTable = New DataTable
            _oldSet.Entries = DataGridView1.Rows.Count - 1
            _oldSet.Vars = DataGridView1.Columns.Count
            _oldSet.VarList.Clear()
            For Each col As DataGridViewColumn In DataGridView1.Columns
                _oldSet.VarList.Add(col.HeaderText)
                dt.Columns.Add(col.HeaderText)
            Next
            For i = 0 To _oldSet.Entries - 1
                Dim x(_oldSet.Vars - 1) As Object
                For j = 0 To _oldSet.Vars - 1
                    x(j) = DataGridView1.Item(CInt(j), CInt(i)).Value
                Next
                dt.Rows.Add(x)
            Next
            _oldSet.Data = dt
            'add name to vardict
            For i = 0 To _oldSet.VarList.Count - 1
                varName = _oldSet.VarList(i)
                If Not VarDict.ContainsKey(varName) Then
                    VarDict.Add(varName, Tuple.Create(New List(Of Integer) From {Multigraph.NumSets - 1}, New List(Of Long) From {i + 1}))
                Else
                    VarDict.Item(varName).Item1.Add(_oldSet.ID)
                    VarDict.Item(varName).Item2.Add(i + 1)
                End If
            Next
            MessageBox.Show("Save successful!", "Save Success")
            _changed = False
            _mySet = New XLSet(_oldSet)
            SetBox.Text = name
        End If
    End Sub
    ''' <summary>
    ''' new set is created using filter parameters and new variable
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        SaveSet(NameBox.Text.Trim)
        RefreshList()
    End Sub
    ''' <summary>
    ''' close window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' asks to save on form close
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Filter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not IsNothing(_mySet) Then
            If _changed Then
                Dim overwrite As SaveFilterData = New SaveFilterData
                overwrite.ShowDialog()
                If overwrite.Status = 1 Then
                    SaveSet(_mySet.Name)
                ElseIf overwrite.Status = -1 Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' asks to save on set change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SetBox_DropDown(sender As Object, e As EventArgs) Handles SetBox.DropDown
        If Not IsNothing(_mySet) Then
            If _changed Then
                _changed = False
                Dim overwrite As SaveFilterData = New SaveFilterData
                overwrite.DoCancel.Hide()
                overwrite.ShowDialog()
                If overwrite.Status = 1 Then
                    SaveSet(_mySet.Name)
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' checks if command name taken, and adds if not
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SaveComButton_Click(sender As Object, e As EventArgs) Handles SaveComButton.Click
        If Not ValidCommand() Then
            Exit Sub
        ElseIf ComNameBox.Text.Trim = "" Then
            MessageBox.Show("Commands must be named before they can be saved.", "Name Command")
        ElseIf Not IsNothing(Multigraph.LookupCmd(ComNameBox.Text)) Then
            MessageBox.Show("New commands must have unique names. Please select a new name.", "Name Conflict")
        Else
            _cmd = New UserCommand(ComText.Text, ComNameBox.Text)
            If Not IsNothing(_cmd.Name) Then
                Multigraph.AddCmd(_cmd)
                'Dim parent As CmdLib = _cmd.Parent
                'If IsNothing(parent) Then
                SaveFileDialog1.Filter = "Command File (*.cmd)|*.cmd"
                SaveFileDialog1.FileName = ComNameBox.Text
                SaveFileDialog1.ShowDialog()
                'Else
                'parent.Commands.Add(_cmd)
                'parent.Save()
                'End If
                _cmd.RefreshFunc()
                'MessageBox.Show(_cmd.Func(New List(Of Object) From {True}).ToString)
            End If
        End If
    End Sub
    ''' <summary>
    ''' overwrites a command library or creates new
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        'Dim name As String = SaveFileDialog1.FileName
        'Dim s() As String = name.Trim(".cmd").Split("\")
        'Dim shortName As String = s(s.Length - 1)
        'Dim cmdLib As CmdLib = New CmdLib(name, shortName, New List(Of UserCommand) From {_cmd})
        'Multigraph.AddCmdLib(cmdLib)
        '_cmd.Parent = cmdLib
        _cmd.Save()
    End Sub
    ''' <summary>
    ''' evaluates command statement
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function EvalCmd() As List(Of Object)
        If ValidCommand() Then
            If ComText.Text.Trim.Contains("#") Then
                MessageBox.Show("Commands with variable identifiers cannot be directly evaluated.", "Variable Exception")
            Else
                Dim cmd As UserCommand = New UserCommand(ComText.Text, "#E#V#A#L#")
                If Not IsNothing(cmd.Name) Then
                    Dim startArgs = New List(Of Object)
                    startArgs.Add(True)
                    If IsNothing(_mySet) Then
                        startArgs.Add(1)
                    Else
                        startArgs.Add(_mySet.Entries)
                    End If
                    Dim out As Object = cmd.Func(startArgs)
                    If IsNothing(out) Then
                        Return Nothing
                    End If
                    Return TryCast(out, List(Of Object))
                End If
            End If
        End If
        Return Nothing
    End Function
    ''' <summary>
    ''' shows output of command on set, NOT DONE
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PreNewVarButton_Click(sender As Object, e As EventArgs) Handles PreNewVarButton.Click
        Dim msg As String = ""
        Dim output As List(Of Object) = EvalCmd()
        If Not IsNothing(output) Then
            For Each x In output
                msg = msg & CStr(x) & Environment.NewLine
            Next
            MessageBox.Show(msg, "Output")
        End If
    End Sub
    ''' <summary>
    ''' make a new column in dataset
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NewVarButton_Click(sender As Object, e As EventArgs) Handles NewVarButton.Click
        If Not IsNothing(_mySet) Then
            Dim text As String = ComNameBox.Text.Trim
            If text <> "" Then
                If Not DataGridView1.Columns.Contains(text) Then
                    Dim output As List(Of Object) = EvalCmd()
                    If IsNothing(output) Then
                        Exit Sub
                    End If
                    DataGridView1.Columns.Add(ComNameBox.Text.Trim, ComNameBox.Text.Trim)
                    'if one value, expand to column
                    If output.Count = 1 Then
                        Dim x As Object = output(0)
                        For i = 0 To DataGridView1.Rows.Count - 2
                            output.Add(x)
                        Next
                    End If
                    For i = 0 To _mySet.Data.Rows.Count - 1
                        DataGridView1.Rows(i).Cells(text).Value = output(i)
                    Next
                    _changed = True
                    DispTab.Show()
                    DataGridView1.FirstDisplayedScrollingColumnIndex = DataGridView1.Columns.Count - 1
                Else
                    MessageBox.Show("New variable names must be unique.", "Variable Name Taken")
                End If
            Else
                MessageBox.Show("Must input a command name to be used as the new variable name.", "Input Command Name")
            End If
        Else
            MessageBox.Show("Please select a dataset to add a new variable.", "No Dataset Selected")
        End If
    End Sub
    ''' <summary>
    ''' Clear current filter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClrFilButton_Click(sender As Object, e As EventArgs) Handles ClrFilButton.Click
        If Not IsNothing(_oldSet) Then
            _mySet = New XLSet(_oldSet)
        End If
    End Sub
    ''' <summary>
    ''' Filters current dataset by command statement
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FilButton_Click(sender As Object, e As EventArgs) Handles FilButton.Click
        If Not IsNothing(_mySet) Then
            Dim output As List(Of Object) = EvalCmd()
            If IsNothing(output) Then
                Exit Sub
            End If
            If output.Count = 1 Then
                MessageBox.Show("Variable names must be used to properly filter.", "Need Variable")
                Exit Sub
            End If
            Dim count As Integer = 0
            For i = 0 To output.Count - 1
                If output(i).GetType <> GetType(Boolean) Then
                    MessageBox.Show("Output of command statement must be Boolean (True/False)", "Output Type Error")
                    Exit Sub
                ElseIf Not output(i) Then
                    DataGridView1.Rows.Remove(DataGridView1.Rows(i - count))
                    count += 1
                End If
            Next
            _changed = True
            DispTab.Show()
        Else
            MessageBox.Show("Please select a dataset to filter.", "No Dataset Selected")
        End If
    End Sub
    ''' <summary>
    ''' checks if command is valid
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidCommand() As Boolean
        If ComText.Text.Trim = "" Then
            MessageBox.Show("Input command text.", "Blank Command")
            Return False
        ElseIf Not ComText.Text.Contains("("c) Then
            MessageBox.Show("Parentheses are required to process commands. If you are trying to input a constant use ID() command.", "Missing Parentheses")
            Return False
        ElseIf Not ComText.Text.Contains(")"c) Then
            MessageBox.Show("Please close parentheses for proper command parsing.", "Missing Parentheses")
            Return False
        End If
        Return True
    End Function
    ''' <summary>
    ''' adds variables to command string
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub VarButton_Click(sender As Object, e As EventArgs) Handles VarButton.Click
        Dim pos As Integer = ComText.SelectionStart
        Dim str As String = CStr(VarBox.SelectedItem)
        If Not IsNothing(str) Then
            ComText.Text = ComText.Text.Insert(pos, str)
            ComText.Focus()
            ComText.SelectionStart = pos + str.Length
        End If
    End Sub
    ''' <summary>
    ''' adds command to command string
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ComButton_Click(sender As Object, e As EventArgs) Handles ComButton.Click
        Dim pos As Integer = ComText.SelectionStart
        Dim str As String = CStr(ComBox.SelectedItem) & "("c
        ComText.Text = ComText.Text.Insert(pos, str)
        ComText.Focus()
        ComText.SelectionStart = pos + str.Length
    End Sub
    ' ''' <summary>
    ' ''' picks a .cml file
    ' ''' </summary>
    ' ''' <param name="sender"></param>
    ' ''' <param name="e"></param>
    ' ''' <remarks></remarks>
    'Private Sub LibButton_Click(sender As Object, e As EventArgs)
    '    OpenFileDialog1.ShowDialog()
    'End Sub
    ' ''' <summary>
    ' ''' loads .cml
    ' ''' </summary>
    ' ''' <param name="sender"></param>
    ' ''' <param name="e"></param>
    ' ''' <remarks></remarks>
    'Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
    '    Multigraph.LoadCmdLib(OpenFileDialog1.FileName)
    'End Sub
End Class