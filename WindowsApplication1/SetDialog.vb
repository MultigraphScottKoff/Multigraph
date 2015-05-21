''' <summary>
''' A dialog for choosing XLSets to add to a plot
''' </summary>
''' <remarks></remarks>
Public Class SetDialog

    Private SetList As List(Of XLSet)
    Private NumSets As Integer
    Private GoodSets As List(Of Integer)
    Private _setList As List(Of XLSet)
    Private _goodExit As Boolean

    Public Sub New(MyPlot As PlotConfig)

        ' This call is required by the designer.
        InitializeComponent()
        _setList = New List(Of XLSet)
        SetList = Multigraph.SetList
        NumSets = Multigraph.NumSets
        GoodSets = Multigraph.VarDict.Item(MyPlot.X).Item1.Intersect(Multigraph.VarDict.Item(MyPlot.Y).Item1).ToList
        For i = 0 To GoodSets.Count - 1
            SetBox.Items.Add(SetList(GoodSets(i)).Name)
        Next
    End Sub
    ''' <summary>
    ''' Checks whether dialog exited well
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GoodExit() As Boolean
        Return _goodExit
    End Function
    ''' <summary>
    ''' Get selected sets from dialog
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetSets() As List(Of XLSet)
        Return _setList
    End Function
    ''' <summary>
    ''' Validates set selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim numSelected = SetBox.SelectedIndices.Count
        If numSelected > 0 Then
            For i = 0 To numSelected - 1
                Dim Index As Integer = SetBox.SelectedIndices(i)
                _setList.Add(SetList(GoodSets(Index)))
            Next
            _goodExit = True
            Close()
        End If
    End Sub
End Class