Public Class CmdAddDialog

    Private _newName As String
    Private _exclude As Boolean

    Public Sub New(name As String)

        InitializeComponent()
        NameLabel.Text = name
        _newName = name

    End Sub
    ''' <summary>
    ''' replacement name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NewName As String
        Get
            Return _newName
        End Get
        Set(value As String)
            _newName = value
        End Set
    End Property
    ''' <summary>
    ''' exclude cmd from file?
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Exclude As Boolean
        Get
            Return _exclude
        End Get
        Set(value As Boolean)
            _exclude = value
        End Set
    End Property
    ''' <summary>
    ''' do not include command in project
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExcludeButton_Click(sender As Object, e As EventArgs) Handles ExcludeButton.Click
        _exclude = True
        Close()
    End Sub
    ''' <summary>
    ''' include command with new name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        _newName = NewNameBox.Text
        _exclude = False
        Close()
    End Sub
End Class