namespace JpgSpiele
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiederherstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tsmiGray = new System.Windows.Forms.ToolStripMenuItem();
            this.m_BlackWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_adjustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_maincolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_softToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_komplementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individuellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiefpassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.m_analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_picBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationenToolStripMenuItem,
            this.m_analysisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "Datei";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openToolStripMenuItem.Text = "Öffnen";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveToolStripMenuItem.Text = "Speichern";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveAsToolStripMenuItem.Text = "Speichern unter";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // operationenToolStripMenuItem
            // 
            this.operationenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wiederherstellenToolStripMenuItem,
            this.rotToolStripMenuItem});
            this.operationenToolStripMenuItem.Enabled = false;
            this.operationenToolStripMenuItem.Name = "operationenToolStripMenuItem";
            this.operationenToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operationenToolStripMenuItem.Text = "Operationen";
            // 
            // wiederherstellenToolStripMenuItem
            // 
            this.wiederherstellenToolStripMenuItem.Name = "wiederherstellenToolStripMenuItem";
            this.wiederherstellenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.wiederherstellenToolStripMenuItem.Text = "Wiederherstellen";
            this.wiederherstellenToolStripMenuItem.Click += new System.EventHandler(this.wiederherstellenToolStripMenuItem_Click);
            // 
            // rotToolStripMenuItem
            // 
            this.rotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tsmiGray,
            this.m_BlackWhiteToolStripMenuItem,
            this.m_maincolorToolStripMenuItem,
            this.m_komplementToolStripMenuItem,
            this.farbeToolStripMenuItem,
            this.tiefpassToolStripMenuItem1});
            this.rotToolStripMenuItem.Name = "rotToolStripMenuItem";
            this.rotToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rotToolStripMenuItem.Text = "Filter";
            // 
            // m_tsmiGray
            // 
            this.m_tsmiGray.Name = "m_tsmiGray";
            this.m_tsmiGray.Size = new System.Drawing.Size(156, 22);
            this.m_tsmiGray.Text = "Grau";
            this.m_tsmiGray.Click += new System.EventHandler(this.m_tsmiGray_Click);
            // 
            // m_BlackWhiteToolStripMenuItem
            // 
            this.m_BlackWhiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_adjustToolStripMenuItem});
            this.m_BlackWhiteToolStripMenuItem.Name = "m_BlackWhiteToolStripMenuItem";
            this.m_BlackWhiteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.m_BlackWhiteToolStripMenuItem.Text = "Scharzweiß";
            this.m_BlackWhiteToolStripMenuItem.Click += new System.EventHandler(this.m_BlackWhiteToolStripMenuItem_Click);
            // 
            // m_adjustToolStripMenuItem
            // 
            this.m_adjustToolStripMenuItem.Name = "m_adjustToolStripMenuItem";
            this.m_adjustToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.m_adjustToolStripMenuItem.Text = "Anpassen";
            this.m_adjustToolStripMenuItem.Click += new System.EventHandler(this.m_adjustBlackWhiteToolStripMenuItem_Click);
            // 
            // m_maincolorToolStripMenuItem
            // 
            this.m_maincolorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_softToolStripMenuItem,
            this.m_hardToolStripMenuItem});
            this.m_maincolorToolStripMenuItem.Name = "m_maincolorToolStripMenuItem";
            this.m_maincolorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.m_maincolorToolStripMenuItem.Text = "Hauptfarbe";
            this.m_maincolorToolStripMenuItem.Click += new System.EventHandler(this.hauptfarbeToolStripMenuItem_Click);
            // 
            // m_softToolStripMenuItem
            // 
            this.m_softToolStripMenuItem.Name = "m_softToolStripMenuItem";
            this.m_softToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.m_softToolStripMenuItem.Text = "Weich";
            this.m_softToolStripMenuItem.Click += new System.EventHandler(this.m_softToolStripMenuItem_Click);
            // 
            // m_hardToolStripMenuItem
            // 
            this.m_hardToolStripMenuItem.Name = "m_hardToolStripMenuItem";
            this.m_hardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.m_hardToolStripMenuItem.Text = "Hart";
            this.m_hardToolStripMenuItem.Click += new System.EventHandler(this.hartToolStripMenuItem_Click);
            // 
            // m_komplementToolStripMenuItem
            // 
            this.m_komplementToolStripMenuItem.Name = "m_komplementToolStripMenuItem";
            this.m_komplementToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.m_komplementToolStripMenuItem.Text = "Komplement";
            this.m_komplementToolStripMenuItem.Click += new System.EventHandler(this.komplementToolStripMenuItem_Click);
            // 
            // farbeToolStripMenuItem
            // 
            this.farbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotToolStripMenuItem1,
            this.grünToolStripMenuItem,
            this.blauToolStripMenuItem,
            this.individuellToolStripMenuItem});
            this.farbeToolStripMenuItem.Name = "farbeToolStripMenuItem";
            this.farbeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.farbeToolStripMenuItem.Text = "Farbe";
            // 
            // rotToolStripMenuItem1
            // 
            this.rotToolStripMenuItem1.Name = "rotToolStripMenuItem1";
            this.rotToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rotToolStripMenuItem1.Text = "Rot";
            this.rotToolStripMenuItem1.Click += new System.EventHandler(this.m_tsmiRed_Click);
            // 
            // grünToolStripMenuItem
            // 
            this.grünToolStripMenuItem.Name = "grünToolStripMenuItem";
            this.grünToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grünToolStripMenuItem.Text = "Grün";
            this.grünToolStripMenuItem.Click += new System.EventHandler(this.m_tsmiGreen_Click);
            // 
            // blauToolStripMenuItem
            // 
            this.blauToolStripMenuItem.Name = "blauToolStripMenuItem";
            this.blauToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blauToolStripMenuItem.Text = "Blau";
            this.blauToolStripMenuItem.Click += new System.EventHandler(this.m_tsmiBlue_Click);
            // 
            // individuellToolStripMenuItem
            // 
            this.individuellToolStripMenuItem.Name = "individuellToolStripMenuItem";
            this.individuellToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.individuellToolStripMenuItem.Text = "Individuell";
            this.individuellToolStripMenuItem.Click += new System.EventHandler(this.individuellToolStripMenuItem_Click);
            // 
            // tiefpassToolStripMenuItem1
            // 
            this.tiefpassToolStripMenuItem1.Name = "tiefpassToolStripMenuItem1";
            this.tiefpassToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.tiefpassToolStripMenuItem1.Text = "Tief-/Hochpass";
            this.tiefpassToolStripMenuItem1.Click += new System.EventHandler(this.tiefpassToolStripMenuItem_Click);
            // 
            // m_analysisToolStripMenuItem
            // 
            this.m_analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogrammToolStripMenuItem});
            this.m_analysisToolStripMenuItem.Enabled = false;
            this.m_analysisToolStripMenuItem.Name = "m_analysisToolStripMenuItem";
            this.m_analysisToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.m_analysisToolStripMenuItem.Text = "Analyse";
            // 
            // histogrammToolStripMenuItem
            // 
            this.histogrammToolStripMenuItem.Name = "histogrammToolStripMenuItem";
            this.histogrammToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.histogrammToolStripMenuItem.Text = "Histogramm";
            this.histogrammToolStripMenuItem.Click += new System.EventHandler(this.histogrammToolStripMenuItem_Click);
            // 
            // m_picBox
            // 
            this.m_picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_picBox.Location = new System.Drawing.Point(12, 27);
            this.m_picBox.Name = "m_picBox";
            this.m_picBox.Size = new System.Drawing.Size(825, 686);
            this.m_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_picBox.TabIndex = 2;
            this.m_picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 725);
            this.Controls.Add(this.m_picBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "JPG-Filterspiele";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox m_picBox;
        private System.Windows.Forms.ToolStripMenuItem operationenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiederherstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_tsmiGray;
        private System.Windows.Forms.ToolStripMenuItem m_maincolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_softToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_BlackWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_adjustToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_komplementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individuellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiefpassToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

