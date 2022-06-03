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
    public partial class UC_Product_Info : UserControl
    {
        public UC_Product_Info()
        {
            InitializeComponent();
        }

        private void UC_Product_Info_Load(object sender, EventArgs e)
        {
            // Date time format
            dtpChart.Value = DateTime.Today;
            dtpChart.CustomFormat = "dd-MM-yyyy";
            dtpChart.Format = DateTimePickerFormat.Custom;
            dtpChart.Enabled = false;
            dtpChart.ValueChanged += new EventHandler(dtpChart_ValueChanged);
            //Update datagridview
            UpdateDTGV();
            ChangeData();
            lblTime.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            //Timer          
            timer1.Start();
            startTime = DateTime.Now;
            btStart.Enabled = false;
            pnTimeControl.Enabled = false;
        }

        //List data
        List<double> dataMQC = new List<double>();
        //
        public int secondsToWait = 300;
        private DateTime startTime;

        private void dtgv_MQC_PD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataMQC.Clear();
                SaveData.Model = dtgv_MQC_PD.Rows[e.RowIndex].Cells[0].Value.ToString();
                SaveData.line = dtgv_MQC_PD.Rows[e.RowIndex].Cells[2].Value.ToString();
                SaveData.op = double.Parse(dtgv_MQC_PD.Rows[e.RowIndex].Cells[3].Value.ToString());
                SaveData.rw = double.Parse(dtgv_MQC_PD.Rows[e.RowIndex].Cells[4].Value.ToString());
                SaveData.ng = double.Parse(dtgv_MQC_PD.Rows[e.RowIndex].Cells[5].Value.ToString());
                SaveData.total = double.Parse(dtgv_MQC_PD.Rows[e.RowIndex].Cells[6].Value.ToString());
                SaveData.NGrealtime = double.Parse(dtgv_MQC_PD.Rows[e.RowIndex].Cells[7].Value.ToString());
                SaveData.NGallow = double.Parse(dtgv_MQC_PD.Rows[e.RowIndex].Cells[8].Value.ToString());
                lbModel.Text = SaveData.Model;
                tbLine.Text = SaveData.line;
                lbOP.Text = SaveData.op.ToString();
                lbRW.Text = SaveData.rw.ToString();
                lbNG.Text = SaveData.ng.ToString();
                lbTt.Text = SaveData.total.ToString();
                lbNGR.Text = SaveData.NGrealtime.ToString() + "%";
                tbNGA.Text = SaveData.NGallow.ToString() + "%";
                renderPiechart();
            }
        }
        public void lineData()
        {
            double OP = Math.Round(SaveData.op / SaveData.total * 100, 1);
            double RW = Math.Round(SaveData.rw / SaveData.total * 100, 1);
            double NG = Math.Round(SaveData.ng / SaveData.total * 100, 1);
            dataMQC.Add(OP);
            dataMQC.Add(RW);
            dataMQC.Add(NG);

        }
        public void renderPiechart()
        {
            //Add data
            lineData();
            MQCChart.Data = dataMQC;
            //Add legends MQC           
            if (dataMQC[0] == 0 && dataMQC[1] == 0 && dataMQC[2] == 0)
            {
                lbOP1.Visible = false;
                lbRW1.Visible = false;
                lbNG1.Visible = false;
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
                lbOP1.BackColor = Color.DodgerBlue;
                lbRW1.BackColor = Color.Orange;
                lbNG1.BackColor = Color.Red;
                lbOP1.Text = "OUTPUT: " + dataMQC[0].ToString() + "%";
                lbRW1.Text = "REWORK: " + dataMQC[1].ToString() + "%";
                lbNG1.Text = "NO GOOD: " + dataMQC[2].ToString() + "%";
                lbOP1.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                lbRW1.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                lbNG1.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            }
            //Target Canvas
            MQCChart.TargetCanvas = linePCanvas1;
            //Hide x y Canvas1
            linePCanvas1.XAxesGridLines = false;
            linePCanvas1.YAxesGridLines = false;
            linePCanvas1.ShowXAxis = false;
            linePCanvas1.ShowYAxis = false;
            //Canvas labels
            string[] remark = { "OUTPUT", "REWORK", "NO GOOD" };
            linePCanvas1.Labels = remark;
            //List Colors
            List<Color> bgColors = new List<Color>();
            bgColors.Add(Color.DodgerBlue);
            bgColors.Add(Color.Orange);
            bgColors.Add(Color.Red);
            MQCChart.BackgroundColor = bgColors;
        }
        public void UpdateDTGV()
        {
            dataMQC.Clear();
            string date = dtpChart.Value.ToString("yyyy-MM-dd");
            string line = SaveData.line;
            dtgv_MQC_PD.DataSource = GetSOFTdata.getProductData(date, line);
            dtgv_MQC_PD.Refresh();
            dtpChart.Visible = true;
        }
        public void ChangeData()
        {
            SaveData.Model = dtgv_MQC_PD.Rows[0].Cells[0].Value.ToString();
            SaveData.line = dtgv_MQC_PD.Rows[0].Cells[2].Value.ToString();
            SaveData.op = double.Parse(dtgv_MQC_PD.Rows[0].Cells[3].Value.ToString());
            SaveData.rw = double.Parse(dtgv_MQC_PD.Rows[0].Cells[4].Value.ToString());
            SaveData.ng = double.Parse(dtgv_MQC_PD.Rows[0].Cells[5].Value.ToString());
            SaveData.total = double.Parse(dtgv_MQC_PD.Rows[0].Cells[6].Value.ToString());
            SaveData.NGrealtime = double.Parse(dtgv_MQC_PD.Rows[0].Cells[7].Value.ToString());
            SaveData.NGallow = double.Parse(dtgv_MQC_PD.Rows[0].Cells[8].Value.ToString());
            lbModel.Text = SaveData.Model;
            tbLine.Text = SaveData.line;
            lbOP.Text = SaveData.op.ToString();
            lbRW.Text = SaveData.rw.ToString();
            lbNG.Text = SaveData.ng.ToString();
            lbTt.Text = SaveData.total.ToString();
            lbNGR.Text = SaveData.NGrealtime.ToString() + "%";
            tbNGA.Text = SaveData.NGallow.ToString() + "%";
            renderPiechart();
        }
        private void dtpChart_ValueChanged(object sender, EventArgs e)
        {
            dtpChart.Visible = false;
            UpdateDTGV();
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
            if (MainForm.PD == true)
            {
                int elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
                int remainingSeconds = secondsToWait - elapsedSeconds;
                TimeSpan ts = TimeSpan.FromSeconds(remainingSeconds);
                string time = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                ts.Hours,
                                ts.Minutes,
                                ts.Seconds);
                lblTime.Text = "Data update in: " + "\r\n" + time.ToString();
                if (remainingSeconds < 0)
                {
                    lblTime.Visible = false;
                    UpdateDTGV();
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
            lblTime.Text = "Auto update" + "\r\n" + "data is stopping";
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
