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
    public partial class frmBlackWhiteRange : Form
    {

        public int BlackWhiteLmit { get { return 255 - m_vscrbSW.Value; } }
        public frmBlackWhiteRange()
        {
            InitializeComponent();
        }

        private void frmBlackWhiteRange_Load(object sender, EventArgs e)
        {

        }
    }
}
