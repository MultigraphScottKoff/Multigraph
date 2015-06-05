namespace SoftwareFX.Samples._Business_CLR_Objects
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSamples = new System.Windows.Forms.ComboBox();
            this.chart1 = new ChartFX.WinForms.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sample:";
            // 
            // comboBoxSamples
            // 
            this.comboBoxSamples.FormattingEnabled = true;
            this.comboBoxSamples.Location = new System.Drawing.Point(61, 7);
            this.comboBoxSamples.Name = "comboBoxSamples";
            this.comboBoxSamples.Size = new System.Drawing.Size(165, 21);
            this.comboBoxSamples.TabIndex = 4;
            this.comboBoxSamples.SelectedIndexChanged += new System.EventHandler(this.comboBoxSamples_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.AxisX.Title.Separation = 10;
            this.chart1.AxisY.Title.Separation = 10;
            this.chart1.AxisY2.Title.Separation = 10;
            this.chart1.Location = new System.Drawing.Point(7, 38);
            this.chart1.MainPane.Title.Separation = 5;
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(833, 410);
            this.chart1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 460);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSamples);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSamples;
        private ChartFX.WinForms.Chart chart1;
    }
}