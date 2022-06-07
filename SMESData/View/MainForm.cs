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
using Bunifu.UI.WinForms.BunifuButton;

namespace SMESData
{
    public partial class MainForm : Form
    {
        
        UC_MQC_PieChart uc_MQC_PieChart = new UC_MQC_PieChart();
        UC_PQC_PieChart uc_PQC_PieChart = new UC_PQC_PieChart();
        UC_Product_Info uc_PI = new UC_Product_Info();
        public static bool MQC;
        public static bool PQC;
        public static bool PD;

        public MainForm()
        {
            InitializeComponent();           
        }        
        private void MainForm_Load(object sender, EventArgs e)
        {
            uc_MQC_PieChart.OnUpdateStatus += customControl_OnUpdateStatus;
            btMQCPD.PerformClick();
            btMQCPD.Focus();
        }
        
        
        private void customControl_OnUpdateStatus(object sender, EventArgs e)
        {
            PD = true;
            MQC = false;
            PQC = false;
            addUserControl(uc_PI);
            uc_PI.UpdateTime();
            btMQCPD.FocusState = BunifuButton2.ButtonStates.Pressed;
            btPQC.FocusState = BunifuButton2.ButtonStates.Idle;
            btMQC.FocusState = BunifuButton2.ButtonStates.Idle;
            btMQCPD.Focus();
            uc_PI.UpdateDTGVByLine();
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
            btMQC.FocusState = BunifuButton2.ButtonStates.Pressed;
            btPQC.FocusState = BunifuButton2.ButtonStates.Idle;
            btMQCPD.FocusState = BunifuButton2.ButtonStates.Idle;
        }

        private void btPQC_Click(object sender, EventArgs e)
        {
            PQC = true;
            MQC = false;
            PD = false;
            addUserControl(uc_PQC_PieChart);           
            uc_PQC_PieChart.UpdateTime();
            btPQC.FocusState = BunifuButton2.ButtonStates.Pressed;
            btMQC.FocusState = BunifuButton2.ButtonStates.Idle;
            btMQCPD.FocusState = BunifuButton2.ButtonStates.Idle;
        }

        private void btMQCPD_Click(object sender, EventArgs e)
        {          
            PD = true;
            MQC = false;
            PQC = false;
            addUserControl(uc_PI);
            uc_PI.UpdateTime();
            btMQCPD.FocusState = BunifuButton2.ButtonStates.Pressed;
            btPQC.FocusState = BunifuButton2.ButtonStates.Idle;
            btMQC.FocusState = BunifuButton2.ButtonStates.Idle;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            uc_PI.tbSearch_KeyDown(sender, e);
        }
    }
}
