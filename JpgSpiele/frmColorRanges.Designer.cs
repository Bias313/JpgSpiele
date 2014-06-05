namespace JpgSpiele
{
    partial class frmColorRanges
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
            this.m_grpBxRed = new System.Windows.Forms.GroupBox();
            this.m_numUpDwnRMax = new System.Windows.Forms.NumericUpDown();
            this.m_numUpDwnRMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.m_vscrbRMax = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.m_vscrbRMin = new System.Windows.Forms.VScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_numUpDwnGMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.m_numUpDwnGMin = new System.Windows.Forms.NumericUpDown();
            this.m_vscrbGMax = new System.Windows.Forms.VScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.m_vscrbGMin = new System.Windows.Forms.VScrollBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_numUpDwnBMax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.m_numUpDwnBMin = new System.Windows.Forms.NumericUpDown();
            this.m_vscrbBMax = new System.Windows.Forms.VScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.m_vscrbBMin = new System.Windows.Forms.VScrollBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.m_grpBxRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnRMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnRMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnGMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnGMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnBMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnBMin)).BeginInit();
            this.SuspendLayout();
            // 
            // m_btnOkay
            // 
            this.m_btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOkay.Location = new System.Drawing.Point(165, 270);
            this.m_btnOkay.Name = "m_btnOkay";
            this.m_btnOkay.Size = new System.Drawing.Size(75, 23);
            this.m_btnOkay.TabIndex = 5;
            this.m_btnOkay.Text = "OK";
            this.m_btnOkay.UseVisualStyleBackColor = true;
            // 
            // m_grpBxRed
            // 
            this.m_grpBxRed.Controls.Add(this.m_numUpDwnRMax);
            this.m_grpBxRed.Controls.Add(this.m_numUpDwnRMin);
            this.m_grpBxRed.Controls.Add(this.label2);
            this.m_grpBxRed.Controls.Add(this.m_vscrbRMax);
            this.m_grpBxRed.Controls.Add(this.label1);
            this.m_grpBxRed.Controls.Add(this.m_vscrbRMin);
            this.m_grpBxRed.Location = new System.Drawing.Point(12, 12);
            this.m_grpBxRed.Name = "m_grpBxRed";
            this.m_grpBxRed.Size = new System.Drawing.Size(72, 248);
            this.m_grpBxRed.TabIndex = 6;
            this.m_grpBxRed.TabStop = false;
            this.m_grpBxRed.Text = "Rot";
            // 
            // m_numUpDwnRMax
            // 
            this.m_numUpDwnRMax.Location = new System.Drawing.Point(10, 220);
            this.m_numUpDwnRMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numUpDwnRMax.Name = "m_numUpDwnRMax";
            this.m_numUpDwnRMax.Size = new System.Drawing.Size(49, 20);
            this.m_numUpDwnRMax.TabIndex = 12;
            this.m_numUpDwnRMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numUpDwnRMax.ValueChanged += new System.EventHandler(this.m_numUpDwnRMin_ValueChanged);
            // 
            // m_numUpDwnRMin
            // 
            this.m_numUpDwnRMin.Location = new System.Drawing.Point(9, 194);
            this.m_numUpDwnRMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numUpDwnRMin.Name = "m_numUpDwnRMin";
            this.m_numUpDwnRMin.Size = new System.Drawing.Size(50, 20);
            this.m_numUpDwnRMin.TabIndex = 11;
            this.m_numUpDwnRMin.ValueChanged += new System.EventHandler(this.m_numUpDwnRMin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Max.";
            // 
            // m_vscrbRMax
            // 
            this.m_vscrbRMax.Location = new System.Drawing.Point(42, 41);
            this.m_vscrbRMax.Maximum = 264;
            this.m_vscrbRMax.Name = "m_vscrbRMax";
            this.m_vscrbRMax.Size = new System.Drawing.Size(17, 150);
            this.m_vscrbRMax.TabIndex = 9;
            this.m_vscrbRMax.ValueChanged += new System.EventHandler(this.m_vscrb_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Min.";
            // 
            // m_vscrbRMin
            // 
            this.m_vscrbRMin.Location = new System.Drawing.Point(9, 41);
            this.m_vscrbRMin.Maximum = 264;
            this.m_vscrbRMin.Name = "m_vscrbRMin";
            this.m_vscrbRMin.Size = new System.Drawing.Size(17, 150);
            this.m_vscrbRMin.TabIndex = 7;
            this.m_vscrbRMin.Value = 255;
            this.m_vscrbRMin.ValueChanged += new System.EventHandler(this.m_vscrb_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_numUpDwnGMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_numUpDwnGMin);
            this.groupBox1.Controls.Add(this.m_vscrbGMax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_vscrbGMin);
            this.groupBox1.Location = new System.Drawing.Point(90, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 248);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grün";
            // 
            // m_numUpDwnGMax
            // 
            this.m_numUpDwnGMax.Location = new System.Drawing.Point(10, 220);
            this.m_numUpDwnGMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numUpDwnGMax.Name = "m_numUpDwnGMax";
            this.m_numUpDwnGMax.Size = new System.Drawing.Size(49, 20);
            this.m_numUpDwnGMax.TabIndex = 14;
            this.m_numUpDwnGMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numUpDwnGMax.ValueChanged += new System.EventHandler(this.m_numUpDwnRMin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Max.";
            // 
            // m_numUpDwnGMin
            // 
            this.m_numUpDwnGMin.Location = new System.Drawing.Point(9, 194);
            this.m_numUpDwnGMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numUpDwnGMin.Name = "m_numUpDwnGMin";
            this.m_numUpDwnGMin.Size = new System.Drawing.Size(50, 20);
            this.m_numUpDwnGMin.TabIndex = 13;
            this.m_numUpDwnGMin.ValueChanged += new System.EventHandler(this.m_numUpDwnRMin_ValueChanged);
            // 
            // m_vscrbGMax
            // 
            this.m_vscrbGMax.Location = new System.Drawing.Point(42, 41);
            this.m_vscrbGMax.Maximum = 264;
            this.m_vscrbGMax.Name = "m_vscrbGMax";
            this.m_vscrbGMax.Size = new System.Drawing.Size(17, 150);
            this.m_vscrbGMax.TabIndex = 9;
            this.m_vscrbGMax.ValueChanged += new System.EventHandler(this.m_vscrb_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Min.";
            // 
            // m_vscrbGMin
            // 
            this.m_vscrbGMin.Location = new System.Drawing.Point(9, 41);
            this.m_vscrbGMin.Maximum = 264;
            this.m_vscrbGMin.Name = "m_vscrbGMin";
            this.m_vscrbGMin.Size = new System.Drawing.Size(17, 150);
            this.m_vscrbGMin.TabIndex = 7;
            this.m_vscrbGMin.Value = 255;
            this.m_vscrbGMin.ValueChanged += new System.EventHandler(this.m_vscrb_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.m_numUpDwnBMax);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.m_numUpDwnBMin);
            this.groupBox2.Controls.Add(this.m_vscrbBMax);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.m_vscrbBMin);
            this.groupBox2.Location = new System.Drawing.Point(168, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(72, 248);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blau";
            // 
            // m_numUpDwnBMax
            // 
            this.m_numUpDwnBMax.Location = new System.Drawing.Point(10, 220);
            this.m_numUpDwnBMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numUpDwnBMax.Name = "m_numUpDwnBMax";
            this.m_numUpDwnBMax.Size = new System.Drawing.Size(49, 20);
            this.m_numUpDwnBMax.TabIndex = 16;
            this.m_numUpDwnBMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numUpDwnBMax.ValueChanged += new System.EventHandler(this.m_numUpDwnRMin_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max.";
            // 
            // m_numUpDwnBMin
            // 
            this.m_numUpDwnBMin.Location = new System.Drawing.Point(9, 194);
            this.m_numUpDwnBMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numUpDwnBMin.Name = "m_numUpDwnBMin";
            this.m_numUpDwnBMin.Size = new System.Drawing.Size(50, 20);
            this.m_numUpDwnBMin.TabIndex = 15;
            this.m_numUpDwnBMin.ValueChanged += new System.EventHandler(this.m_numUpDwnRMin_ValueChanged);
            // 
            // m_vscrbBMax
            // 
            this.m_vscrbBMax.Location = new System.Drawing.Point(42, 41);
            this.m_vscrbBMax.Maximum = 264;
            this.m_vscrbBMax.Name = "m_vscrbBMax";
            this.m_vscrbBMax.Size = new System.Drawing.Size(17, 150);
            this.m_vscrbBMax.TabIndex = 9;
            this.m_vscrbBMax.ValueChanged += new System.EventHandler(this.m_vscrb_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Min.";
            // 
            // m_vscrbBMin
            // 
            this.m_vscrbBMin.Location = new System.Drawing.Point(9, 41);
            this.m_vscrbBMin.Maximum = 264;
            this.m_vscrbBMin.Name = "m_vscrbBMin";
            this.m_vscrbBMin.Size = new System.Drawing.Size(17, 150);
            this.m_vscrbBMin.TabIndex = 7;
            this.m_vscrbBMin.Value = 255;
            this.m_vscrbBMin.ValueChanged += new System.EventHandler(this.m_vscrb_ValueChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // frmColorRanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_grpBxRed);
            this.Controls.Add(this.m_btnOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmColorRanges";
            this.Text = "Farbauswahl";
            this.m_grpBxRed.ResumeLayout(false);
            this.m_grpBxRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnRMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnRMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnGMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnGMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnBMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numUpDwnBMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_btnOkay;
        private System.Windows.Forms.GroupBox m_grpBxRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar m_vscrbRMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar m_vscrbRMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.VScrollBar m_vscrbGMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.VScrollBar m_vscrbGMin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.VScrollBar m_vscrbBMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.VScrollBar m_vscrbBMin;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown m_numUpDwnRMax;
        private System.Windows.Forms.NumericUpDown m_numUpDwnRMin;
        private System.Windows.Forms.NumericUpDown m_numUpDwnGMax;
        private System.Windows.Forms.NumericUpDown m_numUpDwnGMin;
        private System.Windows.Forms.NumericUpDown m_numUpDwnBMax;
        private System.Windows.Forms.NumericUpDown m_numUpDwnBMin;
    }
}