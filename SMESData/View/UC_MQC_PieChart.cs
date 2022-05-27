using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMESData.View
{
    public partial class UC_MQC_PieChart : UserControl
    {
        public UC_MQC_PieChart()
        {
            InitializeComponent();
        }

        private void UC_MQC_PieChart_Load(object sender, EventArgs e)
        {
            // Date time format
            dtpChart.CustomFormat = "yyyy-MM-dd";
            dtpChart.Format = DateTimePickerFormat.Custom;
            renderPiechart();
        }
        //List data
        List<double> dataL01 = new List<double>();
        List<double> dataL02 = new List<double>();
        List<double> dataL03 = new List<double>();
        List<double> dataL04 = new List<double>();
        List<double> dataL05 = new List<double>();
        List<double> dataL06 = new List<double>();
        List<double> dataL07 = new List<double>();

        public void lineData()
        {
            string date = dtpChart.Text.ToString();
            string [] remark = { "OP", "RW", "NG" };
            double d;
            double temp;
            int i = 0;
            do
            {
                //L01
                temp = GetSOFTdata.getTotalRemark("L01", remark[i], date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L01", date) * 100, 2);
                dataL01.Add(d);

                //L02
                temp = GetSOFTdata.getTotalRemark("L02", remark[i], date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L02", date) * 100, 2);
                dataL02.Add(d);

                //L03
                temp = GetSOFTdata.getTotalRemark("L03", remark[i], date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L03", date) * 100, 2);
                dataL03.Add(d);

                //L04
                temp = GetSOFTdata.getTotalRemark("L04", remark[i], date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L04", date) * 100, 2);
                dataL04.Add(d);

                //L05
                temp = GetSOFTdata.getTotalRemark("L05", remark[i], date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L05", date) * 100, 2);
                dataL05.Add(d);

                //L06
                temp = GetSOFTdata.getTotalRemark("L06", remark[i], date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L06", date) * 100, 2);
                dataL06.Add(d);

                //L07
                temp = GetSOFTdata.getTotalRemark("L07", remark[i], date);
                if (temp == 0)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotal("L07", date) * 100, 2);
                dataL07.Add(d);
                i++;
            } while (i < 3);
        }
        public void renderPiechart()
        {
            //Add data
            lineData();
            L01Chart.Data = dataL01;
            L02Chart.Data = dataL02;
            L03Chart.Data = dataL03;
            L04Chart.Data = dataL04;
            L05Chart.Data = dataL05;
            L06Chart.Data = dataL06;
            L07Chart.Data = dataL07;
            //Target Canvas
            L01Chart.TargetCanvas = linePCanvas1;
            L02Chart.TargetCanvas = linePCanvas2;
            L03Chart.TargetCanvas = linePCanvas3;
            L04Chart.TargetCanvas = linePCanvas4;
            L05Chart.TargetCanvas = linePCanvas5;
            L06Chart.TargetCanvas = linePCanvas6;
            L07Chart.TargetCanvas = linePCanvas7;
            //Hide x y Canvas1
            linePCanvas1.XAxesGridLines = false;
            linePCanvas1.YAxesGridLines = false;
            linePCanvas1.ShowXAxis = false;
            linePCanvas1.ShowYAxis = false;
            //Hide x y Canvas2
            linePCanvas2.XAxesGridLines = false;
            linePCanvas2.YAxesGridLines = false;
            linePCanvas2.ShowXAxis = false;
            linePCanvas2.ShowYAxis = false;
            //Hide x y Canvas3
            linePCanvas3.XAxesGridLines = false;
            linePCanvas3.YAxesGridLines = false;
            linePCanvas3.ShowXAxis = false;
            linePCanvas3.ShowYAxis = false;
            //Hide x y Canvas4
            linePCanvas4.XAxesGridLines = false;
            linePCanvas4.YAxesGridLines = false;
            linePCanvas4.ShowXAxis = false;
            linePCanvas4.ShowYAxis = false;
            //Hide x y Canvas5
            linePCanvas5.XAxesGridLines = false;
            linePCanvas5.YAxesGridLines = false;
            linePCanvas5.ShowXAxis = false;
            linePCanvas5.ShowYAxis = false;
            //Hide x y Canvas6
            linePCanvas6.XAxesGridLines = false;
            linePCanvas6.YAxesGridLines = false;
            linePCanvas6.ShowXAxis = false;
            linePCanvas6.ShowYAxis = false;
            //Hide x y Canvas7
            linePCanvas7.XAxesGridLines = false;
            linePCanvas7.YAxesGridLines = false;
            linePCanvas7.ShowXAxis = false;
            linePCanvas7.ShowYAxis = false;
            //Canvas labels
            string[] remark = { "OUTPUT", "REWORK", "NO GOOD" };
            linePCanvas1.Labels = remark;
            linePCanvas2.Labels = remark;
            linePCanvas3.Labels = remark;
            linePCanvas4.Labels = remark;
            linePCanvas5.Labels = remark;
            linePCanvas6.Labels = remark;
            linePCanvas7.Labels = remark;
            //Canvas title
            linePCanvas1.Title = "L01";
            linePCanvas2.Title = "L02";
            linePCanvas3.Title = "L03";
            linePCanvas4.Title = "L04";
            linePCanvas5.Title = "L05";
            linePCanvas6.Title = "L06";
            linePCanvas7.Title = "L07";
            //List Colors
            List<Color> bgColors = new List<Color>();
            for (int i = 0; i < 3; i++)
            {
                if(linePCanvas1.Labels[i] == "OUTPUT")
                    bgColors.Add(Color.DodgerBlue);
                if (linePCanvas1.Labels[i] == "REWORK")
                    bgColors.Add(Color.Orange);
                else
                    bgColors.Add(Color.Red);
            }
            L01Chart.BackgroundColor = bgColors;
            L02Chart.BackgroundColor = bgColors;
            L03Chart.BackgroundColor = bgColors;
            L04Chart.BackgroundColor = bgColors;
            L05Chart.BackgroundColor = bgColors;
            L06Chart.BackgroundColor = bgColors;
            L07Chart.BackgroundColor = bgColors;
        }

        private void dtpChart_ValueChanged(object sender, EventArgs e)
        {
            dataL01.Clear();
            dataL02.Clear();
            dataL03.Clear();
            dataL04.Clear();
            dataL05.Clear();
            dataL06.Clear();
            dataL07.Clear();
            renderPiechart();
        }
    }
}
