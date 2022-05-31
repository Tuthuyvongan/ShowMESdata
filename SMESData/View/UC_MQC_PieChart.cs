using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            dtpChart.Value = DateTime.Today;
            dtpChart.CustomFormat = "dd-MM-yyyy";
            dtpChart.Format = DateTimePickerFormat.Custom;           
            dtpChart.Enabled = false;            
            dtpChart.ValueChanged += new EventHandler(dtpChart_ValueChanged);
            renderPiechart();            
            //
            lblTime.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            //Timer          
            timer1.Start();
            startTime = DateTime.Now;
            btStart.Enabled = false;
            pnTimeControl.Enabled = false;
        }
        //List data
        List<double> dataL01 = new List<double>();
        List<double> dataL02 = new List<double>();
        List<double> dataL03 = new List<double>();
        List<double> dataL04 = new List<double>();
        List<double> dataL05 = new List<double>();
        List<double> dataL06 = new List<double>();
        List<double> dataL07 = new List<double>();
        //
        public int secondsToWait = 30;
        private DateTime startTime;

        public void lineData()
        {
            string date = dtpChart.Value.ToString("yyyy-MM-dd");
            string [] remark = { "OP", "RW", "NG" };
            double d;
            double temp;
            for (int i = 0; i < 3; i++)
            {
                //L01
                temp = GetSOFTdata.getTotalRemark("L01", remark[i], date);
                if (temp == 0 || temp is double.NaN)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L01", date) * 100, 2);
                dataL01.Add(d);

                //L02
                temp = GetSOFTdata.getTotalRemark("L02", remark[i], date);
                if (temp == 0 || temp is double.NaN)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L02", date) * 100, 2);
                dataL02.Add(d);

                //L03
                temp = GetSOFTdata.getTotalRemark("L03", remark[i], date);
                if (temp == 0 || temp is double.NaN)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L03", date) * 100, 2);
                dataL03.Add(d);

                //L04
                temp = GetSOFTdata.getTotalRemark("L04", remark[i], date);
                if (temp == 0 || temp is double.NaN)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L04", date) * 100, 2);
                dataL04.Add(d);

                //L05
                temp = GetSOFTdata.getTotalRemark("L05", remark[i], date);
                if (temp == 0 || temp is double.NaN)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L05", date) * 100, 2);
                dataL05.Add(d);

                //L06
                temp = GetSOFTdata.getTotalRemark("L06", remark[i], date);
                if (temp == 0 || temp is double.NaN)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L06", date) * 100, 2);
                dataL06.Add(d);

                //L07
                temp = GetSOFTdata.getTotalRemark("L07", remark[i], date);
                if (temp == 0 || temp is double.NaN)
                    d = 0;
                else
                    d = Math.Round(temp / GetSOFTdata.getTotalMQC("L07", date) * 100, 2);
                dataL07.Add(d);
            }            
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
            //Add legends L01           
            if (dataL01[0] == 0 && dataL01[1] == 0 && dataL01[2] == 0)
            {
                lbOP1.Visible = false;
                lbRW1.Visible = false;
                lbNG1.Visible = false;
            }
            else
            {
                lbOP1.Visible = true;
                lbRW1.Visible = true;
                lbNG1.Visible = true;
                lbOP1.BackColor = Color.DodgerBlue;
                lbRW1.BackColor = Color.Orange;
                lbNG1.BackColor = Color.Red;
                lbOP1.Text = "OUTPUT: " + dataL01[0].ToString() + "%";
                lbRW1.Text = "REWORK: " + dataL01[1].ToString() + "%";
                lbNG1.Text = "NO GOOD: " + dataL01[2].ToString() + "%";
                lbOP1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbRW1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbNG1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
            //Add legends L02
            if (dataL02[0] == 0 && dataL02[1] == 0 && dataL02[2] == 0)
            {
                lbOP2.Visible = false;
                lbRW2.Visible = false;
                lbNG2.Visible = false;
            }
            else
            {
                lbOP2.Visible = true;
                lbRW2.Visible = true;
                lbNG2.Visible = true;
                lbOP2.BackColor = Color.DodgerBlue;
                lbRW2.BackColor = Color.Orange;
                lbNG2.BackColor = Color.Red;
                lbOP2.Text = "OUTPUT: " + dataL02[0].ToString() + "%";
                lbRW2.Text = "REWORK: " + dataL02[1].ToString() + "%";
                lbNG2.Text = "NO GOOD: " + dataL02[2].ToString() + "%";
                lbOP2.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbRW2.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbNG2.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
            //Add legends L03
            if (dataL03[0] == 0 && dataL03[1] == 0 && dataL03[2] == 0)
            {
                lbOP3.Visible = false;
                lbRW3.Visible = false;
                lbNG3.Visible = false;
            }
            else
            {
                lbOP3.Visible = true;
                lbRW3.Visible = true;
                lbNG3.Visible = true;
                lbOP3.BackColor = Color.DodgerBlue;
                lbRW3.BackColor = Color.Orange;
                lbNG3.BackColor = Color.Red;
                lbOP3.Text = "OUTPUT: " + dataL03[0].ToString() + "%";
                lbRW3.Text = "REWORK: " + dataL03[1].ToString() + "%";
                lbNG3.Text = "NO GOOD: " + dataL03[2].ToString() + "%";
                lbOP3.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbRW3.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbNG3.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
            //Add legends L04
            if (dataL04[0] == 0 && dataL04[1] == 0 && dataL04[2] == 0)
            {
                lbOP4.Visible = false;
                lbRW4.Visible = false;
                lbNG4.Visible = false;
            }
            else
            {
                lbOP4.Visible = true;
                lbRW4.Visible = true;
                lbNG4.Visible = true;
                lbOP4.BackColor = Color.DodgerBlue;
                lbRW4.BackColor = Color.Orange;
                lbNG4.BackColor = Color.Red;
                lbOP4.Text = "OUTPUT: " + dataL04[0].ToString() + "%";
                lbRW4.Text = "REWORK: " + dataL04[1].ToString() + "%";
                lbNG4.Text = "NO GOOD: " + dataL04[2].ToString() + "%";
                lbOP4.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbRW4.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbNG4.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
            //Add legends L05
            if (dataL05[0] == 0 && dataL05[1] == 0 && dataL05[2] == 0)
            {
                lbOP5.Visible = false;
                lbRW5.Visible = false;
                lbNG5.Visible = false;
            }
            else
            {
                lbOP5.Visible = true;
                lbRW5.Visible = true;
                lbNG5.Visible = true;
                lbOP5.BackColor = Color.DodgerBlue;
                lbRW5.BackColor = Color.Orange;
                lbNG5.BackColor = Color.Red;
                lbOP5.Text = "OUTPUT: " + dataL05[0].ToString() + "%";
                lbRW5.Text = "REWORK: " + dataL05[1].ToString() + "%";
                lbNG5.Text = "NO GOOD: " + dataL05[2].ToString() + "%";
                lbOP5.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbRW5.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbNG5.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
            //Add legends L06
            if (dataL06[0] == 0 && dataL06[1] == 0 && dataL06[2] == 0)
            {
                lbOP6.Visible = false;
                lbRW6.Visible = false;
                lbNG6.Visible = false;
            }
            else
            {
                lbOP6.Visible = true;
                lbRW6.Visible = true;
                lbNG6.Visible = true;
                lbOP6.BackColor = Color.DodgerBlue;
                lbRW6.BackColor = Color.Orange;
                lbNG6.BackColor = Color.Red;
                lbOP6.Text = "OUTPUT: " + dataL06[0].ToString() + "%";
                lbRW6.Text = "REWORK: " + dataL06[1].ToString() + "%";
                lbNG6.Text = "NO GOOD: " + dataL06[2].ToString() + "%";
                lbOP6.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbRW6.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbNG6.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
            //Add legends L07
            if (dataL07[0] == 0 && dataL07[1] == 0 && dataL07[2] == 0)
            {
                lbOP7.Visible = false;
                lbRW7.Visible = false;
                lbNG7.Visible = false;
            }
            else
            {
                lbOP7.Visible = true;
                lbRW7.Visible = true;
                lbNG7.Visible = true;
                lbOP7.BackColor = Color.DodgerBlue;
                lbRW7.BackColor = Color.Orange;
                lbNG7.BackColor = Color.Red;
                lbOP7.Text = "OUTPUT: " + dataL07[0].ToString() + "%";
                lbRW7.Text = "REWORK: " + dataL07[1].ToString() + "%";
                lbNG7.Text = "NO GOOD: " + dataL07[2].ToString() + "%";
                lbOP7.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbRW7.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbNG7.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            }
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
            //List Colors
            List<Color> bgColors = new List<Color>();
            bgColors.Add(Color.DodgerBlue);
            bgColors.Add(Color.Orange);
            bgColors.Add(Color.Red);           
            L01Chart.BackgroundColor = bgColors;
            L02Chart.BackgroundColor = bgColors;
            L03Chart.BackgroundColor = bgColors;
            L04Chart.BackgroundColor = bgColors;
            L05Chart.BackgroundColor = bgColors;
            L06Chart.BackgroundColor = bgColors;
            L07Chart.BackgroundColor = bgColors;
            dtpChart.Visible = true;           
        }

        private void dtpChart_ValueChanged(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(500);
            dtpChart.Visible = false;
            dataL01.Clear();
            dataL02.Clear();
            dataL03.Clear();
            dataL04.Clear();
            dataL05.Clear();
            dataL06.Clear();
            dataL07.Clear();
            renderPiechart();            
            t.Abort();
        }
        public void splash()
        {
            Application.Run(new MessageWaitForm());
        }
        public void UpdateTime()
        {
            dtpChart.Value = DateTime.Today;
            btStart.Enabled = false;
            btStop.Enabled = true;
            dtpChart.Enabled = false;
            pnTimeControl.Enabled = false;
            timer1.Start();
            startTime = DateTime.Now;
            lblTime.Visible = true;
        }
        public void ChangeUpdateTime()
        {
            int h = Int32.Parse(nbH.Value.ToString());
            int m = Int32.Parse(nbM.Value.ToString());
            int s = Int32.Parse(nbS.Value.ToString());           
            if (h == 0 && m == 0 && s == 0)
                secondsToWait = 30;
            else
                secondsToWait = h * 3600 + m * 60 + s;
        }           
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainForm.MQC == true)
            {               
                int elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
                int remainingSeconds = secondsToWait - elapsedSeconds;
                TimeSpan ts = TimeSpan.FromSeconds(remainingSeconds);
                string time = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                ts.Hours,
                                ts.Minutes,
                                ts.Seconds);
                lblTime.Text = "Chart update in: " + "\r\n" + time.ToString();
                if (remainingSeconds < 0)
                {
                    Thread t = new Thread(new ThreadStart(splash));
                    t.Start();
                    Thread.Sleep(500);
                    lblTime.Visible = false;
                    dataL01.Clear();
                    dataL02.Clear();
                    dataL03.Clear();
                    dataL04.Clear();
                    dataL05.Clear();
                    dataL06.Clear();
                    dataL07.Clear();
                    renderPiechart();                    
                    t.Abort();
                    timer1.Stop();
                    UpdateTime();
                }
            }
            else
                timer1.Stop();
        }      
        private void btStart_Click(object sender, EventArgs e)
        {           
            UpdateTime();
        }
        private void btStop_Click(object sender, EventArgs e)
        {
            btStart.Enabled = true;
            btStop.Enabled = false;
            dtpChart.Enabled = true;
            pnTimeControl.Enabled = true;
            timer1.Stop();           
            lblTime.Text = "Auto update" + "\r\n" + "chart is stopping";
        }

        private void nbH_ValueChanged(object sender, EventArgs e)
        {
            ChangeUpdateTime();
        }

        private void nbM_ValueChanged(object sender, EventArgs e)
        {
            ChangeUpdateTime();
        }

        private void nbS_ValueChanged(object sender, EventArgs e)
        {
            ChangeUpdateTime();
        }

        
    }
}
