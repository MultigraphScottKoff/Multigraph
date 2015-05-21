<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filter
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SetBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DispTab = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FilterTab = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FilButton = New System.Windows.Forms.Button()
        Me.ClrFilButton = New System.Windows.Forms.Button()
        Me.NewVarButton = New System.Windows.Forms.Button()
        Me.PreNewVarButton = New System.Windows.Forms.Button()
        Me.SaveComButton = New System.Windows.Forms.Button()
        Me.ComButton = New System.Windows.Forms.Button()
        Me.ComText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VarButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VarBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComNameBox = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.DispTab.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FilterTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(747, 449)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Cancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Save)
        Me.FlowLayoutPanel1.Controls.Add(Me.NameBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SetBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 417)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(741, 29)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(663, 3)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(582, 3)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 2
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'NameBox
        '
        Me.NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.Location = New System.Drawing.Point(385, 3)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(191, 23)
        Me.NameBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(291, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New Set Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SetBox
        '
        Me.SetBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SetBox.FormattingEnabled = True
        Me.SetBox.Location = New System.Drawing.Point(100, 3)
        Me.SetBox.Name = "SetBox"
        Me.SetBox.Size = New System.Drawing.Size(185, 24)
        Me.SetBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select Data Set:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DispTab)
        Me.TabControl1.Controls.Add(Me.FilterTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(741, 408)
        Me.TabControl1.TabIndex = 5
        '
        'DispTab
        '
        Me.DispTab.Controls.Add(Me.DataGridView1)
        Me.DispTab.Location = New System.Drawing.Point(4, 22)
        Me.DispTab.Name = "DispTab"
        Me.DispTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DispTab.Size = New System.Drawing.Size(733, 382)
        Me.DispTab.TabIndex = 0
        Me.DispTab.Text = "Display"
        Me.DispTab.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(727, 376)
        Me.DataGridView1.TabIndex = 4
        '
        'FilterTab
        '
        Me.FilterTab.BackColor = System.Drawing.SystemColors.Control
        Me.FilterTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilterTab.Controls.Add(Me.Panel1)
        Me.FilterTab.Location = New System.Drawing.Point(4, 22)
        Me.FilterTab.Name = "FilterTab"
        Me.FilterTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FilterTab.Size = New System.Drawing.Size(733, 382)
        Me.FilterTab.TabIndex = 1
        Me.FilterTab.Text = "Filter"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel1.Controls.Add(Me.ComButton)
        Me.Panel1.Controls.Add(Me.ComText)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.VarButton)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 374)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.FilButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.ClrFilButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.NewVarButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.PreNewVarButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.SaveComButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 328)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(725, 46)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'FilButton
        '
        Me.FilButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilButton.Location = New System.Drawing.Point(583, 3)
        Me.FilButton.Name = "FilButton"
        Me.FilButton.Size = New System.Drawing.Size(139, 40)
        Me.FilButton.TabIndex = 0
        Me.FilButton.Text = "Filter"
        Me.FilButton.UseVisualStyleBackColor = True
        '
        'ClrFilButton
        '
        Me.ClrFilButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClrFilButton.Location = New System.Drawing.Point(438, 3)
        Me.ClrFilButton.Name = "ClrFilButton"
        Me.ClrFilButton.Size = New System.Drawing.Size(139, 40)
        Me.ClrFilButton.TabIndex = 1
        Me.ClrFilButton.Text = "Clear Filter"
        Me.ClrFilButton.UseVisualStyleBackColor = True
        '
        'NewVarButton
        '
        Me.NewVarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewVarButton.Location = New System.Drawing.Point(293, 3)
        Me.NewVarButton.Name = "NewVarButton"
        Me.NewVarButton.Size = New System.Drawing.Size(139, 40)
        Me.NewVarButton.TabIndex = 2
        Me.NewVarButton.Text = "Create Variable"
        Me.NewVarButton.UseVisualStyleBackColor = True
        '
        'PreNewVarButton
        '
        Me.PreNewVarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreNewVarButton.Location = New System.Drawing.Point(148, 3)
        Me.PreNewVarButton.Name = "PreNewVarButton"
        Me.PreNewVarButton.Size = New System.Drawing.Size(139, 40)
        Me.PreNewVarButton.TabIndex = 3
        Me.PreNewVarButton.Text = "Preview Output"
        Me.PreNewVarButton.UseVisualStyleBackColor = True
        '
        'SaveComButton
        '
        Me.SaveComButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveComButton.Location = New System.Drawing.Point(3, 3)
        Me.SaveComButton.Name = "SaveComButton"
        Me.SaveComButton.Size = New System.Drawing.Size(139, 40)
        Me.SaveComButton.TabIndex = 4
        Me.SaveComButton.Text = "Save Command"
        Me.SaveComButton.UseVisualStyleBackColor = True
        '
        'ComButton
        '
        Me.ComButton.Location = New System.Drawing.Point(608, 18)
        Me.ComButton.Name = "ComButton"
        Me.ComButton.Size = New System.Drawing.Size(103, 35)
        Me.ComButton.TabIndex = 6
        Me.ComButton.Text = "Add Command"
        Me.ComButton.UseVisualStyleBackColor = True
        '
        'ComText
        '
        Me.ComText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComText.Location = New System.Drawing.Point(4, 257)
        Me.ComText.Margin = New System.Windows.Forms.Padding(0, 2, 0, 16)
        Me.ComText.Multiline = True
        Me.ComText.Name = "ComText"
        Me.ComText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ComText.Size = New System.Drawing.Size(718, 65)
        Me.ComText.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(4, 236)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Command Designer"
        '
        'VarButton
        '
        Me.VarButton.Location = New System.Drawing.Point(608, 93)
        Me.VarButton.Name = "VarButton"
        Me.VarButton.Size = New System.Drawing.Size(103, 35)
        Me.VarButton.TabIndex = 2
        Me.VarButton.Text = "Add Variable"
        Me.VarButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel4.Controls.Add(Me.ComBox)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel4.Controls.Add(Me.VarBox)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel4.Controls.Add(Me.ComNameBox)
        Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(588, 230)
        Me.FlowLayoutPanel4.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Commands"
        '
        'ComBox
        '
        Me.ComBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBox.FormattingEnabled = True
        Me.ComBox.Location = New System.Drawing.Point(1, 21)
        Me.ComBox.Margin = New System.Windows.Forms.Padding(0, 2, 0, 30)
        Me.ComBox.Name = "ComBox"
        Me.ComBox.Size = New System.Drawing.Size(586, 24)
        Me.ComBox.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 75)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Variables"
        '
        'VarBox
        '
        Me.VarBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VarBox.FormattingEnabled = True
        Me.VarBox.Location = New System.Drawing.Point(1, 96)
        Me.VarBox.Margin = New System.Windows.Forms.Padding(0, 2, 0, 30)
        Me.VarBox.Name = "VarBox"
        Me.VarBox.Size = New System.Drawing.Size(586, 24)
        Me.VarBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "New Command Name"
        '
        'ComNameBox
        '
        Me.ComNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ComNameBox.Location = New System.Drawing.Point(1, 171)
        Me.ComNameBox.Margin = New System.Windows.Forms.Padding(0, 2, 0, 30)
        Me.ComNameBox.Name = "ComNameBox"
        Me.ComNameBox.Size = New System.Drawing.Size(586, 22)
        Me.ComNameBox.TabIndex = 8
        '
        'SaveFileDialog1
        '
        '
        'OpenFileDialog1
        '
        '
        'Filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(747, 449)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.Name = "Filter"
        Me.Text = "Filter"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.DispTab.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FilterTab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SetBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents DispTab As System.Windows.Forms.TabPage
    Friend WithEvents FilterTab As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VarButton As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VarBox As System.Windows.Forms.ComboBox
    Friend WithEvents ComButton As System.Windows.Forms.Button
    Friend WithEvents ComText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FilButton As System.Windows.Forms.Button
    Friend WithEvents ClrFilButton As System.Windows.Forms.Button
    Friend WithEvents NewVarButton As System.Windows.Forms.Button
    Friend WithEvents PreNewVarButton As System.Windows.Forms.Button
    Friend WithEvents SaveComButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComNameBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
