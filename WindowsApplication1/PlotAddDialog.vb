''' <summary>
''' Dialog for selecting number of plots to add
''' </summary>
''' <remarks></remarks>
Public Class PlotAddDialog

    Private _goodExit As Boolean
    Private _numPlots As Integer

    Public Sub New(count As Integer, limit As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        NumPlotUpDown.Maximum = limit + 1 - count
        _goodExit = False
        _numPlots = NumPlotUpDown.Value

    End Sub
    ''' <summary>
    ''' exit dialog and return number of plots to add
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        _goodExit = True
        _numPlots = NumPlotUpDown.Value
        Close()
    End Sub
    ''' <summary>
    ''' Return whether dialog exited well
    ''' </summary>
    ''' <remarks></remarks>
    Public Function GoodExit() As Boolean
        Return _goodExit
    End Function
    ''' <summary>
    ''' Return number of plots to add
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function NumPlots() As Integer
        Return _numPlots
    End Function
    ''' <summary>
    ''' resets cursor on enter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NumPlotUpDown_Enter(sender As Object, e As EventArgs) Handles NumPlotUpDown.Enter
        ResetCursorNPUD()
    End Sub
    ''' <summary>
    ''' sets cursor to initial position in numplotupdown
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ResetCursorNPUD()
        Dim lengthOfAnswer = NumPlotUpDown.Value.ToString().Length
        NumPlotUpDown.Select(0, lengthOfAnswer)
    End Sub
    ''' <summary>
    ''' ensure value does not read more than max
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NumPlotUpDown_KeyUp(sender As Object, e As KeyEventArgs) Handles NumPlotUpDown.KeyUp
        If NumPlotUpDown.Value > NumPlotUpDown.Maximum Then
            NumPlotUpDown.Value = NumPlotUpDown.Maximum
        End If
    End Sub
End Class