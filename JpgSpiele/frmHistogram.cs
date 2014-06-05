using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JpgSpiele
{
    public partial class frmHistogram : Form
    {
        private int[][] m_nArHistoData;


        public frmHistogram(int[][] nArHistoData)
        {
            InitializeComponent();
            nArHistoData = nArHistoData;
            CreateSeries(nArHistoData[0], Color.Red, "Rot");
            CreateSeries(nArHistoData[1], Color.Green, "Grün");
            CreateSeries(nArHistoData[2], Color.Blue, "Blau");
            CreateSeries(nArHistoData[3], Color.DarkGray, "Grau");
            m_chkBxRed.Tag = m_Chart.Series[0];
            m_chkBxGreen.Tag = m_Chart.Series[1];
            m_chkBxBlue.Tag = m_Chart.Series[2];
            m_chkBxGray.Tag = m_Chart.Series[3];
        }

        private void CreateSeries(int[] nArPoints, Color color, string strName)
        {
            Series series = new Series(strName);
            series.ChartType = SeriesChartType.StepLine;
            series.Color = color;
            for (int i = 0; i < nArPoints.Length; i++)
            {
                series.Points.AddXY(i, nArPoints[i]);
            }
            // add new graph
            
            m_Chart.Series.Add(series);
        }

        private void m_chkBx_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkBx = (CheckBox)sender;
            Series s = (Series)chkBx.Tag;
            s.Enabled = chkBx.Checked;
        }

        
    }
}
