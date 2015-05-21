Public Class OpDialog

    Private _path As String
    Private _removeBlanks As Boolean


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _path = My.Settings.Path
        DefaultFolder.Text = _path
        _removeBlanks = My.Settings.RemoveBlanks
        RemoveBlanksBox.Checked = _removeBlanks
    End Sub
    ''' <summary>
    ''' save options to settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SaveOps()
        My.Settings.Path = _path
        My.Settings.RemoveBlanks = _removeBlanks
        My.Settings.Save()
    End Sub
    ''' <summary>
    ''' change default folder for file dialog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FChange_Click(sender As Object, e As EventArgs) Handles FChange.Click
        FolderBrowserDialog1.ShowDialog()
        _path = FolderBrowserDialog1.SelectedPath
        DefaultFolder.Text = _path
    End Sub
    ''' <summary>
    ''' change setting to remove rows/columns that begin with blank cells
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RemoveBox_CheckedChanged(sender As Object, e As EventArgs) Handles RemoveBlanksBox.CheckedChanged
        _removeBlanks = RemoveBlanksBox.Checked
    End Sub
End Class