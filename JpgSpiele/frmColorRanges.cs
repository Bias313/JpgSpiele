using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JpgSpiele
{
    public partial class frmColorRanges : Form
    {
        public int RMin { get { return 255-m_vscrbRMin.Value; } }
        public int RMax { get { return 255 - m_vscrbRMax.Value; } }
        public int GMin { get { return 255 - m_vscrbGMin.Value; } }
        public int GMax { get { return 255 - m_vscrbGMax.Value; } }
        public int BMin { get { return 255 - m_vscrbBMin.Value; } }
        public int BMax { get { return 255 - m_vscrbBMax.Value; } }

        private bool m_blnInitialized = false;

        public frmColorRanges()
        {
            InitializeComponent();
            m_vscrbRMin.Tag = m_numUpDwnRMin;
            m_vscrbRMax.Tag = m_numUpDwnRMax;
            m_numUpDwnRMin.Tag = m_vscrbRMin;
            m_numUpDwnRMax.Tag = m_vscrbRMax;
            m_numUpDwnRMin.Value = 255 - m_vscrbRMin.Value;
            m_numUpDwnRMax.Value = 255 - m_vscrbRMax.Value;

            m_vscrbGMin.Tag = m_numUpDwnGMin;
            m_vscrbGMax.Tag = m_numUpDwnGMax;
            m_numUpDwnGMin.Tag = m_vscrbGMin;
            m_numUpDwnGMax.Tag = m_vscrbGMax;
            m_numUpDwnGMin.Value = 255-m_vscrbGMin.Value;
            m_numUpDwnGMax.Value = 255 - m_vscrbGMax.Value;

            m_vscrbBMin.Tag = m_numUpDwnBMin;
            m_vscrbBMax.Tag = m_numUpDwnBMax;
            m_numUpDwnBMin.Tag = m_vscrbBMin;
            m_numUpDwnBMax.Tag = m_vscrbBMax;
            m_numUpDwnBMin.Value = 255 - m_vscrbBMin.Value;
            m_numUpDwnBMax.Value = 255 - m_vscrbBMax.Value;

            m_blnInitialized = true;
        }

        private void m_vscrb_ValueChanged(object sender, EventArgs e)
        {
            if (m_blnInitialized)
            {
                VScrollBar vsb = (VScrollBar)sender;
                NumericUpDown nud = (NumericUpDown)vsb.Tag;
                nud.Value = 255 - vsb.Value;
            }
        }

        private void m_numUpDwnRMin_ValueChanged(object sender, EventArgs e)
        {
            if (m_blnInitialized)
            {
                NumericUpDown nud = (NumericUpDown)sender;
                VScrollBar vsb = (VScrollBar)nud.Tag;
                vsb.Value = Convert.ToInt32(255 - nud.Value);
            }
        }

  

     

     

 

      
    }
}
