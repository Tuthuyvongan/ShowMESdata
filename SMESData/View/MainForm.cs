using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        UC_MQC_PieChart uc_MQC_PieChart = new UC_MQC_PieChart();
        UC_PQC_PieChart uc_PQC_PieChart = new UC_PQC_PieChart();
        UC_Product_Info uc_PI = new UC_Product_Info();
        public static bool MQC;
        public static bool PQC;
        public static bool PD;


        private void MainForm_Load(object sender, EventArgs e)
        {
            btMQCPD.PerformClick();
            btMQCPD.Focus();
            uc_MQC_PieChart.OnUpdateStatus += customControl_OnUpdateStatus;
        }
        private void customControl_OnUpdateStatus(object sender, EventArgs e)
        {
            btMQCPD.PerformClick();
            btMQCPD.Focus();
            uc_PI.UpdateDTGV();
            uc_PI.ChangeData();
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
     
        private void btMQC_Click(object sender, EventArgs e)
        {
            MQC = true;
            PQC = false;
            PD = false;
            addUserControl(uc_MQC_PieChart);            
            uc_MQC_PieChart.UpdateTime();
            btMQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btPQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            btMQCPD.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
        }

        private void btPQC_Click(object sender, EventArgs e)
        {
            PQC = true;
            MQC = false;
            PD = false;
            addUserControl(uc_PQC_PieChart);           
            uc_PQC_PieChart.UpdateTime();
            btPQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btMQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            btMQCPD.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
        }

        private void btMQCPD_Click(object sender, EventArgs e)
        {
            PD = true;
            MQC = false;
            PQC = false;
            addUserControl(uc_PI);
            uc_PI.UpdateTime();
            btMQCPD.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btPQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            btMQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }
        


    }
}
