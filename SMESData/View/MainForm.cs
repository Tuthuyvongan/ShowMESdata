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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = GetSOFTdata.getNGData().Rows[0].ItemArray[0].ToString();
            renderBarchart();          
            // Date time format
            dtpChart.CustomFormat = "yyyy-MM-dd";
            dtpChart.Format = DateTimePickerFormat.Custom;                      
        }
        
        void renderBarchart()
        {
            double d;
            double temp;
            //List data OP
            List<double> dataOP = new List<double>();
            for (int i = 0; i < 7; i++)
            {             
                if (GetSOFTdata.getOPData().Rows[0].ItemArray[i].ToString() == "")
                {
                    dataOP.Add(0);
                }    
                else
                {
                    temp = double.Parse(GetSOFTdata.getOPData().Rows[0].ItemArray[i].ToString());
                    d = temp % totalOP() * 100;
                    dataOP.Add(d);
                }    
            }

            //List data RW
            List<double> dataRW = new List<double>();
            for (int i = 0; i < 7; i++)
            {
                if (GetSOFTdata.getRWData().Rows[0].ItemArray[i].ToString() == "")
                {
                    dataRW.Add(0);
                }
                else
                {
                    temp = double.Parse(GetSOFTdata.getRWData().Rows[0].ItemArray[i].ToString());
                    d = temp % totalRW() * 100;
                    dataRW.Add(d);
                }
            }

            //List data NG
            List<double> dataNG = new List<double>();
            for (int i = 0; i < 7; i++)
            {
                if (GetSOFTdata.getNGData().Rows[0].ItemArray[i].ToString() == "")
                {
                    dataNG.Add(0);
                }
                else
                {
                    temp = double.Parse(GetSOFTdata.getNGData().Rows[0].ItemArray[i].ToString());
                    d = temp % totalNG() * 100;
                    dataNG.Add(d);
                }
            }
            lineRWChart.Data = dataRW;
            lineOPChart.Data = dataOP;
            lineNGChart.Data = dataNG;
            lineOPChart.TargetCanvas = lineCanvas;
            lineRWChart.TargetCanvas = lineCanvas;
            lineNGChart.TargetCanvas = lineCanvas;
            lineCanvas.Labels = new string[] { "L01", "L02", "L03", "L04", "L05", "L06", "L07" };
        }
        double totalOP()
        {
            double ttOP = 0;
            for (int i = 0; i < GetSOFTdata.getTotalOP().Rows.Count; i++)
            {
                string[] dataIn = GetSOFTdata.getTotalOP().Rows[i].ItemArray[0].ToString().Split(';');
                ttOP = ttOP + Double.Parse(dataIn[4]);
                dataIn = null;
            }            
            return ttOP;
        }
        double totalRW()
        {
            double ttOP = 0;
            for (int i = 0; i < GetSOFTdata.getTotalOP().Rows.Count; i++)
            {
                string[] dataIn = GetSOFTdata.getTotalOP().Rows[i].ItemArray[0].ToString().Split(';');
                ttOP = ttOP + Double.Parse(dataIn[4]);
                dataIn = null;
            }
            return ttOP;
        }
        double totalNG()
        {
            double ttOP = 0;
            for (int i = 0; i < GetSOFTdata.getTotalOP().Rows.Count; i++)
            {
                string[] dataIn = GetSOFTdata.getTotalOP().Rows[i].ItemArray[0].ToString().Split(';');
                ttOP = ttOP + Double.Parse(dataIn[4]);
                dataIn = null;
            }
            return ttOP;
        }
        private void dtpChart_ValueChanged(object sender, EventArgs e)
        {
            
            string date = dtpChart.Text.ToString();
         
        }
    }
}
