﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SMESData
{
    public partial class UC_PQC_PieChart : UserControl
    {
        public UC_PQC_PieChart()
        {
            InitializeComponent();
        }

        private void UC_PQC_PieChart_Load(object sender, EventArgs e)
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
        public int secondsToWait = 300;
        private DateTime startTime;        

        public void lineData()
        {
            string date = dtpChart.Value.ToString("yyyy-MM-dd");
            string[] type = { "OP", "RW", "NG" };
            double d;
            double temp;
            MessageWaitForm msf = new MessageWaitForm();
            Thread backgroundThreadFetchData = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            //L01
                            temp = GetSOFTdata.getTotalAttributeType("L01", type[i], date);
                            if (temp == 0 || temp is double.NaN)
                                d = 0;
                            else
                                d = Math.Round(temp / GetSOFTdata.getTotalPQC("L01", date) * 100, 2);
                            dataL01.Add(d);

                            //L02
                            temp = GetSOFTdata.getTotalAttributeType("L02", type[i], date);
                            if (temp == 0 || temp is double.NaN)
                                d = 0;
                            else
                                d = Math.Round(temp / GetSOFTdata.getTotalPQC("L02", date) * 100, 2);
                            dataL02.Add(d);

                            //L03
                            temp = GetSOFTdata.getTotalAttributeType("L03", type[i], date);
                            if (temp == 0 || temp is double.NaN)
                                d = 0;
                            else
                                d = Math.Round(temp / GetSOFTdata.getTotalPQC("L03", date) * 100, 2);
                            dataL03.Add(d);

                            //L04
                            temp = GetSOFTdata.getTotalAttributeType("L04", type[i], date);
                            if (temp == 0 || temp is double.NaN)
                                d = 0;
                            else
                                d = Math.Round(temp / GetSOFTdata.getTotalPQC("L04", date) * 100, 2);
                            dataL04.Add(d);

                            //L05
                            temp = GetSOFTdata.getTotalAttributeType("L05", type[i], date);
                            if (temp == 0 || temp is double.NaN)
                                d = 0;
                            else
                                d = Math.Round(temp / GetSOFTdata.getTotalPQC("L05", date) * 100, 2);
                            dataL05.Add(d);

                            //L06
                            temp = GetSOFTdata.getTotalAttributeType("L06", type[i], date);
                            if (temp == 0 || temp is double.NaN)
                                d = 0;
                            else
                                d = Math.Round(temp / GetSOFTdata.getTotalPQC("L06", date) * 100, 2);
                            dataL06.Add(d);

                            //L07
                            temp = GetSOFTdata.getTotalAttributeType("L07", type[i], date);
                            if (temp == 0 || temp is double.NaN)
                                d = 0;
                            else
                                d = Math.Round(temp / GetSOFTdata.getTotalPQC("L07", date) * 100, 2);
                            dataL07.Add(d);
                            Thread.Sleep(50);
                            msf.UpdateProgress(100 * (i + 1) / 3, "Application is running, please wait ... ");
                        }
                        msf.BeginInvoke(new Action(() => msf.Close()));
                    }
                ));
            backgroundThreadFetchData.Start();
            msf.ShowDialog();
        }
        public void clearData()
        {
            dataL01.Clear();
            dataL02.Clear();
            dataL03.Clear();
            dataL04.Clear();
            dataL05.Clear();
            dataL06.Clear();
            dataL07.Clear();
        }
        public void renderPiechart()
        {
            clearData();
            changePanel();
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
                btL1.Visible = false;
                lbWar1.Visible = true;
                lbWar1.Text = "No Data";
                lbWar1.Font = new Font("Times New Roman", 28, FontStyle.Bold);
            }
            else
            {
                lbWar1.Visible = false;
                lbOP1.Visible = true;
                lbRW1.Visible = true;
                lbNG1.Visible = true;
                btL1.Visible = true;
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
                btL2.Visible = false;
                lbWar2.Visible = true;
                lbWar2.Text = "No Data";
                lbWar2.Font = new Font("Times New Roman", 28, FontStyle.Bold);
            }
            else
            {
                lbWar2.Visible = false;
                lbOP2.Visible = true;
                lbRW2.Visible = true;
                lbNG2.Visible = true;
                btL2.Visible = true;
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
                btL3.Visible = false;
                lbWar3.Visible = true;
                lbWar3.Text = "No Data";
                lbWar3.Font = new Font("Times New Roman", 28, FontStyle.Bold);
            }
            else
            {
                lbWar3.Visible = false;
                lbOP3.Visible = true;
                lbRW3.Visible = true;
                lbNG3.Visible = true;
                btL3.Visible = true;
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
                btL4.Visible = false;
                lbWar4.Visible = true;
                lbWar4.Text = "No Data";
                lbWar4.Font = new Font("Times New Roman", 28, FontStyle.Bold);
            }
            else
            {
                lbWar4.Visible = false;
                lbOP4.Visible = true;
                lbRW4.Visible = true;
                lbNG4.Visible = true;
                btL4.Visible = true;
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
                btL5.Visible = false;
                lbWar5.Visible = true;
                lbWar5.Text = "No Data";
                lbWar5.Font = new Font("Times New Roman", 28, FontStyle.Bold);
            }
            else
            {
                lbWar5.Visible = false;
                lbOP5.Visible = true;
                lbRW5.Visible = true;
                lbNG5.Visible = true;
                btL5.Visible = true;
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
                btL6.Visible = false;
                lbWar6.Visible = true;
                lbWar6.Text = "No Data";
                lbWar6.Font = new Font("Times New Roman", 28, FontStyle.Bold);
            }
            else
            {
                lbWar6.Visible = false;
                lbOP6.Visible = true;
                lbRW6.Visible = true;
                lbNG6.Visible = true;
                btL6.Visible = true;
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
                btL7.Visible = false;
                lbWar7.Visible = true;
                lbWar7.Text = "No Data";
                lbWar7.Font = new Font("Times New Roman", 28, FontStyle.Bold);
            }
            else
            {
                lbWar7.Visible = false;
                lbOP7.Visible = true;
                lbRW7.Visible = true;
                lbNG7.Visible = true;
                btL7.Visible = true;
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
            string[] type = { "OUTPUT", "REWORK", "NO GOOD" };
            linePCanvas1.Labels = type;
            linePCanvas2.Labels = type;
            linePCanvas3.Labels = type;
            linePCanvas4.Labels = type;
            linePCanvas5.Labels = type;
            linePCanvas6.Labels = type;
            linePCanvas7.Labels = type;
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
            SaveData.check = true;
            dtpChart.Visible = false;            
            renderPiechart();
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
            SaveData.Date = dtpChart.Value.ToString("yyyy-MM-dd");
            SaveData.check = false;
        }
        public void ChangeUpdateTime()
        {
            int h = Int32.Parse(nbH.Value.ToString());
            int m = Int32.Parse(nbM.Value.ToString());
            int s = Int32.Parse(nbS.Value.ToString());            
            if (h == 0 && m == 0 && s == 0)
                secondsToWait = 300;
            else
                secondsToWait = h * 3600 + m * 60 + s;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainForm.PQC == true)
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
                    lblTime.Text = "Data is being" + "\r\n" + "updated";                                 
                    timer1.Stop();
                    SaveData.uc_pi = -1;
                    SaveData.uc_mqc = -1;
                    SaveData.uc_pqc = 0;
                    renderPiechart();
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

        public delegate void StatusUpdateHandler(object sender, EventArgs e);
        public event StatusUpdateHandler OnUpdateStatus;

        private void UpdateStatus()
        {
            EventArgs args = new EventArgs();

            //Call any listeners
            OnUpdateStatus?.Invoke(this, args);

        }
        private void btL1_Click(object sender, EventArgs e)
        {
            SaveData.PQC = true;
            SaveData.MQC = false;
            SaveData.PQCClick = true;
            SaveData.MQCClick = false;
            SaveData.line = "L01";
            SaveData.Date = dtpChart.Value.ToString("yyyy-MM-dd");
            UpdateStatus();
        }

        private void btL2_Click(object sender, EventArgs e)
        {
            SaveData.PQC = true;
            SaveData.MQC = false;
            SaveData.PQCClick = true;
            SaveData.MQCClick = false;
            SaveData.line = "L02";
            SaveData.Date = dtpChart.Value.ToString("yyyy-MM-dd");
            UpdateStatus();
        }

        private void btL3_Click(object sender, EventArgs e)
        {
            SaveData.PQC = true;
            SaveData.MQC = false;
            SaveData.PQCClick = true;
            SaveData.MQCClick = false;
            SaveData.line = "L03";
            SaveData.Date = dtpChart.Value.ToString("yyyy-MM-dd");
            UpdateStatus();
        }

        private void btL4_Click(object sender, EventArgs e)
        {
            SaveData.PQC = true;
            SaveData.MQC = false;
            SaveData.PQCClick = true;
            SaveData.MQCClick = false;
            SaveData.line = "L04";
            SaveData.Date = dtpChart.Value.ToString("yyyy-MM-dd");
            UpdateStatus();
        }

        private void btL5_Click(object sender, EventArgs e)
        {
            SaveData.PQC = true;
            SaveData.MQC = false;
            SaveData.PQCClick = true;
            SaveData.MQCClick = false;
            SaveData.line = "L05";
            SaveData.Date = dtpChart.Value.ToString("yyyy-MM-dd");
            UpdateStatus();
        }

        private void btL6_Click(object sender, EventArgs e)
        {
            SaveData.PQC = true;
            SaveData.MQC = false;
            SaveData.PQCClick = true;
            SaveData.MQCClick = false;
            SaveData.line = "L06";
            SaveData.Date = dtpChart.Value.ToString("yyyy-MM-dd");
            UpdateStatus();
        }

        private void btL7_Click(object sender, EventArgs e)
        {
            SaveData.PQC = true;
            SaveData.MQC = false;
            SaveData.PQCClick = true;
            SaveData.MQCClick = false;
            SaveData.line = "L07";
            SaveData.Date = dtpChart.Value.ToString("yyyy-MM-dd");
            UpdateStatus();
        }
        public void changePanel()
        {
            SaveData.dtTemp2 = new DataTable();
            SaveData.dtTemp2 = GetSOFTdata.GetListPQC(dtpChart.Value.ToString("yyyy-MM-dd"), "");
            if (SaveData.dtTemp2.Rows.Count > 0)
            {
                DataRow[] results1 = SaveData.dtTemp2.Select("Line = 'L01' and NG_rate_realtime > NG_rate_allow and RW_rate_realtime > RW_rate_allow");
                DataRow[] results11 = SaveData.dtTemp2.Select("Line = 'L01' and (NG_rate_realtime > NG_rate_allow or RW_rate_realtime > RW_rate_allow)");
                //DataRow[] results111 = SaveData.dtTemp2.Select("Line = 'L01' and RW_rate_realtime > RW_rate_allow");
                DataRow[] results2 = SaveData.dtTemp2.Select("Line = 'L02' and NG_rate_realtime > NG_rate_allow and RW_rate_realtime > RW_rate_allow");
                DataRow[] results22 = SaveData.dtTemp2.Select("Line = 'L02' and (NG_rate_realtime > NG_rate_allow or RW_rate_realtime > RW_rate_allow)");
                //DataRow[] results222 = SaveData.dtTemp2.Select("Line = 'L02' and RW_rate_realtime > RW_rate_allow");
                DataRow[] results3 = SaveData.dtTemp2.Select("Line = 'L03' and NG_rate_realtime > NG_rate_allow and RW_rate_realtime > RW_rate_allow");
                DataRow[] results33 = SaveData.dtTemp2.Select("Line = 'L03' and (NG_rate_realtime > NG_rate_allow or RW_rate_realtime > RW_rate_allow)");
                //DataRow[] results333 = SaveData.dtTemp2.Select("Line = 'L03' and RW_rate_realtime > RW_rate_allow");
                DataRow[] results4 = SaveData.dtTemp2.Select("Line = 'L04' and NG_rate_realtime > NG_rate_allow and RW_rate_realtime > RW_rate_allow");
                DataRow[] results44 = SaveData.dtTemp2.Select("Line = 'L04' and (NG_rate_realtime > NG_rate_allow or RW_rate_realtime > RW_rate_allow)");
                //DataRow[] results444 = SaveData.dtTemp2.Select("Line = 'L04' and RW_rate_realtime > RW_rate_allow");
                DataRow[] results5 = SaveData.dtTemp2.Select("Line = 'L05' and NG_rate_realtime > NG_rate_allow and RW_rate_realtime > RW_rate_allow");
                DataRow[] results55 = SaveData.dtTemp2.Select("Line = 'L05' and (NG_rate_realtime > NG_rate_allow or RW_rate_realtime > RW_rate_allow)");
                //DataRow[] results555 = SaveData.dtTemp2.Select("Line = 'L05' and RW_rate_realtime > RW_rate_allow");
                DataRow[] results6 = SaveData.dtTemp2.Select("Line = 'L06' and NG_rate_realtime > NG_rate_allow and RW_rate_realtime > RW_rate_allow");
                DataRow[] results66 = SaveData.dtTemp2.Select("Line = 'L06' and (NG_rate_realtime > NG_rate_allow or RW_rate_realtime > RW_rate_allow)");
                //DataRow[] results666 = SaveData.dtTemp2.Select("Line = 'L06' and RW_rate_realtime > RW_rate_allow");
                DataRow[] results7 = SaveData.dtTemp2.Select("Line = 'L07' and NG_rate_realtime > NG_rate_allow and RW_rate_realtime > RW_rate_allow");
                DataRow[] results77 = SaveData.dtTemp2.Select("Line = 'L07' and (NG_rate_realtime > NG_rate_allow or RW_rate_realtime > RW_rate_allow)");
                //DataRow[] results777 = SaveData.dtTemp2.Select("Line = 'L07' and RW_rate_realtime > RW_rate_allow");
                //pn1
                if (results1.Length > 0)
                {
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    panel1.BackColor = Color.DarkViolet;
                    linePCanvas1.BackColor = Color.DarkViolet;
                }
                else if (results11.Length > 0)
                {
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    panel1.BackColor = Color.Yellow;
                    linePCanvas1.BackColor = Color.Yellow;
                }
                //else if (results111.Length > 0)
                //{
                //    panel1.BorderStyle = BorderStyle.FixedSingle;
                //    panel1.BackColor = Color.LightYellow;
                //    linePCanvas1.BackColor = Color.LightYellow;
                //}
                else
                {
                    panel1.BorderStyle = BorderStyle.Fixed3D;
                    panel1.BackColor = Color.White;
                    linePCanvas1.BackColor = Color.White;
                }
                //pn2
                if (results2.Length > 0)
                {
                    panel2.BorderStyle = BorderStyle.FixedSingle;
                    panel2.BackColor = Color.DarkViolet;
                    linePCanvas2.BackColor = Color.DarkViolet;
                }
                else if (results22.Length > 0)
                {
                    panel2.BorderStyle = BorderStyle.FixedSingle;
                    panel2.BackColor = Color.Yellow;
                    linePCanvas2.BackColor = Color.Yellow;
                }
                //else if (results222.Length > 0)
                //{
                //    panel2.BorderStyle = BorderStyle.FixedSingle;
                //    panel2.BackColor = Color.LightYellow;
                //    linePCanvas2.BackColor = Color.LightYellow;
                //}
                else
                {
                    panel2.BorderStyle = BorderStyle.Fixed3D;
                    panel2.BackColor = Color.White;
                    linePCanvas2.BackColor = Color.White;
                }
                //pn3
                if (results3.Length > 0)
                {
                    panel3.BorderStyle = BorderStyle.FixedSingle;
                    panel3.BackColor = Color.DarkViolet;
                    linePCanvas3.BackColor = Color.DarkViolet;
                }
                else if (results33.Length > 0)
                {
                    panel3.BorderStyle = BorderStyle.FixedSingle;
                    panel3.BackColor = Color.Yellow;
                    linePCanvas3.BackColor = Color.Yellow;
                }
                //else if (results333.Length > 0)
                //{
                //    panel3.BorderStyle = BorderStyle.FixedSingle;
                //    panel3.BackColor = Color.LightYellow;
                //    linePCanvas3.BackColor = Color.LightYellow;
                //}
                else
                {
                    panel3.BorderStyle = BorderStyle.Fixed3D;
                    panel3.BackColor = Color.White;
                    linePCanvas3.BackColor = Color.White;
                }
                //pn4
                if (results4.Length > 0)
                {
                    panel4.BorderStyle = BorderStyle.FixedSingle;
                    panel4.BackColor = Color.DarkViolet;
                    linePCanvas4.BackColor = Color.DarkViolet;
                }
                else if (results44.Length > 0)
                {
                    panel4.BorderStyle = BorderStyle.FixedSingle;
                    panel4.BackColor = Color.Yellow;
                    linePCanvas4.BackColor = Color.Yellow;
                }
                //else if (results444.Length > 0)
                //{
                //    panel4.BorderStyle = BorderStyle.FixedSingle;
                //    panel4.BackColor = Color.LightYellow;
                //    linePCanvas4.BackColor = Color.LightYellow;
                //}
                else
                {
                    panel4.BorderStyle = BorderStyle.Fixed3D;
                    panel4.BackColor = Color.White;
                    linePCanvas4.BackColor = Color.White;
                }
                //pn5
                if (results5.Length > 0)
                {
                    panel5.BorderStyle = BorderStyle.FixedSingle;
                    panel5.BackColor = Color.DarkViolet;
                    linePCanvas5.BackColor = Color.DarkViolet;
                }
                else if (results55.Length > 0)
                {
                    panel5.BorderStyle = BorderStyle.FixedSingle;
                    panel5.BackColor = Color.Yellow;
                    linePCanvas5.BackColor = Color.Yellow;
                }
                //else if (results555.Length > 0)
                //{
                //    panel5.BorderStyle = BorderStyle.FixedSingle;
                //    panel5.BackColor = Color.LightYellow;
                //    linePCanvas5.BackColor = Color.LightYellow;
                //}
                else
                {
                    panel5.BorderStyle = BorderStyle.Fixed3D;
                    panel5.BackColor = Color.White;
                    linePCanvas5.BackColor = Color.White;
                }
                //pn6
                if (results6.Length > 0)
                {
                    panel6.BorderStyle = BorderStyle.FixedSingle;
                    panel6.BackColor = Color.DarkViolet;
                    linePCanvas6.BackColor = Color.DarkViolet;
                }
                else if (results66.Length > 0)
                {
                    panel6.BorderStyle = BorderStyle.FixedSingle;
                    panel6.BackColor = Color.Yellow;
                    linePCanvas6.BackColor = Color.Yellow;
                }
                //else if (results666.Length > 0)
                //{
                //    panel6.BorderStyle = BorderStyle.FixedSingle;
                //    panel6.BackColor = Color.LightYellow;
                //    linePCanvas6.BackColor = Color.LightYellow;
                //}
                else
                {
                    panel6.BorderStyle = BorderStyle.Fixed3D;
                    panel6.BackColor = Color.White;
                    linePCanvas6.BackColor = Color.White;
                }
                //pn7
                if (results7.Length > 0)
                {
                    panel7.BorderStyle = BorderStyle.FixedSingle;
                    panel7.BackColor = Color.DarkViolet;
                    linePCanvas7.BackColor = Color.DarkViolet;
                }
                else if (results77.Length > 0)
                {
                    panel7.BorderStyle = BorderStyle.FixedSingle;
                    panel7.BackColor = Color.Yellow;
                    linePCanvas7.BackColor = Color.Yellow;
                }
                //else if (results777.Length > 0)
                //{
                //    panel7.BorderStyle = BorderStyle.FixedSingle;
                //    panel7.BackColor = Color.LightYellow;
                //    linePCanvas7.BackColor = Color.LightYellow;
                //}
                else
                {
                    panel7.BorderStyle = BorderStyle.Fixed3D;
                    panel7.BackColor = Color.White;
                    linePCanvas7.BackColor = Color.White;
                }
            }
            else
            {
                //pn1
                panel1.BorderStyle = BorderStyle.Fixed3D;
                panel1.BackColor = Color.White;
                linePCanvas1.BackColor = Color.White;
                //pn2
                panel2.BorderStyle = BorderStyle.Fixed3D;
                panel2.BackColor = Color.White;
                linePCanvas2.BackColor = Color.White;
                //pn3
                panel3.BorderStyle = BorderStyle.Fixed3D;
                panel3.BackColor = Color.White;
                linePCanvas3.BackColor = Color.White;
                //pn4
                panel4.BorderStyle = BorderStyle.Fixed3D;
                panel4.BackColor = Color.White;
                linePCanvas4.BackColor = Color.White;
                //pn5
                panel5.BorderStyle = BorderStyle.Fixed3D;
                panel5.BackColor = Color.White;
                linePCanvas5.BackColor = Color.White;
                //pn6
                panel6.BorderStyle = BorderStyle.Fixed3D;
                panel6.BackColor = Color.White;
                linePCanvas6.BackColor = Color.White;
                //pn7
                panel7.BorderStyle = BorderStyle.Fixed3D;
                panel7.BackColor = Color.White;
                linePCanvas7.BackColor = Color.White;
            }
        }
        public void sizeChange()
        {
            linePCanvas1.CanvasPadding = new Padding(14, 6, 14, 14);
            linePCanvas2.CanvasPadding = new Padding(28, 6, 28, 38);
            linePCanvas3.CanvasPadding = new Padding(14, 6, 14, 14);
            linePCanvas4.CanvasPadding = new Padding(28, 6, 28, 38);
            linePCanvas5.CanvasPadding = new Padding(28, 6, 28, 38);
            linePCanvas6.CanvasPadding = new Padding(28, 6, 28, 38);
            linePCanvas7.CanvasPadding = new Padding(28, 6, 28, 38);
        }
        public void sizeDefault()
        {
            linePCanvas1.CanvasPadding = new Padding(6, 6, 8, 6);
            linePCanvas2.CanvasPadding = new Padding(6, -6, 8, 18);
            linePCanvas3.CanvasPadding = new Padding(6, 6, 8, 6);
            linePCanvas4.CanvasPadding = new Padding(6, -6, 8, 18);
            linePCanvas5.CanvasPadding = new Padding(6, -6, 8, 18);
            linePCanvas6.CanvasPadding = new Padding(6, -6, 8, 18);
            linePCanvas7.CanvasPadding = new Padding(6, -6, 8, 18);
        }
    }
}
