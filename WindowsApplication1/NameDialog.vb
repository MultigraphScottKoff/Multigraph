''' <summary>
''' A dialog for choosing/changing a name
''' </summary>
''' <remarks></remarks>
Public Class NameDialog
    Private _name As String
    Private _goodExit As Boolean
    Private PlotList As List(Of PlotConfig)

    Public Sub New(Name As String, _plotList As List(Of PlotConfig))

        ' This call is required by the designer.
        InitializeComponent()
        _goodExit = False
        TextBox1.Text = Name
        _name = Name
        PlotList = _plotList

    End Sub
    ''' <summary>
    ''' Get final name value from dialog
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetName() As String
        Return _name
    End Function
    ''' <summary>
    ''' Checks whether dialog exited well
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GoodExit() As Boolean
        Return _goodExit
    End Function
    ''' <summary>
    ''' Accepts name in text box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim goodName As Boolean = True
        _name = TextBox1.Text
        'check if another plot has this name
        For Each plot In PlotList
            If plot.Name = _name Then
                goodName = False
            End If
        Next
        If goodName Then
            _goodExit = True
            Close()
        Else
            MessageBox.Show("Please choose a name that is not in use.", "Name Conflict")
        End If
    End Sub
End Class