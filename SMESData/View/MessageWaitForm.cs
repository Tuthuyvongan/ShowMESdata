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
    public partial class MessageWaitForm : Form
    {
        public MessageWaitForm()
        {
            InitializeComponent();
        }

        private void MessageWaitForm_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        public void UpdateProgress(int progress, string announce)
        {
            lbWait.BeginInvoke(
                new Action(() =>
                {
                    lbWait.Text = announce + progress + "%";
                }));
            progressBar1.BeginInvoke(
                new Action(() =>
                {
                    progressBar1.Value = progress;
                }
            ));
        }
    }
}
