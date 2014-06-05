namespace JpgSpiele
{
    partial class frmBlackWhiteRange
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
            this.m_vscrbSW = new System.Windows.Forms.VScrollBar();
            this.m_btnOkay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_vscrbSW
            // 
            this.m_vscrbSW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_vscrbSW.Location = new System.Drawing.Point(36, 33);
            this.m_vscrbSW.Maximum = 255;
            this.m_vscrbSW.Name = "m_vscrbSW";
            this.m_vscrbSW.Size = new System.Drawing.Size(17, 158);
            this.m_vscrbSW.TabIndex = 7;
            this.m_vscrbSW.Value = 127;
            // 
            // m_btnOkay
            // 
            this.m_btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOkay.Location = new System.Drawing.Point(9, 194);
            this.m_btnOkay.Name = "m_btnOkay";
            this.m_btnOkay.Size = new System.Drawing.Size(75, 23);
            this.m_btnOkay.TabIndex = 7;
            this.m_btnOkay.Text = "OK";
            this.m_btnOkay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Schwellwert";
            // 
            // frmBlackWhiteRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(92, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_vscrbSW);
            this.Controls.Add(this.m_btnOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBlackWhiteRange";
            this.Text = "frmBlackWhiteRange";
            this.Load += new System.EventHandler(this.frmBlackWhiteRange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar m_vscrbSW;
        private System.Windows.Forms.Button m_btnOkay;
        private System.Windows.Forms.Label label1;
    }
}