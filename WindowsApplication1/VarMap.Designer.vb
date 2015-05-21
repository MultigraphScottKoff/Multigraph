<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VarMap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VarMap))
        Me.VarView = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.VarView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VarView
        '
        Me.VarView.AllowEditing = False
        Me.VarView.AllowFiltering = True
        Me.VarView.AutoGenerateColumns = False
        Me.VarView.AutoResize = True
        Me.VarView.CellButtonImage = Global.WindowsApplication1.My.Resources.Resources.Koala
        Me.VarView.ClipboardCopyMode = C1.Win.C1FlexGrid.ClipboardCopyModeEnum.DataAndAllHeaders
        Me.VarView.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.VarView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VarView.Location = New System.Drawing.Point(0, 0)
        Me.VarView.Name = "VarView"
        Me.VarView.Rows.DefaultSize = 17
        Me.VarView.Size = New System.Drawing.Size(547, 442)
        Me.VarView.StyleInfo = resources.GetString("VarView.StyleInfo")
        Me.VarView.TabIndex = 1
        '
        'VarMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 442)
        Me.Controls.Add(Me.VarView)
        Me.Name = "VarMap"
        Me.Text = "Variable Map"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.VarView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VarView As C1.Win.C1FlexGrid.C1FlexGrid
End Class
