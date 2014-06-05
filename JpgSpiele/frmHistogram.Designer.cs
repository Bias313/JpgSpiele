namespace JpgSpiele
{
    partial class frmHistogram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.m_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_chkBxGray = new System.Windows.Forms.CheckBox();
            this.m_chkBxBlue = new System.Windows.Forms.CheckBox();
            this.m_chkBxGreen = new System.Windows.Forms.CheckBox();
            this.m_chkBxRed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // m_Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.m_Chart.ChartAreas.Add(chartArea3);
            this.m_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.m_Chart.Legends.Add(legend3);
            this.m_Chart.Location = new System.Drawing.Point(0, 0);
            this.m_Chart.Name = "m_Chart";
            this.m_Chart.Size = new System.Drawing.Size(519, 261);
            this.m_Chart.TabIndex = 0;
            this.m_Chart.Text = "chart1";
            // 
            // m_chkBxGray
            // 
            this.m_chkBxGray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_chkBxGray.AutoSize = true;
            this.m_chkBxGray.Checked = true;
            this.m_chkBxGray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_chkBxGray.Location = new System.Drawing.Point(457, 232);
            this.m_chkBxGray.Name = "m_chkBxGray";
            this.m_chkBxGray.Size = new System.Drawing.Size(49, 17);
            this.m_chkBxGray.TabIndex = 1;
            this.m_chkBxGray.Text = "Grau";
            this.m_chkBxGray.UseVisualStyleBackColor = true;
            this.m_chkBxGray.CheckedChanged += new System.EventHandler(this.m_chkBx_CheckedChanged);
            // 
            // m_chkBxBlue
            // 
            this.m_chkBxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_chkBxBlue.AutoSize = true;
            this.m_chkBxBlue.Checked = true;
            this.m_chkBxBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_chkBxBlue.Location = new System.Drawing.Point(458, 209);
            this.m_chkBxBlue.Name = "m_chkBxBlue";
            this.m_chkBxBlue.Size = new System.Drawing.Size(47, 17);
            this.m_chkBxBlue.TabIndex = 2;
            this.m_chkBxBlue.Text = "Blau";
            this.m_chkBxBlue.UseVisualStyleBackColor = true;
            this.m_chkBxBlue.CheckedChanged += new System.EventHandler(this.m_chkBx_CheckedChanged);
            // 
            // m_chkBxGreen
            // 
            this.m_chkBxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_chkBxGreen.AutoSize = true;
            this.m_chkBxGreen.Checked = true;
            this.m_chkBxGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_chkBxGreen.Location = new System.Drawing.Point(458, 186);
            this.m_chkBxGreen.Name = "m_chkBxGreen";
            this.m_chkBxGreen.Size = new System.Drawing.Size(49, 17);
            this.m_chkBxGreen.TabIndex = 3;
            this.m_chkBxGreen.Text = "Grün";
            this.m_chkBxGreen.UseVisualStyleBackColor = true;
            this.m_chkBxGreen.CheckedChanged += new System.EventHandler(this.m_chkBx_CheckedChanged);
            // 
            // m_chkBxRed
            // 
            this.m_chkBxRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_chkBxRed.AutoSize = true;
            this.m_chkBxRed.Checked = true;
            this.m_chkBxRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_chkBxRed.Location = new System.Drawing.Point(458, 163);
            this.m_chkBxRed.Name = "m_chkBxRed";
            this.m_chkBxRed.Size = new System.Drawing.Size(43, 17);
            this.m_chkBxRed.TabIndex = 4;
            this.m_chkBxRed.Text = "Rot";
            this.m_chkBxRed.UseVisualStyleBackColor = true;
            this.m_chkBxRed.CheckedChanged += new System.EventHandler(this.m_chkBx_CheckedChanged);
            // 
            // frmHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.m_chkBxRed);
            this.Controls.Add(this.m_chkBxGreen);
            this.Controls.Add(this.m_chkBxBlue);
            this.Controls.Add(this.m_chkBxGray);
            this.Controls.Add(this.m_Chart);
            this.Name = "frmHistogram";
            this.Text = "Histogramm";
            ((System.ComponentModel.ISupportInitialize)(this.m_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart m_Chart;
        private System.Windows.Forms.CheckBox m_chkBxGray;
        private System.Windows.Forms.CheckBox m_chkBxBlue;
        private System.Windows.Forms.CheckBox m_chkBxGreen;
        private System.Windows.Forms.CheckBox m_chkBxRed;
    }
}