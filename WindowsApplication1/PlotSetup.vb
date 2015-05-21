''' <summary>
''' Configuration for a new series of plots
''' </summary>
''' <remarks></remarks>
Public Class PlotSetup

    Private _plotList As List(Of PlotConfig)
    Private _baseConfig As PlotConfig
    Private _myPlot As PlotConfig
    Private _plotNum As Integer
    Private _plotLimit As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _plotList = New List(Of PlotConfig)
        _baseConfig = New PlotConfig("Plot Template")
        _plotList.Add(_baseConfig)
        PlotBox.Items.Add("Plot Template")
        _myPlot = Nothing
        _plotNum = 1
        _plotLimit = 100
    End Sub
    ''' <summary>
    ''' create a deep clone of another plotSetup
    ''' </summary>
    ''' <param name="MySetup"></param>
    ''' <remarks></remarks>
    Public Sub New(MySetup As PlotSetup)

        ' This call is required by the designer.
        InitializeComponent()
        _plotList = MySetup.PlotList.ToList
        _baseConfig = MySetup.BaseConfig
        _myPlot = MySetup.MyPlot
        _plotNum = MySetup.PlotNum
        _plotLimit = MySetup.PlotLimit
        PlotBox.Items.AddRange(MySetup.PlotBox.Items)
        PlotAdd.Enabled = MySetup.PlotAdd.Enabled
        PlotRename.Enabled = MySetup.PlotRename.Enabled
        PlotRemove.Enabled = MySetup.PlotRemove.Enabled
        SetAdd.Enabled = MySetup.SetAdd.Enabled
        SetRemove.Enabled = MySetup.SetRemove.Enabled
        AllSetsBox.Enabled = MySetup.AllSetsBox.Enabled
        OneSeriesBox.Enabled = MySetup.OneSeriesBox.Enabled
        DoPlot.Enabled = MySetup.DoPlot.Enabled

    End Sub
    ''' <summary>
    ''' list of plots in setup
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PlotList As List(Of PlotConfig)
        Get
            Return _plotList
        End Get
        Set(value As List(Of PlotConfig))
            _plotList = value
        End Set
    End Property
    ''' <summary>
    ''' starting config for new plots
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property BaseConfig As PlotConfig
        Get
            Return _baseConfig
        End Get
        Set(value As PlotConfig)
            _baseConfig = value
        End Set
    End Property
    ''' <summary>
    ''' currently referenced PlotConfig
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MyPlot As PlotConfig
        Get
            Return _myPlot
        End Get
        Set(value As PlotConfig)
            _myPlot = value
        End Set
    End Property
    ''' <summary>
    ''' default number to assign to new plots
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PlotNum As Integer
        Get
            Return _plotNum
        End Get
        Set(value As Integer)
            _plotNum = value
        End Set
    End Property
    ''' <summary>
    ''' maximum number of plots that can be added
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PlotLimit As Integer
        Get
            Return _plotLimit
        End Get
        Set(value As Integer)
            _plotLimit = value
        End Set
    End Property
    ''' <summary>
    ''' Sets plotting color for selected data set
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SelColor_Click(sender As Object, e As EventArgs) Handles SelColor.Click
        Dim SetIndex As Integer = SetBox.SelectedIndex
        If Not IsNothing(_myPlot) And SetIndex >= 0 Then
            ColorDialog1.ShowDialog()
            ColorLabel.BackColor = ColorDialog1.Color
            _myPlot.Colors(SetIndex) = ColorDialog1.Color
            ColorDialog1.Dispose()
        End If
    End Sub
    ''' <summary>
    ''' Adds a new plot to the plotting window
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PlotAdd_Click(sender As Object, e As EventArgs) Handles PlotAdd.Click
        'open name dialog
        Dim PDialog = New PlotAddDialog(_plotList.Count, _plotLimit)
        PDialog.ShowDialog()
        'create new config objects with default names from Base Config
        If PDialog.GoodExit Then
            For i = 0 To PDialog.NumPlots - 1
                Dim NewConfig As PlotConfig = New PlotConfig(_baseConfig)
                NewConfig.Name = "Plot " & _plotNum
                'add object to combobox and plotlist
                _plotList.Add(NewConfig)
                PlotBox.Items.Add(NewConfig.Name)
                DoPlot.Enabled = True
                PlotRename.Enabled = True
                PlotRemove.Enabled = True
                _plotNum += 1
            Next
        End If
        PDialog.Dispose()
        'disable add if limit reached
        If _plotList.Count >= _plotLimit + 1 Then
            PlotAdd.Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' Rename an existing plot
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PlotRename_Click(sender As Object, e As EventArgs) Handles PlotRename.Click
        'find index of selection
        Dim Index As Integer = PlotBox.SelectedIndex
        'selection must be made and not Base Plot
        If Index > 0 Then
            'open name dialog
            Dim NDialog = New NameDialog(_myPlot.Name, _plotList)
            NDialog.ShowDialog()
            'change name in combobox and config object
            _myPlot.Name = NDialog.GetName
            PlotBox.Items(Index) = NDialog.GetName
            NDialog.Dispose()
        End If
    End Sub
    ''' <summary>
    ''' Remove an existing plot
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PlotRemove_Click(sender As Object, e As EventArgs) Handles PlotRemove.Click
        'remove each selected plot
        For i = 0 To PlotBox.SelectedIndices.Count - 1
            'find index of selection
            Dim Index As Integer = PlotBox.SelectedIndices(0)
            'selection must be made and not Base Plot
            If Index > 0 Then
                'remove object from combobox and plotlist
                _plotList.RemoveAt(Index)
                PlotBox.Items.RemoveAt(Index)
                'get rid of current sets
                SetBox.ClearSelected()
                SetBox.Items.Clear()
                If _plotList.Count <= 1 Then
                    DoPlot.Enabled = False
                    PlotRename.Enabled = False
                    PlotRemove.Enabled = False
                End If
            End If
        Next
        'enable add if under the limit
        If _plotList.Count < _plotLimit + 1 Then
            PlotAdd.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' Update plot config properties when plot index is changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PlotBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlotBox.SelectedIndexChanged
        If PlotBox.SelectedIndices.Count = 0 Then
            'if no selection, disable all
            _myPlot = Nothing
            YBox.Text = ""
            YBox.Enabled = False
            XBox.Text = ""
            XBox.Enabled = False
            SetBox.Items.Clear()
            PlotRemove.Enabled = False
            PlotRename.Enabled = False
            SetAdd.Enabled = False
            AllSetsBox.Enabled = False
            OneSeriesBox.Enabled = False
        ElseIf PlotBox.SelectedIndices.Count = 1 Then
            'enable controls if one selected
            Dim Index As Integer = PlotBox.SelectedIndex
            _myPlot = _plotList(Index)
            If Not IsNothing(_myPlot) Then
                PlotRemove.Enabled = True
                PlotRename.Enabled = True
                If Multigraph.SetList.Count > 0 Then
                    SetAdd.Enabled = True
                    AllSetsBox.Enabled = True
                    OneSeriesBox.Enabled = True
                End If
                'get rid of current sets
                SetBox.ClearSelected()
                SetBox.Items.Clear()
                OneSeriesBox.Checked = _myPlot.OneSeries
                'add new sets
                If _myPlot.AllSets Then
                    Dim goodSets As List(Of Integer) = Multigraph.VarDict.Item(_myPlot.X).Item1.Intersect(Multigraph.VarDict.Item(_myPlot.Y).Item1).ToList
                    AllSetsBox.Checked = True
                    SetBox.Enabled = False
                    SetAdd.Enabled = False
                    SetRemove.Enabled = False
                    SetBox.Items.Clear()
                    For i = 0 To goodSets.Count - 1
                        SetBox.Items.Add(Multigraph.SetList(goodSets(i)).Name)
                    Next
                Else
                    AllSetsBox.Checked = False
                    SetBox.Enabled = True
                    SetAdd.Enabled = True
                    SetRemove.Enabled = True
                    SetBox.Items.Clear()
                    For i = 0 To _myPlot.SetList.Count - 1
                        SetBox.Items.Add(_myPlot.SetList(i).Name)
                    Next
                End If
                'clear current vars
                XBox.Items.Clear()
                YBox.Items.Clear()
                'add all vars to x
                For i = 0 To _myPlot.VarList.Count - 1
                    XBox.Items.Add(_myPlot.VarList(i))
                Next
                'add all vars to y
                For i = 0 To _myPlot.VarList.Count - 1
                    YBox.Items.Add(_myPlot.VarList(i))
                Next
                'populate X and Y
                XBox.Text = _myPlot.X()
                YBox.Text = _myPlot.Y()
                XBox.Enabled = True
                YBox.Enabled = True
            End If
            Else
                'disable controls except remove
                _myPlot = Nothing
                YBox.Text = ""
                YBox.Enabled = False
                XBox.Text = ""
                XBox.Enabled = False
                SetBox.Items.Clear()
                PlotRemove.Enabled = True
                PlotRename.Enabled = False
                SetAdd.Enabled = False
                AllSetsBox.Enabled = False
                OneSeriesBox.Enabled = False
            End If
    End Sub
    ''' <summary>
    ''' Update color when selected index is changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SetBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SetBox.SelectedIndexChanged
        If SetBox.SelectedIndices.Count = 0 Then
            'if no sets selected, disable all
            ColorLabel.BackColor = Color.White
            SetRemove.Enabled = False
            SelColor.Enabled = False
        ElseIf SetBox.SelectedIndices.Count = 1 Then
            'if one, enable all
            Dim Index As Integer = SetBox.SelectedIndex
            ColorLabel.BackColor = _myPlot.Colors(Index)
            SelColor.Enabled = True
            SetRemove.Enabled = True
        Else
            'if multi, enable remove
            ColorLabel.BackColor = Color.White
            SetRemove.Enabled = True
            SelColor.Enabled = False
        End If
    End Sub
    ''' <summary>
    ''' Add an XLSet to the plot when Add button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SetAdd_Click(sender As Object, e As EventArgs) Handles SetAdd.Click
        'open set dialog if plot is selected
        If Not IsNothing(_myPlot) Then
            Dim SDialog = New SetDialog(_myPlot)
            SDialog.ShowDialog()
            If SDialog.GoodExit Then
                For Each MySet In SDialog.GetSets
                    'add set to list and box
                    If Not SetBox.Items.Contains(MySet.Name) Then
                        'If MySet.VarList.Contains(_myPlot.X) AndAlso MySet.VarList.Contains(_myPlot.Y) Then
                        _myPlot.AddSet(MySet)
                        SetBox.Items.Add(MySet.Name)
                        'alter possible vars
                        If SetBox.Items.Count = 1 Then
                            _myPlot.VarList = MySet.VarList
                        Else
                            _myPlot.VarList = MySet.VarList.Intersect(_myPlot.VarList).ToList
                        End If
                        'update x and y boxes
                        XBox.Items.Clear()
                        For i = 0 To _myPlot.VarList.Count - 1
                            XBox.Items.Add(_myPlot.VarList(i))
                        Next
                        XBox.Text = _myPlot.X
                        YBox.Items.Clear()
                        For i = 0 To _myPlot.VarList.Count - 1
                            YBox.Items.Add(_myPlot.VarList(i))
                        Next
                        YBox.Text = _myPlot.Y
                        'Else
                        '    MessageBox.Show("Multigraph could not add set " & MySet.Name & " due to lack of your chosen X or Y variable. Please choose again.", "Set Conflict")
                        'End If
                    End If
                Next
            End If
            SDialog.Dispose()
        End If
    End Sub
    ''' <summary>
    ''' Remove an XLSet when Remove button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SetRemove_Click(sender As Object, e As EventArgs) Handles SetRemove.Click
        For j = 0 To SetBox.SelectedIndices.Count - 1
            'find index of selection
            Dim Index As Integer = SetBox.SelectedIndices(0)
            'selection must be made
            If Index >= 0 Then
                'remove object from setbox and setlist
                _myPlot.RemoveSet(Index)
                SetBox.Items.RemoveAt(Index)
                'update varList
                If SetBox.Items.Count = 0 Then
                    'remove varlist if no sets left
                    _myPlot.VarList.Clear()
                    _myPlot.X = ""
                    _myPlot.Y = ""
                    XBox.Text = ""
                    YBox.Text = ""
                    XBox.Items.Clear()
                    YBox.Items.Clear()
                Else
                    'else do intersect of all sets left
                    Dim varList As List(Of String) = _myPlot.SetList(0).VarList
                    For i = 1 To _myPlot.SetList.Count - 1
                        varList = _myPlot.SetList(i).VarList.Intersect(varList).ToList
                    Next
                    _myPlot.VarList = varList
                    'update x and y boxes
                    XBox.Items.Clear()
                    For i = 0 To _myPlot.VarList.Count - 1
                        XBox.Items.Add(_myPlot.VarList(i))
                    Next
                    XBox.Text = _myPlot.X
                    YBox.Items.Clear()
                    For i = 0 To _myPlot.VarList.Count - 1
                        YBox.Items.Add(_myPlot.VarList(i))
                    Next
                    YBox.Text = _myPlot.Y
                End If
            End If
        Next
    End Sub
    ''' <summary>
    ''' close page
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DoCancel_Click(sender As Object, e As EventArgs) Handles DoCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' set x var
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub XBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles XBox.SelectionChangeCommitted
        Dim Index As Integer = XBox.SelectedIndex
        'set if item selected
        If Not IsNothing(_myPlot) AndAlso Index <> -1 Then
            _myPlot.X = XBox.Items(Index)
        End If
    End Sub
    ''' <summary>
    ''' set y var
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub YBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles YBox.SelectionChangeCommitted
        Dim Index As Integer = YBox.SelectedIndex
        'set if item selected
        If Not IsNothing(_myPlot) AndAlso Index <> -1 Then
            _myPlot.Y = YBox.Items(Index)
        End If
    End Sub
    ''' <summary>
    ''' select all available sets
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AllSets_CheckedChanged(sender As Object, e As EventArgs) Handles AllSetsBox.CheckedChanged
        Dim goodSets As List(Of Integer) = Multigraph.VarDict.Item(_myPlot.X).Item1.Intersect(Multigraph.VarDict.Item(_myPlot.Y).Item1).ToList
        Dim varList As List(Of String)

        _myPlot.AllSets = AllSetsBox.Checked
        'disable set controls and add all sets to the list if checked
        If AllSetsBox.Checked Then
            SetBox.Enabled = False
            SetAdd.Enabled = False
            SetRemove.Enabled = False
            SetBox.Items.Clear()
            'add sets to box
            For i = 0 To goodSets.Count - 1
                SetBox.Items.Add(Multigraph.SetList(goodSets(i)).Name)
            Next
            'populate vars
            If Multigraph.SetList.Count > 0 Then
                varList = Multigraph.SetList(0).VarList
                For i = 1 To Multigraph.SetList.Count - 1
                    varList = Multigraph.SetList(i).VarList.Intersect(varList).ToList
                Next
            Else
                varList = New List(Of String)
            End If
            _myPlot.VarList = varList
            'update x and y boxes
            XBox.Items.Clear()
            For i = 0 To _myPlot.VarList.Count - 1
                XBox.Items.Add(_myPlot.VarList(i))
            Next
            XBox.Text = _myPlot.X
            YBox.Items.Clear()
            For i = 0 To _myPlot.VarList.Count - 1
                YBox.Items.Add(_myPlot.VarList(i))
            Next
            YBox.Text = _myPlot.Y
        Else
            SetBox.Enabled = True
            SetAdd.Enabled = True
            SetRemove.Enabled = True
            SetBox.Items.Clear()
            For i = 0 To _myPlot.SetList.Count - 1
                SetBox.Items.Add(_myPlot.SetList(i).Name)
            Next
            'populate vars
            If _myPlot.SetList.Count > 0 Then
                varList = _myPlot.SetList(0).VarList
                For i = 1 To _myPlot.SetList.Count - 1
                    varList = _myPlot.SetList(i).VarList.Intersect(varList).ToList
                Next
            Else
                varList = New List(Of String)
            End If
            _myPlot.VarList = varList
            'update x and y boxes
            XBox.Items.Clear()
            For i = 0 To _myPlot.VarList.Count - 1
                XBox.Items.Add(_myPlot.VarList(i))
            Next
            XBox.Text = _myPlot.X
            YBox.Items.Clear()
            For i = 0 To _myPlot.VarList.Count - 1
                YBox.Items.Add(_myPlot.VarList(i))
            Next
            YBox.Text = _myPlot.Y
            End If
    End Sub
    ''' <summary>
    ''' enable all sets as one plot series
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OneSeries_CheckedChanged(sender As Object, e As EventArgs) Handles OneSeriesBox.CheckedChanged
        _myPlot.OneSeries = OneSeriesBox.Checked
        If _myPlot.OneSeries Then
            ColorLabel.BackColor = Color.White
            SelColor.Enabled = False
        Else
            If SetBox.SelectedIndex <> -1 Then
                ColorLabel.BackColor = _myPlot.Colors(SetBox.SelectedIndex)
            End If
            SelColor.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' show all plots
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DoPlot_Click(sender As Object, e As EventArgs) Handles DoPlot.Click
        Dim PWin As PlotWindow = New PlotWindow(Me)
        PWin.Show()
    End Sub
End Class