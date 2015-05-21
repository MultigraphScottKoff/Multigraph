Public Class SaveFilterData
    Private _status As Integer
    Public Sub New()

        InitializeComponent()

    End Sub
    Public ReadOnly Property Status As Integer
        Get
            Return _status
        End Get
    End Property
    ''' <summary>
    ''' overwrite
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        _status = 1
        Close()
    End Sub
    ''' <summary>
    ''' no overwrite
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        _status = 0
        Close()
    End Sub
    ''' <summary>
    ''' stop exiting
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles DoCancel.Click
        _status = -1
        Close()
    End Sub
End Class