<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Props
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
        Me.SetBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EntryLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VarLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'SetBox
        '
        Me.SetBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SetBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SetBox.FormattingEnabled = True
        Me.SetBox.Location = New System.Drawing.Point(151, 12)
        Me.SetBox.Name = "SetBox"
        Me.SetBox.Size = New System.Drawing.Size(121, 21)
        Me.SetBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Set"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Rows"
        '
        'EntryLabel
        '
        Me.EntryLabel.AutoSize = True
        Me.EntryLabel.Location = New System.Drawing.Point(148, 132)
        Me.EntryLabel.Name = "EntryLabel"
        Me.EntryLabel.Size = New System.Drawing.Size(0, 13)
        Me.EntryLabel.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Data Set ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Variables"
        '
        'VarLabel
        '
        Me.VarLabel.AutoSize = True
        Me.VarLabel.Location = New System.Drawing.Point(148, 92)
        Me.VarLabel.Name = "VarLabel"
        Me.VarLabel.Size = New System.Drawing.Size(0, 13)
        Me.VarLabel.TabIndex = 7
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(148, 52)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(0, 13)
        Me.IDLabel.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Change Name"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(151, 172)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(121, 20)
        Me.NameBox.TabIndex = 10
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(15, 377)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 24)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Save Changes"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CButton
        '
        Me.CButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CButton.Location = New System.Drawing.Point(172, 377)
        Me.CButton.Name = "CButton"
        Me.CButton.Size = New System.Drawing.Size(100, 24)
        Me.CButton.TabIndex = 12
        Me.CButton.Text = "Cancel"
        Me.CButton.UseVisualStyleBackColor = True
        '
        'Props
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CButton
        Me.ClientSize = New System.Drawing.Size(284, 412)
        Me.Controls.Add(Me.CButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.VarLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EntryLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SetBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Props"
        Me.Text = "Properties"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SetBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EntryLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VarLabel As System.Windows.Forms.Label
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CButton As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
