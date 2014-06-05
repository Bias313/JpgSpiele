namespace JpgSpiele
{
    partial class frmPassFilter
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
            this.m_btnOkay = new System.Windows.Forms.Button();
            this.m_numUpDwnOut = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.m_numUpDwnMiddle = new System.Windows.Forms.NumericUpDown();
            this.m_numUpDwnIn = new System.Windows.Forms.NumericUpDown();
            this.m_lblIn1 = new System.Windows.Forms.Label();
            this.m_lblIn3 = new System.Windows.Forms.Label();
            this.m_lblOut1 = new System.Windows.Forms.Label();
            this.m_lblOut3 = new System.Windows.Forms.Label();
            this.m_lblIn2 = new System.Windows.Forms.Label();
            this.m_lblOut2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnIn)).BeginInit();
            this.SuspendLayout();
            // 
            // m_btnOkay
            // 
            this.m_btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOkay.Location = new System.Drawing.Point(75, 121);
            this.m_btnOkay.Name = "m_btnOkay";
            this.m_btnOkay.Size = new System.Drawing.Size(75, 23);
            this.m_btnOkay.TabIndex = 10;
            this.m_btnOkay.Text = "OK";
            this.m_btnOkay.UseVisualStyleBackColor = true;
            // 
            // m_numUpDwnOut
            // 
            this.m_numUpDwnOut.ForeColor = System.Drawing.Color.ForestGreen;
            this.m_numUpDwnOut.Location = new System.Drawing.Point(15, 37);
            this.m_numUpDwnOut.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.m_numUpDwnOut.Name = "m_numUpDwnOut";
            this.m_numUpDwnOut.Size = new System.Drawing.Size(44, 20);
            this.m_numUpDwnOut.TabIndex = 12;
            this.m_numUpDwnOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_numUpDwnOut.ValueChanged += new System.EventHandler(this.m_numUpDwn_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gewichtung";
            // 
            // m_numUpDwnMiddle
            // 
            this.m_numUpDwnMiddle.ForeColor = System.Drawing.Color.Red;
            this.m_numUpDwnMiddle.Location = new System.Drawing.Point(65, 63);
            this.m_numUpDwnMiddle.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.m_numUpDwnMiddle.Name = "m_numUpDwnMiddle";
            this.m_numUpDwnMiddle.Size = new System.Drawing.Size(44, 20);
            this.m_numUpDwnMiddle.TabIndex = 13;
            this.m_numUpDwnMiddle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_numUpDwnMiddle.ValueChanged += new System.EventHandler(this.m_numUpDwn_ValueChanged);
            // 
            // m_numUpDwnIn
            // 
            this.m_numUpDwnIn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.m_numUpDwnIn.Location = new System.Drawing.Point(15, 63);
            this.m_numUpDwnIn.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.m_numUpDwnIn.Name = "m_numUpDwnIn";
            this.m_numUpDwnIn.Size = new System.Drawing.Size(44, 20);
            this.m_numUpDwnIn.TabIndex = 14;
            this.m_numUpDwnIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_numUpDwnIn.ValueChanged += new System.EventHandler(this.m_numUpDwn_ValueChanged);
            // 
            // m_lblIn1
            // 
            this.m_lblIn1.AutoSize = true;
            this.m_lblIn1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.m_lblIn1.Location = new System.Drawing.Point(65, 39);
            this.m_lblIn1.Name = "m_lblIn1";
            this.m_lblIn1.Size = new System.Drawing.Size(13, 13);
            this.m_lblIn1.TabIndex = 15;
            this.m_lblIn1.Text = "1";
            // 
            // m_lblIn3
            // 
            this.m_lblIn3.AutoSize = true;
            this.m_lblIn3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.m_lblIn3.Location = new System.Drawing.Point(115, 65);
            this.m_lblIn3.Name = "m_lblIn3";
            this.m_lblIn3.Size = new System.Drawing.Size(13, 13);
            this.m_lblIn3.TabIndex = 16;
            this.m_lblIn3.Text = "1";
            // 
            // m_lblOut1
            // 
            this.m_lblOut1.AutoSize = true;
            this.m_lblOut1.ForeColor = System.Drawing.Color.ForestGreen;
            this.m_lblOut1.Location = new System.Drawing.Point(115, 39);
            this.m_lblOut1.Name = "m_lblOut1";
            this.m_lblOut1.Size = new System.Drawing.Size(13, 13);
            this.m_lblOut1.TabIndex = 17;
            this.m_lblOut1.Text = "1";
            // 
            // m_lblOut3
            // 
            this.m_lblOut3.AutoSize = true;
            this.m_lblOut3.ForeColor = System.Drawing.Color.ForestGreen;
            this.m_lblOut3.Location = new System.Drawing.Point(12, 91);
            this.m_lblOut3.Name = "m_lblOut3";
            this.m_lblOut3.Size = new System.Drawing.Size(13, 13);
            this.m_lblOut3.TabIndex = 18;
            this.m_lblOut3.Text = "1";
            // 
            // m_lblIn2
            // 
            this.m_lblIn2.AutoSize = true;
            this.m_lblIn2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.m_lblIn2.Location = new System.Drawing.Point(65, 91);
            this.m_lblIn2.Name = "m_lblIn2";
            this.m_lblIn2.Size = new System.Drawing.Size(13, 13);
            this.m_lblIn2.TabIndex = 19;
            this.m_lblIn2.Text = "1";
            // 
            // m_lblOut2
            // 
            this.m_lblOut2.AutoSize = true;
            this.m_lblOut2.ForeColor = System.Drawing.Color.ForestGreen;
            this.m_lblOut2.Location = new System.Drawing.Point(115, 91);
            this.m_lblOut2.Name = "m_lblOut2";
            this.m_lblOut2.Size = new System.Drawing.Size(13, 13);
            this.m_lblOut2.TabIndex = 20;
            this.m_lblOut2.Text = "1";
            // 
            // frmPassFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 156);
            this.Controls.Add(this.m_lblOut2);
            this.Controls.Add(this.m_lblIn2);
            this.Controls.Add(this.m_lblOut3);
            this.Controls.Add(this.m_lblOut1);
            this.Controls.Add(this.m_lblIn3);
            this.Controls.Add(this.m_lblIn1);
            this.Controls.Add(this.m_numUpDwnIn);
            this.Controls.Add(this.m_numUpDwnMiddle);
            this.Controls.Add(this.m_numUpDwnOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_btnOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassFilter";
            this.Text = "Passfilter";
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnOkay;
        private System.Windows.Forms.NumericUpDown m_numUpDwnOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown m_numUpDwnMiddle;
        private System.Windows.Forms.NumericUpDown m_numUpDwnIn;
        private System.Windows.Forms.Label m_lblIn1;
        private System.Windows.Forms.Label m_lblIn3;
        private System.Windows.Forms.Label m_lblOut1;
        private System.Windows.Forms.Label m_lblOut3;
        private System.Windows.Forms.Label m_lblIn2;
        private System.Windows.Forms.Label m_lblOut2;
    }
}