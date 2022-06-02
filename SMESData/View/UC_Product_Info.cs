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
    public partial class UC_Product_Info : UserControl
    {
        public UC_Product_Info()
        {
            InitializeComponent();
        }

        private void UC_Product_Info_Load(object sender, EventArgs e)
        {
            dtgv_MQC_PD.DataSource = GetSOFTdata.getProductData();
        }
    }
}
