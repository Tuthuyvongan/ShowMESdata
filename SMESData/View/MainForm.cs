﻿using System;
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
            // Date time format
            //dtpChart.Value = DateTime.Today;
            dtpChart.CustomFormat = "yyyy-MM-dd";
            dtpChart.Format = DateTimePickerFormat.Custom;
            renderBarchart();
        }

        void renderBarchart()
        {
            double d;
            double temp;
            string date = dtpChart.Text.ToString();
            //List data OP
            List<double> dataOP = new List<double>();
            List<double> dataNG = new List<double>();
            List<double> dataRW = new List<double>();
            int i = 0;
            do
            {
                //OP
                temp = GetSOFTdata.getTotalRemark("L0" + (i + 1), "OP", date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L0" + (i + 1), date) * 100, 2);
                dataOP.Add(d);
                //RW
                temp = GetSOFTdata.getTotalRemark("L0" + (i + 1), "RW", date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L0" + (i + 1), date) * 100, 2);
                dataRW.Add(d);
                //NG
                temp = GetSOFTdata.getTotalRemark("L0" + (i + 1), "NG", date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L0" + (i + 1), date) * 100, 2);
                dataNG.Add(d);
                i++;
            } while (i < 7);
            lineRWChart.Data = dataRW;
            lineOPChart.Data = dataOP;
            lineNGChart.Data = dataNG;
            lineOPChart.TargetCanvas = lineCanvas;
            lineRWChart.TargetCanvas = lineCanvas;
            lineNGChart.TargetCanvas = lineCanvas;
            lineCanvas.Labels = new string[] { "L01", "L02", "L03", "L04", "L05", "L06", "L07" };
        }
        
        private void dtpChart_ValueChanged(object sender, EventArgs e)
        {           
            renderBarchart();
        }
    }
}
