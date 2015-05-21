<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpDialog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FChange = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.DefaultFolder = New System.Windows.Forms.Label()
        Me.RemoveBlanksBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Default Folder:"
        '
        'FChange
        '
        Me.FChange.AutoSize = True
        Me.FChange.Location = New System.Drawing.Point(481, 4)
        Me.FChange.Name = "FChange"
        Me.FChange.Size = New System.Drawing.Size(91, 23)
        Me.FChange.TabIndex = 1
        Me.FChange.Text = "Change Folder"
        Me.FChange.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'DefaultFolder
        '
        Me.DefaultFolder.ForeColor = System.Drawing.Color.LimeGreen
        Me.DefaultFolder.Location = New System.Drawing.Point(94, 9)
        Me.DefaultFolder.Name = "DefaultFolder"
        Me.DefaultFolder.Size = New System.Drawing.Size(381, 18)
        Me.DefaultFolder.TabIndex = 3
        '
        'RemoveBlanksBox
        '
        Me.RemoveBlanksBox.AutoSize = True
        Me.RemoveBlanksBox.Location = New System.Drawing.Point(15, 30)
        Me.RemoveBlanksBox.Name = "RemoveBlanksBox"
        Me.RemoveBlanksBox.Size = New System.Drawing.Size(267, 17)
        Me.RemoveBlanksBox.TabIndex = 5
        Me.RemoveBlanksBox.Text = "Remove Blank Rows/Columns From Imported Data"
        Me.RemoveBlanksBox.UseVisualStyleBackColor = True
        '
        'OpDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.RemoveBlanksBox)
        Me.Controls.Add(Me.DefaultFolder)
        Me.Controls.Add(Me.FChange)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OpDialog"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FChange As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DefaultFolder As System.Windows.Forms.Label
    Friend WithEvents RemoveBlanksBox As System.Windows.Forms.CheckBox
End Class
