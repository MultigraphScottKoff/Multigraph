<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlotWindow
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
        Me.PlotLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'PlotLayoutPanel
        '
        Me.PlotLayoutPanel.AutoScroll = True
        Me.PlotLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PlotLayoutPanel.ColumnCount = 1
        Me.PlotLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PlotLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.PlotLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.PlotLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.PlotLayoutPanel.Name = "PlotLayoutPanel"
        Me.PlotLayoutPanel.RowCount = 1
        Me.PlotLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PlotLayoutPanel.Size = New System.Drawing.Size(300, 300)
        Me.PlotLayoutPanel.TabIndex = 0
        '
        'PlotWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(584, 412)
        Me.Controls.Add(Me.PlotLayoutPanel)
        Me.Name = "PlotWindow"
        Me.Text = "Plot"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlotLayoutPanel As System.Windows.Forms.TableLayoutPanel
End Class
