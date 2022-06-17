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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
            UpdateDTGV();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
            //dtgv_Info.Columns.Clear();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            UpdateDTGV();
        }
        public void UpdateDTGV()
        {
            string model = SaveData.Model;
            string line = SaveData.line;
            string date = SaveData.Date;
            dtgv_Info.DataSource = GetSOFTdata.GetInfo(model, line, date);
            dtgv_Info.Columns["Date"].Visible = false;
            dtgv_Info.Columns["Time"].Visible = false;
            dtgv_Info.Columns["Model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtgv_Info.Columns["LotNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtgv_Info.Columns["Line"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtgv_Info.Columns["DateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtgv_Info.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtgv_Info.Columns["Inspector"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtgv_Info.Columns["Remark"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtgv_Info.Columns["Serno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtgv_Info.Columns["Model"].Width = 175;
            dtgv_Info.Columns["LotNumber"].Width = 125;
            dtgv_Info.Columns["Line"].Width = 50;
            dtgv_Info.Columns["DateTime"].Width = 150;
            dtgv_Info.Columns["Quantity"].Width = 75;
            dtgv_Info.Columns["Inspector"].Width = 75;
            dtgv_Info.Columns["Remark"].Width = 75;
            dtgv_Info.Columns["Serno"].Width = 775;
        }
    }
}
