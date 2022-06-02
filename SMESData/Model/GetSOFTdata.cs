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
            double s;
            string temp;
            sqlGetData.Append("select SUM(CASE WHEN Line = '" + line + "' and AttributeType = '" + type + "' and InspectDateTime like '%" + date + "%' THEN Cast(Quantity as numeric(10,0)) END) ");
            sqlGetData.Append("from ProcessHistory.PQCMesData");
            temp = sqlSOFTCon.sqlExecuteScalarString(sqlGetData.ToString());
            if (temp == string.Empty || temp == "" || temp == null)
            {
                s = 0;
            }
            else
                s = double.Parse(temp);
            return s;
        }

        public static DataTable getProductData()
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("select distinct m.model, m.inspectdate, m.OUTPUT, m.REWORK, m.NOGOOD, ");
            sqlGetData.Append("line = STUFF((SELECT distinct(';' + l.line) ");
            sqlGetData.Append("FROM m_ERPMQC_REALTIME as l ");
            sqlGetData.Append("where l.inspectdate = m.inspectdate and l.model = m.model ");
            sqlGetData.Append("FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, ''), ");
            sqlGetData.Append("total = m.OUTPUT + m.REWORK + m.NOGOOD, ");
            sqlGetData.Append("cast(m.NOGOOD / (m.OUTPUT + m.REWORK + m.NOGOOD) * 100 as decimal(10,1)) as '%NG_realtime', ");
            sqlGetData.Append("'1,5' as '%NG_allow' ");
            sqlGetData.Append("FROM m_ERPMQC_REALTIME as a ");
            sqlGetData.Append("join(SELECT model,  inspectdate, ");
            sqlGetData.Append("COALESCE(SUM(CASE WHEN remark = 'OP' THEN Cast(data as numeric(10,0)) END), 0) AS OUTPUT, ");
            sqlGetData.Append("COALESCE(SUM(CASE WHEN remark = 'RW' THEN Cast(data as numeric(10,0)) END), 0) AS REWORK, ");
            sqlGetData.Append("COALESCE(SUM(CASE WHEN remark = 'NG' THEN Cast(data as numeric(10,0)) END), 0) AS NOGOOD ");
            sqlGetData.Append("FROM m_ERPMQC_REALTIME ");
            sqlGetData.Append("WHERE inspectdate >= '2022-06-02' ");
            sqlGetData.Append("group by model, inspectdate) as m ");
            sqlGetData.Append("on a.inspectdate = m.inspectdate and a.model = m.model ");
            sqlGetData.Append("ORDER BY inspectdate desc");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
    }
}