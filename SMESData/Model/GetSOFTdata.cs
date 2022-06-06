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
            sqlGetData.Append("CASE WHEN r.rate IS NULL THEN (select top 1 rate from m_MQC_NGRATE where model = a.model and line = a.line order by inspectdate desc) ELSE '1.5' END as '%NG_allow' ");
            sqlGetData.Append("FROM m_ERPMQC_REALTIME as a ");
            sqlGetData.Append("LEFT JOIN m_MQC_NGRATE as r on a.model = r.model and a.line = r.line and a.inspectdate = r.inspectdate ");
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
        public static List<ListMQC> GetListMQC(string date, string line)
        {
            List<ListMQC> ListMQC = new List<ListMQC>();
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("select distinct m.model as Model, m.inspectdate as Date, m.line as Line, m.OUTPUT, m.REWORK, m.NOGOOD, ");
            sqlGetData.Append("serno, ");
            sqlGetData.Append("CASE WHEN r.rate IS NULL THEN (select top 1 rate from m_MQC_NGRATE where model = a.model and line = a.line order by inspectdate desc) ELSE '1.5' END as '%NG_allow' ");
            sqlGetData.Append("FROM m_ERPMQC_REALTIME as a ");
            sqlGetData.Append("LEFT JOIN m_MQC_NGRATE as r on a.model = r.model and a.line = r.line and a.inspectdate = r.inspectdate ");
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
            ListMQC MQC = new ListMQC();
            MQC.Total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i + 1 != dt.Rows.Count)
                {
                    if (dt.Rows[i]["Model"].ToString() == dt.Rows[i + 1]["Model"].ToString() && dt.Rows[i]["Line"].ToString() == dt.Rows[i + 1]["Line"].ToString())
                    {
                        string[] serno = dt.Rows[i]["serno"].ToString().Split(';');
                        string[] serno1 = dt.Rows[i + 1]["serno"].ToString().Split(';');
                        if (serno[3] != serno1[3])
                            MQC.Total = MQC.Total + double.Parse(serno[4]);
                    }
                    else
                    {
                        string[] serno = dt.Rows[i]["serno"].ToString().Split(';');
                        MQC.Total = MQC.Total + double.Parse(serno[4]);
                        MQC.Model = dt.Rows[i]["Model"].ToString();
                        MQC.Date = Convert.ToDateTime(dt.Rows[i]["Date"]).ToString("dd-MM-yyyy");
                        MQC.Line = dt.Rows[i]["Line"].ToString();
                        MQC.OUTPUT = double.Parse(dt.Rows[i]["OUTPUT"].ToString());
                        MQC.REWORK = double.Parse(dt.Rows[i]["REWORK"].ToString());
                        MQC.NOGOOD = double.Parse(dt.Rows[i]["NOGOOD"].ToString());
                        MQC.NG_rate_realtime = Math.Round(MQC.NOGOOD / MQC.Total * 100, 1);
                        MQC.NG_rate_allow = double.Parse(dt.Rows[i]["%NG_allow"].ToString());
                        ListMQC.Add(MQC);
                        MQC = new ListMQC();
                        MQC.Total = 0;
                    }
                }
                else
                {
                    if (dt.Rows[i - 1]["Model"].ToString() == dt.Rows[i]["Model"].ToString() && dt.Rows[i - 1]["Line"].ToString() == dt.Rows[i]["Line"].ToString())
                    {
                        string[] serno = dt.Rows[i - 1]["serno"].ToString().Split(';');
                        string[] serno1 = dt.Rows[i]["serno"].ToString().Split(';');
                        if (serno[3] != serno1[3])
                            MQC.Total = MQC.Total + double.Parse(serno[4]);
                        MQC.Model = dt.Rows[i]["Model"].ToString();
                        MQC.Date = Convert.ToDateTime(dt.Rows[i]["Date"]).ToString("dd-MM-yyyy");
                        MQC.Line = dt.Rows[i]["Line"].ToString();
                        MQC.OUTPUT = double.Parse(dt.Rows[i]["OUTPUT"].ToString());
                        MQC.REWORK = double.Parse(dt.Rows[i]["REWORK"].ToString());
                        MQC.NOGOOD = double.Parse(dt.Rows[i]["NOGOOD"].ToString());
                        MQC.NG_rate_realtime = Math.Round(MQC.NOGOOD / MQC.Total * 100, 1);
                        MQC.NG_rate_allow = double.Parse(dt.Rows[i]["%NG_allow"].ToString());
                        ListMQC.Add(MQC);
                    }
                    else
                    {
                        string[] serno = dt.Rows[i]["serno"].ToString().Split(';');
                        MQC.Total = MQC.Total + double.Parse(serno[4]);
                        MQC.Model = dt.Rows[i]["Model"].ToString();
                        MQC.Date = Convert.ToDateTime(dt.Rows[i]["Date"]).ToString("dd-MM-yyyy");
                        MQC.Line = dt.Rows[i]["Line"].ToString();
                        MQC.OUTPUT = double.Parse(dt.Rows[i]["OUTPUT"].ToString());
                        MQC.REWORK = double.Parse(dt.Rows[i]["REWORK"].ToString());
                        MQC.NOGOOD = double.Parse(dt.Rows[i]["NOGOOD"].ToString());
                        MQC.NG_rate_realtime = Math.Round(MQC.NOGOOD / MQC.Total * 100, 1);
                        MQC.NG_rate_allow = double.Parse(dt.Rows[i]["%NG_allow"].ToString());
                        ListMQC.Add(MQC);                      
                    }
                }    
            }
            return ListMQC;
        }
    }
}