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
        public static double getTotalMQC(string line, string date)
        {
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            ComboBox cbx = new ComboBox();
            double s = 0;
            string[] temp;            
            sqlGetData.Append("select distinct serno ");
            sqlGetData.Append("from m_ERPMQC_REALTIME ");
            sqlGetData.Append("where line = '" + line + "' ");
            sqlGetData.Append("and inspectdate = '" + date + "'");
            sqlSOFTCon.getComboBoxData(sqlGetData.ToString(), ref cbx);
            for (int i = 0; i < cbx.Items.Count; i++)
            {
                temp = cbx.Items[i].ToString().Split(';');
                if (temp.Length > 4)
                {
                    s += double.Parse(temp[4]);
                }
            }
            if (s == 0)
                s = 1;
            return s;
        }
        public static double getTotalRemark(string line, string remark, string date)
        {
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            double s;
            string temp;
            sqlGetData.Append("select SUM(CASE WHEN line = '" + line + "' and remark = '" + remark + "' and inspectdate = '" + date + "' THEN Cast(data as numeric(10,0)) END) ");            
            sqlGetData.Append("from m_ERPMQC_REALTIME");
            temp = sqlSOFTCon.sqlExecuteScalarString(sqlGetData.ToString());
            if (temp == string.Empty || temp == "" || temp == null)
            {
                s = 0;
            }
            else
                s = double.Parse(temp);
            return s;
        }
        public static double getTotalPQC(string line, string date)
        {
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            ComboBox cbx = new ComboBox();
            double s = 0;
            string[] temp;
            sqlGetData.Append("select distinct POCode ");
            sqlGetData.Append("from ProcessHistory.PQCMesData ");
            sqlGetData.Append("where Line = '" + line + "' ");
            sqlGetData.Append("and InspectDateTime like '%" + date + "%' ");
            sqlGetData.Append("UNION ALL ");
            sqlGetData.Append("select distinct POCode ");
            sqlGetData.Append("from ProcessHistory.PQCMesDataBackup ");
            sqlGetData.Append("where Line = '" + line + "' ");
            sqlGetData.Append("and InspectDateTime like '%" + date + "%'");
            sqlSOFTCon.getComboBoxData(sqlGetData.ToString(), ref cbx);
            for (int i = 0; i < cbx.Items.Count; i++)
            {
                temp = cbx.Items[i].ToString().Split(';');
                if (temp.Length > 4)
                {
                    s += double.Parse(temp[4]);
                }    
            }
            if (s == 0)
                s = 1;
            return s;
        }
        public static double getTotalAttributeType(string line, string type, string date)
        {
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            ComboBox cbx = new ComboBox();
            double s = 0;
            string temp;
            sqlGetData.Append("select SUM(CASE WHEN Line = '" + line + "' and AttributeType = '" + type + "' and InspectDateTime like '%" + date + "%' THEN Cast(Quantity as numeric(10,0)) END) ");
            sqlGetData.Append("from ProcessHistory.PQCMesData ");
            sqlGetData.Append("UNION ALL ");
            sqlGetData.Append("select SUM(CASE WHEN Line = '" + line + "' and AttributeType = '" + type + "' and InspectDateTime like '%" + date + "%' THEN Cast(Quantity as numeric(10,0)) END) ");
            sqlGetData.Append("from ProcessHistory.PQCMesDataBackup");
            sqlSOFTCon.getComboBoxData(sqlGetData.ToString(), ref cbx);
            for (int i = 0; i < cbx.Items.Count; i++)
            {
                temp = cbx.Items[i].ToString();
                if (temp == string.Empty || temp == "" || temp == null)
                {
                    s = s + 0;
                }
                else
                {
                    s += double.Parse(temp);
                }    
                    
            }
            return s;
        }        
    }
}