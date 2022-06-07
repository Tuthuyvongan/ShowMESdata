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
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Warning_Load(object sender, EventArgs e)
        {
            lbModel.Text = SaveData.Model;
            lbDate.Text = SaveData.Date;
            lbNGA.Text = SaveData.NGallow + "%";
        }
        private void btOK_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
