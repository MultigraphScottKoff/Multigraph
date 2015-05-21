<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlotAddDialog
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
        Me.NumPlotUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AddButton = New System.Windows.Forms.Button()
        CType(Me.NumPlotUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumPlotUpDown
        '
        Me.NumPlotUpDown.Location = New System.Drawing.Point(12, 12)
        Me.NumPlotUpDown.Name = "NumPlotUpDown"
        Me.NumPlotUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NumPlotUpDown.Size = New System.Drawing.Size(47, 20)
        Me.NumPlotUpDown.TabIndex = 0
        Me.NumPlotUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(65, 9)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'PlotAddDialog
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(152, 44)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.NumPlotUpDown)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PlotAddDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Plots"
        Me.TopMost = True
        CType(Me.NumPlotUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NumPlotUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AddButton As System.Windows.Forms.Button
End Class
