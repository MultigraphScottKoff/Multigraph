''' <summary>
''' A view to display all sets to which a variable belongs
''' </summary>
''' <remarks></remarks>
Public Class VarMap

    Private SetList As List(Of XLSet)
    Private VarDict As Dictionary(Of String, Tuple(Of List(Of Integer), List(Of Long)))

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SetList = Multigraph.SetList
        VarDict = Multigraph.VarDict
        'init varView by removing all rows and columns
        VarView.BeginInit()
        VarView.Rows.RemoveRange(1, VarView.Rows.Count - 1)
        VarView.Cols.RemoveRange(1, VarView.Cols.Count - 1)
        VarView.EndInit()
        'update varView by adding cols and rows with headers
        VarView.BeginUpdate()
        'add col headers
        For i = 0 To Multigraph.NumSets - 1
            Dim col = VarView.Cols.Add()
            col.Caption = SetList(i).Name
        Next
        'add row headers and info
        Dim keyNum As Long = 1
        For Each key In VarDict.Keys
            Dim row = VarView.Rows.Add()
            row.Caption = key
            For i = 0 To VarDict.Item(key).Item1.Count - 1
                Dim style As C1.Win.C1FlexGrid.CellStyle
                style = VarView.Styles.Add("style")
                style.BackColor = Color.Black
                VarView.SetCellStyle(row.SafeIndex, VarDict.Item(key).Item1(i) + 1, style)
                'varView.SetCellCheck(row.SafeIndex, varDict.Item(key)(i).Item1, C1.Win.C1FlexGrid.CheckEnum.Checked)
            Next
            keyNum += 1
        Next
        VarView.AutoSizeCols()
        VarView.AutoSizeRows()
        VarView.EndUpdate()
    End Sub

End Class