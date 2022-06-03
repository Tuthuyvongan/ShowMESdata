using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMESData
{
    public partial class UC_MQC_BarChart : UserControl
    {
        public UC_MQC_BarChart()
        {
            InitializeComponent();
        }

        private void UC_MQC_Load(object sender, EventArgs e)
        {
            // Date time format
            dtpChart.CustomFormat = "yyyy-MM-dd";
            dtpChart.Format = DateTimePickerFormat.Custom;
            renderBarchart();
        }
        //List data
        List<double> dataOP = new List<double>();
        List<double> dataNG = new List<double>();
        List<double> dataRW = new List<double>();

        public void lineData()
        {
            string date = dtpChart.Text.ToString();
            double d;
            double temp;
            for (int i = 0; i < 7; i++)
            {
                //OP
                temp = GetSOFTdata.getTotalRemark("L0" + (i + 1), "OP", date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L0" + (i + 1), date) * 100, 2);
                dataOP.Add(d);
                //RW
                temp = GetSOFTdata.getTotalRemark("L0" + (i + 1), "RW", date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L0" + (i + 1), date) * 100, 2);
                dataRW.Add(d);
                //NG
                temp = GetSOFTdata.getTotalRemark("L0" + (i + 1), "NG", date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L0" + (i + 1), date) * 100, 2);
                dataNG.Add(d);
            }                
                
        }
        public void renderBarchart()
        {
            //Add data
            lineData();
            lineRWChart.Data = dataRW;
            lineOPChart.Data = dataOP;
            lineNGChart.Data = dataNG;
            //Target Canvas 
            lineOPChart.TargetCanvas = lineBCCanvas;
            lineRWChart.TargetCanvas = lineBCCanvas;
            lineNGChart.TargetCanvas = lineBCCanvas;

            lineBCCanvas.Labels = new string[] { "L01", "L02", "L03", "L04", "L05", "L06", "L07" };
            //List Colors
            List<Color> bgColorsOP = new List<Color>();
            List<Color> bgColorsRW = new List<Color>();
            List<Color> bgColorsNG = new List<Color>();
            bgColorsOP.Add(Color.DodgerBlue);
            bgColorsRW.Add(Color.Orange);
            bgColorsNG.Add(Color.Red);
            lineOPChart.BackgroundColor = bgColorsOP;
            lineRWChart.BackgroundColor = bgColorsRW;
            lineNGChart.BackgroundColor = bgColorsNG;
        }

        private void dtpChart_ValueChanged(object sender, EventArgs e)
        {
            dataOP.Clear();
            dataRW.Clear();
            dataNG.Clear();
            renderBarchart();
        }
    }
}
