<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetDialog
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
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.SetBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(34, 178)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.TabIndex = 0
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'SetBox
        '
        Me.SetBox.FormattingEnabled = True
        Me.SetBox.Location = New System.Drawing.Point(12, 12)
        Me.SetBox.Name = "SetBox"
        Me.SetBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.SetBox.Size = New System.Drawing.Size(120, 160)
        Me.SetBox.TabIndex = 3
        '
        'SetDialog
        '
        Me.AcceptButton = Me.ConfirmButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(144, 207)
        Me.Controls.Add(Me.SetBox)
        Me.Controls.Add(Me.ConfirmButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Data Sets"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
    Friend WithEvents SetBox As System.Windows.Forms.ListBox
End Class
