<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multigraph
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
        Me.IData = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Props = New System.Windows.Forms.Button()
        Me.VMap = New System.Windows.Forms.Button()
        Me.Plot = New System.Windows.Forms.Button()
        Me.Ops = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Filter = New System.Windows.Forms.Button()
        Me.Test = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IData
        '
        Me.IData.Location = New System.Drawing.Point(365, 12)
        Me.IData.Name = "IData"
        Me.IData.Size = New System.Drawing.Size(109, 25)
        Me.IData.TabIndex = 1
        Me.IData.Text = "Import Data"
        Me.IData.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        '
        'Props
        '
        Me.Props.AutoSize = True
        Me.Props.Location = New System.Drawing.Point(365, 43)
        Me.Props.Name = "Props"
        Me.Props.Size = New System.Drawing.Size(109, 25)
        Me.Props.TabIndex = 2
        Me.Props.Text = "Data Set Properties"
        Me.Props.UseVisualStyleBackColor = True
        '
        'VMap
        '
        Me.VMap.AutoSize = True
        Me.VMap.Location = New System.Drawing.Point(365, 74)
        Me.VMap.Name = "VMap"
        Me.VMap.Size = New System.Drawing.Size(109, 23)
        Me.VMap.TabIndex = 3
        Me.VMap.Text = "Variable Map"
        Me.VMap.UseVisualStyleBackColor = True
        '
        'Plot
        '
        Me.Plot.Location = New System.Drawing.Point(365, 103)
        Me.Plot.Name = "Plot"
        Me.Plot.Size = New System.Drawing.Size(109, 23)
        Me.Plot.TabIndex = 4
        Me.Plot.Text = "Plotting Tool"
        Me.Plot.UseVisualStyleBackColor = True
        '
        'Ops
        '
        Me.Ops.Location = New System.Drawing.Point(365, 161)
        Me.Ops.Name = "Ops"
        Me.Ops.Size = New System.Drawing.Size(109, 23)
        Me.Ops.TabIndex = 5
        Me.Ops.Text = "Options"
        Me.Ops.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Multigraph_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(347, 234)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Filter
        '
        Me.Filter.Location = New System.Drawing.Point(365, 132)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(109, 23)
        Me.Filter.TabIndex = 8
        Me.Filter.Text = "Filter Tool"
        Me.Filter.UseVisualStyleBackColor = True
        '
        'Test
        '
        Me.Test.Location = New System.Drawing.Point(384, 190)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(75, 23)
        Me.Test.TabIndex = 9
        Me.Test.Text = "Test"
        Me.Test.UseVisualStyleBackColor = True
        '
        'Multigraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 258)
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.Filter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ops)
        Me.Controls.Add(Me.Plot)
        Me.Controls.Add(Me.VMap)
        Me.Controls.Add(Me.Props)
        Me.Controls.Add(Me.IData)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Multigraph"
        Me.Text = "Multigraph"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IData As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Props As System.Windows.Forms.Button
    Friend WithEvents VMap As System.Windows.Forms.Button
    Friend WithEvents Plot As System.Windows.Forms.Button
    Friend WithEvents Ops As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Filter As System.Windows.Forms.Button
    Friend WithEvents Test As System.Windows.Forms.Button

End Class
