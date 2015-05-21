<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveFilterData
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
        Me.YesButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.DoCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'YesButton
        '
        Me.YesButton.Location = New System.Drawing.Point(93, 45)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(75, 23)
        Me.YesButton.TabIndex = 1
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'NoButton
        '
        Me.NoButton.Location = New System.Drawing.Point(174, 45)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(75, 23)
        Me.NoButton.TabIndex = 2
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'DoCancel
        '
        Me.DoCancel.Location = New System.Drawing.Point(255, 45)
        Me.DoCancel.Name = "DoCancel"
        Me.DoCancel.Size = New System.Drawing.Size(75, 23)
        Me.DoCancel.TabIndex = 3
        Me.DoCancel.Text = "Cancel"
        Me.DoCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Some changes have not been saved. Would you like to overwrite the current dataset" & _
    "?"
        '
        'SaveFilterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 80)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DoCancel)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SaveFilterData"
        Me.Text = "SaveFilterData"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents YesButton As System.Windows.Forms.Button
    Friend WithEvents NoButton As System.Windows.Forms.Button
    Friend WithEvents DoCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
