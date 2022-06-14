using System;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;

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
            uc_MQC_PieChart.OnUpdateStatus += customControl_OnUpdateStatus;
            uc_PQC_PieChart.OnUpdateStatus += customControl_OnUpdateStatus;
            btMQCPD.PerformClick();
            btMQCPD.Focus();
            changeSize();
        }        
        public void changeSize()
        {
            if (Screen.PrimaryScreen.Bounds.Width <= 1550)
            {
                uc_MQC_PieChart.sizeDefault();
                uc_PQC_PieChart.sizeDefault();
            }
            else
            {
                uc_MQC_PieChart.sizeChange();
                uc_PQC_PieChart.sizeChange();
            }
        }
        private void customControl_OnUpdateStatus(object sender, EventArgs e)
        {
            PD = true;
            MQC = false;
            PQC = false;
            addUserControl(uc_PI);
            if (SaveData.Date == DateTime.Today.ToString("yyyy-MM-dd"))
                uc_PI.UpdateTime();
            btMQCPD.FocusState = BunifuButton2.ButtonStates.Pressed;
            btPQC.FocusState = BunifuButton2.ButtonStates.Idle;
            btMQC.FocusState = BunifuButton2.ButtonStates.Idle;
            btMQCPD.Focus();
            uc_PI.UpdateDTGVByLine();
        }
        private void addUserControl(UserControl userControl)
        {
            pnMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;            
            pnMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
     
        private void btMQC_Click(object sender, EventArgs e)
        {
            MQC = true;
            PQC = false;
            PD = false;
            addUserControl(uc_MQC_PieChart);
            if (SaveData.Date == DateTime.Today.ToString("yyyy-MM-dd"))
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
            if (SaveData.Date == DateTime.Today.ToString("yyyy-MM-dd"))
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
            if (SaveData.Date == DateTime.Today.ToString("yyyy-MM-dd"))
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
            if (uc_PI != null)
                if (e.KeyCode == Keys.Enter)
                    uc_PI.tbSearch_KeyDown(sender, e);
        }       
    }
}
