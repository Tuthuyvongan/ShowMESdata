using SMESData.View;
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
        UC_MQC uc_MQC = new UC_MQC();

        private void MainForm_Load(object sender, EventArgs e)
        {
            //addUserControl(uc_MQC);
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
            addUserControl(uc_MQC);
        }

        private void btPQC_Click(object sender, EventArgs e)
        {

        }
    }
}
