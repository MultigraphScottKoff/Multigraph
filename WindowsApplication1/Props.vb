''' <summary>
''' An interface for changing properties of XLSets
''' </summary>
''' <remarks></remarks>
Public Class Props

    Private _setList As List(Of XLSet)
    Private _mySet As XLSet
    Private _dIndex As Integer 'index of MySet in SetList, saves time of accessing MySet.ID

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _setList = Multigraph.SetList
        'add set names to dropdown
        For i = 0 To _setList.Count - 1
            SetBox.Items.Add(_setList(i).Name)
        Next

    End Sub
    ''' <summary>
    ''' When user selects a name, update property fields
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SetBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SetBox.SelectionChangeCommitted

        _dIndex = SetBox.SelectedIndex
        _mySet = _setList(_dIndex)
        IDLabel.Text = _mySet.ID
        VarLabel.Text = _mySet.Vars
        EntryLabel.Text = _mySet.Entries

    End Sub
    ''' <summary>
    ''' Close window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        Close()
    End Sub

    ''' <summary>
    ''' Commits name changes and asserts uniqueness when user clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If NameBox.Text <> "" Then
            Dim nameTaken As Boolean
            nameTaken = False
            'check if valid name
            For i = 0 To _setList.Count - 1
                If _setList(i).Name = NameBox.Text Then nameTaken = True
            Next

            If nameTaken Then
                MessageBox.Show("That name is already taken. Please choose another.", "Name Unavailable")
            Else
                _mySet.Name = NameBox.Text
                Multigraph.MySet.Name = _mySet.Name
                SetBox.Items(_dIndex) = _setList(_dIndex).Name
            End If
        End If
    End Sub
End Class
