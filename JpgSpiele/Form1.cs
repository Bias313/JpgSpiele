using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JpgSpiele
{
    public partial class Form1 : Form
    {
        private string m_strBmpName = String.Empty;
        private Bitmap m_bmpOriginal = null;
        private Bitmap m_bmpGray = null;
        private string m_strTitle = String.Empty;
        private frmColorRanges m_frmColRanges = new frmColorRanges();
        private frmBlackWhiteRange m_frmBlackWhiteRange = new frmBlackWhiteRange();

        public Form1()
        {
            InitializeComponent();
            m_strTitle = this.Text;
        }

        #region FileHandling
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDlg = new OpenFileDialog();
            if (ofDlg.ShowDialog() == DialogResult.OK)
            {
                m_strBmpName = ofDlg.FileName;
                Image img = Image.FromStream(new MemoryStream(File.ReadAllBytes(m_strBmpName)));
                m_bmpOriginal = (Bitmap)img;// new Bitmap(m_strBmpName);
                m_picBox.Image = m_bmpOriginal;
                m_bmpGray = null;
                operationenToolStripMenuItem.Enabled = true;
                m_analysisToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                this.Text = Path.GetFileName(m_strBmpName) + " - " + m_strTitle;
            }
            else
            { }
        }


        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_bmpOriginal = (Bitmap)m_picBox.Image;
            SaveAs(m_bmpOriginal,m_strBmpName);
           
        }

        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            SaveFileDialog sfdlg = new SaveFileDialog();

            if (sfdlg.ShowDialog() == DialogResult.OK)
            {
                m_bmpOriginal = (Bitmap)m_picBox.Image;
                SaveAs(m_bmpOriginal, sfdlg.FileName);
            }
            else 
            {
            }

            
        }

        private void SaveAs(Bitmap bmp, string strFileName)
        {
            try
            {
                bmp.Save(strFileName);
                MessageBox.Show("Speichern erfolgreich", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Speichern fehlgeschlagen.", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void individuellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_picBox.Image != null)
            {
                if (m_frmColRanges == null)
                    m_frmColRanges = new frmColorRanges();
                m_frmColRanges.ShowDialog();
               
                m_picBox.Image = BmpChanger.BmpToColor((Bitmap)m_picBox.Image, m_frmColRanges.RMin, m_frmColRanges.RMax, m_frmColRanges.GMin, m_frmColRanges.GMax, m_frmColRanges.BMin, m_frmColRanges.BMax);
            }
        }

        private void m_tsmiRed_Click(object sender, EventArgs e)
        {
            if (m_picBox.Image != null)
            {
                m_picBox.Image = BmpChanger.BmpToColor((Bitmap)m_picBox.Image, 0, 255, 0, 0, 0, 0);
            }
        }

        private void m_tsmiGreen_Click(object sender, EventArgs e)
        {
            if (m_picBox.Image != null)
            {
                m_picBox.Image = BmpChanger.BmpToColor((Bitmap)m_picBox.Image, 0, 0, 0, 255, 0, 0);
            }
        }

        private void m_tsmiBlue_Click(object sender, EventArgs e)
        {
            if (m_picBox.Image != null)
            {
                m_picBox.Image = BmpChanger.BmpToColor((Bitmap)m_picBox.Image, 0, 0, 0, 0, 0, 255);
            }
        }

        private void m_tsmiGray_Click(object sender, EventArgs e)
        {
            if (m_picBox.Image != null)
            {
               
                m_bmpGray = BmpChanger.BmpToGrey((Bitmap)m_picBox.Image);        

                m_picBox.Image = m_bmpGray;
            }
        }

        private void wiederherstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_picBox.Image = m_bmpOriginal;
        }

        #region MainColor-Filter
        private void hauptfarbeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (m_picBox.Image != null)
            {
                m_picBox.Image = BmpChanger.BmpToMainColor((Bitmap)m_picBox.Image);
            }
        }

        private void m_softToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_picBox.Image != null)
            {
                m_picBox.Image = BmpChanger.BmpToMainColor((Bitmap)m_picBox.Image);
            }
        }

        private void hartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_picBox.Image != null)
            {
                m_picBox.Image = BmpChanger.BmpToMainColorExtrem((Bitmap)m_picBox.Image);
            }
        }

        
        #endregion

        #region Black&White
        private void m_BlackWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackAndWhite((Bitmap)m_picBox.Image, 255/2);
            
        }

        private void m_adjustBlackWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            m_frmColRanges = new frmColorRanges();
            m_frmBlackWhiteRange.ShowDialog();
            BlackAndWhite((Bitmap)m_picBox.Image, m_frmBlackWhiteRange.BlackWhiteLmit);
            
        }

        private void BlackAndWhite(Bitmap bmp, int nBlackAndWHiteLimit)
        {
            if (m_picBox.Image != null)
            {
                m_picBox.Image = BmpChanger.BmpToBlackWhite(bmp, nBlackAndWHiteLimit);
            }
            else { /**/}
        }

        #endregion

        private void komplementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_picBox.Image != null)
            {
                m_picBox.Image = BmpChanger.BmpToComplement((Bitmap)m_picBox.Image);
            }
        }



        private void tiefpassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_picBox.Image != null)
            {

                frmPassFilter frm = new frmPassFilter();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    m_picBox.Image = BmpChanger.DoPassFilter((Bitmap)m_picBox.Image, frm.ValueOut, frm.ValueIn, frm.ValueMiddle);

                }
                else { /**/}
            }
        }



        #region Analisis
        private void histogrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[][] nArHistoData = BmpChanger.GetHistoData((Bitmap)m_picBox.Image);
            frmHistogram frmHistogramm = new frmHistogram(nArHistoData);
            frmHistogramm.Show();
        } 
        #endregion

       

       
        

     

    }
}
