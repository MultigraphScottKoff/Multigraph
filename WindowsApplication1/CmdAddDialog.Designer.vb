<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CmdAddDialog
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NewNameBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ExcludeButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(3, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(39, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "is an existing Multigraph command. Would you like to rename it or exclude it from" & _
    " the project?"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.NameLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(327, 41)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "New Name:"
        '
        'NewNameBox
        '
        Me.NewNameBox.Location = New System.Drawing.Point(72, 41)
        Me.NewNameBox.Name = "NewNameBox"
        Me.NewNameBox.Size = New System.Drawing.Size(255, 20)
        Me.NewNameBox.TabIndex = 4
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(72, 67)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Rename"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ExcludeButton
        '
        Me.ExcludeButton.Location = New System.Drawing.Point(165, 67)
        Me.ExcludeButton.Name = "ExcludeButton"
        Me.ExcludeButton.Size = New System.Drawing.Size(75, 23)
        Me.ExcludeButton.TabIndex = 6
        Me.ExcludeButton.Text = "Exclude"
        Me.ExcludeButton.UseVisualStyleBackColor = True
        '
        'CmdAddDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 100)
        Me.Controls.Add(Me.ExcludeButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.NewNameBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "CmdAddDialog"
        Me.Text = "Command Editor"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NewNameBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents ExcludeButton As System.Windows.Forms.Button
End Class
