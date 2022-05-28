using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMESData.View
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
            progressBar1.TransitionValue(100, 6000);
        }
   
    }
}
