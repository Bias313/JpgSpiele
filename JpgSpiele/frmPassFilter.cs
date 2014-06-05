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
    public partial class frmPassFilter : Form
    {

        public int ValueOut { get { return Convert.ToInt32(m_numUpDwnOut.Value); } }
        public int ValueIn { get { return Convert.ToInt32(m_numUpDwnIn.Value); } }
        public int ValueMiddle { get { return Convert.ToInt32(m_numUpDwnMiddle.Value); } }

        public frmPassFilter()
        {
            InitializeComponent();
            m_numUpDwnIn.Tag = new Control[] { m_lblIn1, m_lblIn2, m_lblIn3 };
            m_numUpDwnOut.Tag = new Control[] { m_lblOut1, m_lblOut2, m_lblOut3 };
            m_numUpDwnMiddle.Tag = new Control[] { };
        }

     
        private void m_numUpDwn_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            Control[] arCtrl = (Control[])nud.Tag;
            for (int i = 0; i < arCtrl.Length; i++)
            {
                arCtrl[i].Text = nud.Value.ToString();
            }
        }


      
    }
}
