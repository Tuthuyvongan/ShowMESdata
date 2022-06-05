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

        public static DataTable getProductData(string date, string line)
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            MessageWaitForm msf = new MessageWaitForm();
            StringBuilder sqlGetData = new StringBuilder();
            DataColumn[] tableColumns = new DataColumn[]
            {
                new DataColumn()
                {
                    ColumnName="Model",
                    DataType=typeof(string),
                },
                new DataColumn()
                {
                    ColumnName="Date",
                    DataType=typeof(string),
                },                         
            };
            dt.Columns.AddRange(tableColumns);
            sqlGetData.Append("select distinct m.model as Model, m.inspectdate as Date, m.line as Line, m.OUTPUT, m.REWORK, m.NOGOOD, ");
            sqlGetData.Append("Total = m.OUTPUT + m.REWORK + m.NOGOOD, ");
            sqlGetData.Append("cast(m.NOGOOD / (m.OUTPUT + m.REWORK + m.NOGOOD) * 100 as decimal(10,1)) as '%NG_realtime', ");
            sqlGetData.Append("CASE WHEN r.rate IS NULL THEN (select top 1 rate from m_MQC_NGRATE where model = a.model and line = a.line order by inspectdate desc) ELSE r.rate END as '%NG_allow' ");
            sqlGetData.Append("FROM m_ERPMQC_REALTIME as a ");
            sqlGetData.Append("LEFT JOIN m_MQC_NGRATE as r on a.inspectdate = r.inspectdate and a.model = r.model and a.line = r.line ");
            sqlGetData.Append("join(SELECT model,  inspectdate, line, ");
            sqlGetData.Append("COALESCE(SUM(CASE WHEN remark = 'OP' THEN Cast(data as numeric(10,0)) END), 0) AS OUTPUT, ");
            sqlGetData.Append("COALESCE(SUM(CASE WHEN remark = 'RW' THEN Cast(data as numeric(10,0)) END), 0) AS REWORK, ");
            sqlGetData.Append("COALESCE(SUM(CASE WHEN remark = 'NG' THEN Cast(data as numeric(10,0)) END), 0) AS NOGOOD ");
            sqlGetData.Append("FROM m_ERPMQC_REALTIME ");
            sqlGetData.Append("WHERE inspectdate = '" + date + "' and line like '%" + line + "%'");
            sqlGetData.Append("group by model, inspectdate, line) as m ");
            sqlGetData.Append("on a.inspectdate = m.inspectdate and a.model = m.model and a.line = m.line ");
            sqlGetData.Append("order by Model, Date desc");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);           
            for (int i = 0; i < dt.Rows.Count; i ++)
            {
                string DtIn = Convert.ToDateTime(dt.Rows[i]["Date"]).ToString("dd-MM-yyyy");
                dt.Rows[i]["Date"] = DtIn;
            }
            dt.DefaultView.Sort = "%NG_realtime DESC";
            dt = dt.DefaultView.ToTable();
            return dt;
        }
    }
}