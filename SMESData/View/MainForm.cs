using SMESData.View;
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

        //UC_MQC_BarChart uc_MQC_BarChart = new UC_MQC_BarChart();
        UC_MQC_PieChart uc_MQC_PieChart = new UC_MQC_PieChart();
        UC_PQC_PieChart uc_PQC_PieChart = new UC_PQC_PieChart();
        public static bool MQC;
        public static bool PQC;
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            //addUserControl(uc_MQC_PieChart);
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
       
        public void btMQC_Click(object sender, EventArgs e)
        {
            MQC = true;
            PQC = false;
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();          
            addUserControl(uc_MQC_PieChart);
            t.Abort();
            uc_MQC_PieChart.UpdateTime();
            btMQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btPQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;           
        }

        public void btPQC_Click(object sender, EventArgs e)
        {
            PQC = true;
            MQC = false;
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();            
            addUserControl(uc_PQC_PieChart);
            t.Abort();
            uc_PQC_PieChart.UpdateTime();
            btPQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btMQC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }
        public void splash()
        {
            Application.Run(new MessageWaitForm());
        }
        
    }
}
