using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SMESData
{
    class GetSOFTdata

    {        
        public static double getTotal(string line, string date) // get all order to data grid view
        {
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            ComboBox cbx = new ComboBox();
            double S = 0;
            string[] qty;            
            sqlGetData.Append("select distinct serno ");
            sqlGetData.Append("from m_ERPMQC_REALTIME ");
            sqlGetData.Append("where line = '" + line + "' ");
            sqlGetData.Append("and inspectdate = '" + date + "'");
            sqlSOFTCon.getComboBoxData(sqlGetData.ToString(), ref cbx);
            for (int i = 0; i < cbx.Items.Count; i++)
            {
                qty = cbx.Items[i].ToString().Split(';');
                if (qty[4] == "" )
                {
                    S = 1;
                }
                else
                {
                    S += double.Parse(qty[4]);
                }
            }
            return S;
        }
        public static double getTotalRemark(string line, string remark, string date) // get all order to data grid view
        {
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            double S;
            string qty;
            sqlGetData.Append("select SUM(CASE WHEN line = '" + line + "' and remark = '" + remark + "' and inspectdate = '" + date + "' THEN Cast(data as numeric(10,0)) END) ");            
            sqlGetData.Append("from m_ERPMQC_REALTIME");
            qty = sqlSOFTCon.sqlExecuteScalarString(sqlGetData.ToString());
            if (qty == string.Empty)
            {
                S = 0;
            }
            else
                S = double.Parse(qty);
            return S;
        }
    }
}