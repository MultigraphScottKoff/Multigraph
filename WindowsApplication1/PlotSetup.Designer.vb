<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlotSetup
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PlotBox = New System.Windows.Forms.ListBox()
        Me.PlotAdd = New System.Windows.Forms.Button()
        Me.PlotRename = New System.Windows.Forms.Button()
        Me.PlotRemove = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SetBox = New System.Windows.Forms.ListBox()
        Me.SetAdd = New System.Windows.Forms.Button()
        Me.SetRemove = New System.Windows.Forms.Button()
        Me.AllSetsBox = New System.Windows.Forms.CheckBox()
        Me.OneSeriesBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.XBox = New System.Windows.Forms.ComboBox()
        Me.YBox = New System.Windows.Forms.ComboBox()
        Me.DoPlot = New System.Windows.Forms.Button()
        Me.DoCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.SelColor = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlotBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlotAdd)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlotRename)
        Me.FlowLayoutPanel1.Controls.Add(Me.PlotRemove)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(254, 267)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Plot Select"
        '
        'PlotBox
        '
        Me.PlotBox.FormattingEnabled = True
        Me.PlotBox.Location = New System.Drawing.Point(3, 16)
        Me.PlotBox.Name = "PlotBox"
        Me.PlotBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.PlotBox.Size = New System.Drawing.Size(167, 238)
        Me.PlotBox.TabIndex = 0
        '
        'PlotAdd
        '
        Me.PlotAdd.Location = New System.Drawing.Point(176, 3)
        Me.PlotAdd.Name = "PlotAdd"
        Me.PlotAdd.Size = New System.Drawing.Size(75, 23)
        Me.PlotAdd.TabIndex = 1
        Me.PlotAdd.Text = "Add"
        Me.PlotAdd.UseVisualStyleBackColor = True
        '
        'PlotRename
        '
        Me.PlotRename.Enabled = False
        Me.PlotRename.Location = New System.Drawing.Point(176, 32)
        Me.PlotRename.Name = "PlotRename"
        Me.PlotRename.Size = New System.Drawing.Size(75, 23)
        Me.PlotRename.TabIndex = 3
        Me.PlotRename.Text = "Rename"
        Me.PlotRename.UseVisualStyleBackColor = True
        '
        'PlotRemove
        '
        Me.PlotRemove.Enabled = False
        Me.PlotRemove.Location = New System.Drawing.Point(176, 61)
        Me.PlotRemove.Name = "PlotRemove"
        Me.PlotRemove.Size = New System.Drawing.Size(75, 23)
        Me.PlotRemove.TabIndex = 2
        Me.PlotRemove.Text = "Remove"
        Me.PlotRemove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Set Select"
        '
        'SetBox
        '
        Me.FlowLayoutPanel2.SetFlowBreak(Me.SetBox, True)
        Me.SetBox.FormattingEnabled = True
        Me.SetBox.Location = New System.Drawing.Point(3, 16)
        Me.SetBox.Name = "SetBox"
        Me.SetBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.SetBox.Size = New System.Drawing.Size(131, 121)
        Me.SetBox.TabIndex = 1
        '
        'SetAdd
        '
        Me.SetAdd.Enabled = False
        Me.SetAdd.Location = New System.Drawing.Point(140, 3)
        Me.SetAdd.Name = "SetAdd"
        Me.SetAdd.Size = New System.Drawing.Size(75, 23)
        Me.SetAdd.TabIndex = 2
        Me.SetAdd.Text = "Add"
        Me.SetAdd.UseVisualStyleBackColor = True
        '
        'SetRemove
        '
        Me.SetRemove.Enabled = False
        Me.SetRemove.Location = New System.Drawing.Point(140, 32)
        Me.SetRemove.Name = "SetRemove"
        Me.SetRemove.Size = New System.Drawing.Size(75, 23)
        Me.SetRemove.TabIndex = 3
        Me.SetRemove.Text = "Remove"
        Me.SetRemove.UseVisualStyleBackColor = True
        '
        'AllSetsBox
        '
        Me.AllSetsBox.AutoSize = True
        Me.AllSetsBox.Enabled = False
        Me.AllSetsBox.Location = New System.Drawing.Point(140, 61)
        Me.AllSetsBox.Name = "AllSetsBox"
        Me.AllSetsBox.Size = New System.Drawing.Size(140, 17)
        Me.AllSetsBox.TabIndex = 4
        Me.AllSetsBox.Text = "Select All Available Sets"
        Me.AllSetsBox.UseVisualStyleBackColor = True
        '
        'OneSeriesBox
        '
        Me.OneSeriesBox.AutoSize = True
        Me.OneSeriesBox.Enabled = False
        Me.OneSeriesBox.Location = New System.Drawing.Point(140, 84)
        Me.OneSeriesBox.Name = "OneSeriesBox"
        Me.OneSeriesBox.Size = New System.Drawing.Size(131, 17)
        Me.OneSeriesBox.TabIndex = 5
        Me.OneSeriesBox.Text = "One Series for All Sets"
        Me.OneSeriesBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Variable Select"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "X Variable"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Y Variable"
        '
        'XBox
        '
        Me.XBox.Enabled = False
        Me.XBox.FormattingEnabled = True
        Me.XBox.Location = New System.Drawing.Point(321, 179)
        Me.XBox.Name = "XBox"
        Me.XBox.Size = New System.Drawing.Size(182, 21)
        Me.XBox.TabIndex = 8
        '
        'YBox
        '
        Me.YBox.Enabled = False
        Me.YBox.FormattingEnabled = True
        Me.YBox.Location = New System.Drawing.Point(321, 217)
        Me.YBox.Name = "YBox"
        Me.YBox.Size = New System.Drawing.Size(182, 21)
        Me.YBox.TabIndex = 9
        '
        'DoPlot
        '
        Me.DoPlot.Enabled = False
        Me.DoPlot.Location = New System.Drawing.Point(548, 177)
        Me.DoPlot.Name = "DoPlot"
        Me.DoPlot.Size = New System.Drawing.Size(75, 23)
        Me.DoPlot.TabIndex = 10
        Me.DoPlot.Text = "Plot"
        Me.DoPlot.UseVisualStyleBackColor = True
        '
        'DoCancel
        '
        Me.DoCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.DoCancel.Location = New System.Drawing.Point(548, 215)
        Me.DoCancel.Name = "DoCancel"
        Me.DoCancel.Size = New System.Drawing.Size(75, 23)
        Me.DoCancel.TabIndex = 11
        Me.DoCancel.Text = "Cancel"
        Me.DoCancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(547, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Data Set Color"
        '
        'ColorLabel
        '
        Me.ColorLabel.BackColor = System.Drawing.Color.White
        Me.ColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ColorLabel.Location = New System.Drawing.Point(569, 28)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(30, 30)
        Me.ColorLabel.TabIndex = 15
        '
        'SelColor
        '
        Me.SelColor.Enabled = False
        Me.SelColor.Location = New System.Drawing.Point(548, 64)
        Me.SelColor.Name = "SelColor"
        Me.SelColor.Size = New System.Drawing.Size(75, 23)
        Me.SelColor.TabIndex = 16
        Me.SelColor.Text = "Select Color"
        Me.SelColor.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.SetBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.SetAdd)
        Me.FlowLayoutPanel2.Controls.Add(Me.SetRemove)
        Me.FlowLayoutPanel2.Controls.Add(Me.AllSetsBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.OneSeriesBox)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(260, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(282, 143)
        Me.FlowLayoutPanel2.TabIndex = 17
        '
        'PlotSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.DoCancel
        Me.ClientSize = New System.Drawing.Size(664, 271)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.SelColor)
        Me.Controls.Add(Me.ColorLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DoCancel)
        Me.Controls.Add(Me.DoPlot)
        Me.Controls.Add(Me.YBox)
        Me.Controls.Add(Me.XBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "PlotSetup"
        Me.Text = "Plot Setup"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PlotBox As System.Windows.Forms.ListBox
    Friend WithEvents PlotAdd As System.Windows.Forms.Button
    Friend WithEvents PlotRemove As System.Windows.Forms.Button
    Friend WithEvents PlotRename As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SetBox As System.Windows.Forms.ListBox
    Friend WithEvents SetAdd As System.Windows.Forms.Button
    Friend WithEvents SetRemove As System.Windows.Forms.Button
    Friend WithEvents AllSetsBox As System.Windows.Forms.CheckBox
    Friend WithEvents OneSeriesBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XBox As System.Windows.Forms.ComboBox
    Friend WithEvents YBox As System.Windows.Forms.ComboBox
    Friend WithEvents DoPlot As System.Windows.Forms.Button
    Friend WithEvents DoCancel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorLabel As System.Windows.Forms.Label
    Friend WithEvents SelColor As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
End Class
