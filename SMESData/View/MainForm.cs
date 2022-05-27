﻿using SMESData.View;
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
        UC_MQC_BarChart uc_MQC_BarChart = new UC_MQC_BarChart();
        UC_MQC_PieChart uc_MQC_PieChart = new UC_MQC_PieChart();

        private void MainForm_Load(object sender, EventArgs e)
        {
            addUserControl(uc_MQC_PieChart);
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
            addUserControl(uc_MQC_PieChart);
        }

        private void btPQC_Click(object sender, EventArgs e)
        {          
            addUserControl(uc_MQC_BarChart);
        }
    }
}
