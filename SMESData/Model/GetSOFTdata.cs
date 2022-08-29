using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Linq;

namespace WindowsFormsApplication1
{
    class GetSOFTdata
    {
        //total data in every line
        public static double getTotalMQC(string line, string date)
        { 
            double s = 0;
            DataTable dt = new DataTable();
            DataRow []rs = SaveData.dtTemp5.Select("Line = '" + line + "' and Date = '" + Convert.ToDateTime(date).ToString("dd-MM-yyyy") + "'");
            if (rs.Length > 0)
            {
                dt = rs.CopyToDataTable();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    s = s + double.Parse(dt.Rows[i]["Total"].ToString()); 
                }
            }
            else
            {
                s = 0;
            }
            return s;
        }
        // NG, RW, OP data of MQC in every line in date
        public static double getTotalRemark(string line, string remark, string date)
        {
            if (date != SaveData.Date2 || date != SaveData.Date1)
                SaveData.dtTemp5 = GetListMQC(date, "");
            double s = 0;
            DataTable dt = new DataTable();
            DataRow[] rs = SaveData.dtTemp5.Select("Line = '" + line + "' and Date = '" + Convert.ToDateTime(date).ToString("dd-MM-yyyy") + "'");
            if (rs.Length > 0)
            {
                dt = rs.CopyToDataTable();
                for (int i = 0; i < dt.Rows.Count; i ++)
                {
                    s = s + double.Parse(dt.Rows[i][remark].ToString());
                }    
            }   
            else
            {
                s = 0;
            }    
            return s;
        }
        // total data of PQC in every line in date
        public static double getTotalPQC(string line, string date)
        {
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            double s;
            string temp;
            sqlGetData.Append("select SUM(CASE WHEN Line = '" + line + "' and InspectDateTime like '%" + date + "%' THEN Cast(Quantity as numeric(10,0)) END) ");
            sqlGetData.Append("from ProcessHistory.PQCMesData");
            temp = sqlSOFTCon.sqlExecuteScalarString(sqlGetData.ToString());
            s = double.Parse(temp);
            return s;
        }
        // NG, RW, OP data of PQC in every line in date
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
        //Get Model in table NGRate
        public static DataTable GetModel(string date)
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            if (SaveData.PQC == true)
            {
                sqlGetData.Append("select distinct Model from thu_SMESData_NGRate_PQC ");
                sqlGetData.Append("where Date = '" + date + "'");
                sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            }  
            else
            {
                sqlGetData.Append("select distinct model from thu_SMESData_NGRate ");
                sqlGetData.Append("where inspectdate = '" + date + "'");
                sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            }                
            return dt;
        }
        //List MQC from MySQL
        public static DataTable ListMQC1(string date)
        {
            SaveData.Date1 = date;
            DataTable dt1 = new DataTable();
            sqlMES sqlMESCon = new sqlMES();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("SELECT DISTINCT c.uuid as UUID, a.product_no as Model, a.send_quantity as Total, a.pass_qty as OUTPUT, a.failed_qty as NOGOOD, a.send_time as Date ");
            sqlGetData.Append("FROM mes_quality_control.quality_control_order AS a, mes_planning_excution.job_move AS b, mes_planning_excution.job_order_record AS c ");
            sqlGetData.Append("WHERE a.job_move_uuid = b.uuid AND b.job_order_uuid = c.job_order_uuid AND b.product_lot_no = c.product_lot_no ");
            sqlGetData.Append("AND TIMESTAMPDIFF(SECOND, c.update_date, b.create_date) < 5 AND TIMESTAMPDIFF(SECOND, c.update_date, b.create_date) >= 0 ");
            sqlGetData.Append("AND a.send_quantity = c.actual_finish_qty AND b.create_by = c.create_by AND a.delete_flag = 0 AND b.delete_flag = 0 AND c.delete_flag = 0 ");
            sqlGetData.Append("AND a.send_time LIKE '%" + date + "%' AND a.operation_no = 'OP10' AND a.send_quantity IS NOT NULL ");
            sqlGetData.Append("ORDER BY a.product_no ");
            sqlMESCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt1);
            if (dt1.Rows.Count > 0)
            {
                SaveData.checknull = false;
            }
            else
                SaveData.checknull = true;
            return dt1;
        }
        //List MQC from SQL Sever
        public static DataTable ListMQC2(string date, string line)
        {
            SaveData.Date2 = date;
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("select distinct serno, m.line as Line, ");
            sqlGetData.Append("(CASE WHEN (select top 1 rate from thu_SMESData_NGRate where model = a.model order by inspectdate desc) IS NOT NULL ");
            sqlGetData.Append("THEN (select top 1 rate from thu_SMESData_NGRate where model = a.model order by inspectdate desc) ");
            sqlGetData.Append("ELSE '2' END) as '%NG_allow', ");
            sqlGetData.Append("(CASE WHEN (select OUTPUT from thu_MQC_DailyTarget where model = a.model and Date = a.inspectdate) IS NOT NULL ");
            sqlGetData.Append("THEN (select OUTPUT from thu_MQC_DailyTarget where model = a.model and Date = a.inspectdate) ELSE '0' END) as DailyTarget, m.model as Model, m.inspectdate as Date ");
            sqlGetData.Append("FROM m_ERPMQC_REALTIME as a ");
            sqlGetData.Append("LEFT JOIN thu_SMESData_NGRate as r on a.model = r.model and a.inspectdate = r.inspectdate ");
            sqlGetData.Append("join(SELECT model, inspectdate, line ");
            sqlGetData.Append("FROM m_ERPMQC_REALTIME ");
            sqlGetData.Append("WHERE inspectdate like '%" + Convert.ToDateTime(date).ToString("yyyy-MM") + "%' AND line like '%" + line + "%'");
            sqlGetData.Append("group by model, inspectdate, line) as m ");
            sqlGetData.Append("on a.inspectdate = m.inspectdate and a.model = m.model and a.line = m.line ");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
        //List MQC after merge
        public static DataTable GetListMQC(string date, string line)
        {
            DataTable dt1 = new DataTable();
            DataTable dt = new DataTable();
            if (SaveData.Date1 != date || SaveData.Date2 != date)
            {
                SaveData.dtTemp3 = ListMQC1(date);
                SaveData.dtTemp4 = ListMQC2(date, "");
                dt1 = SaveData.dtTemp3;
                dt = SaveData.dtTemp4;
            }    
            else
            {
                dt1 = SaveData.dtTemp3;
                dt = SaveData.dtTemp4;
            }    
            
            double fail = -1;
            List<ListMQC> ListMQC = new List<ListMQC>();
            ListMQC MQC = new ListMQC();
            MQC.OUTPUT = 0;
            MQC.NOGOOD = 0;
            MessageWaitForm msf = new MessageWaitForm();
            Thread backgroundThreadFetchData = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            MQC.Model = dt1.Rows[i]["Model"].ToString();
                            //MQC.Date = Convert.ToDateTime(date).ToString("dd-MM-yyyy");
                            MQC.Date = Convert.ToDateTime(dt1.Rows[i]["Date"].ToString()).ToString("dd-MM-yyyy HH:mm:ss");
                            string uuid = dt1.Rows[i]["UUID"].ToString();
                            DataRow[] result = dt.Select("serno like '%" + uuid + "%'");
                            DataRow[] resultTemp = dt.Select("Model like '%" + MQC.Model + "%' and Date = '" + date + "'");
                            if (resultTemp.Length > 0)
                                MQC.DailyTarget = double.Parse(resultTemp[0][3].ToString());
                            else
                            {
                                if (result.Length > 0)
                                    MQC.DailyTarget = double.Parse(result[0][3].ToString());
                                else
                                    MQC.DailyTarget = 0;
                            }
                            if (result.Length > 0)
                            {
                                MQC.NG_rate_allow = double.Parse(result[0][2].ToString());
                                MQC.Line = result[0][1].ToString();
                            }
                            else
                            {
                                if (resultTemp.Length > 0)
                                {
                                    MQC.NG_rate_allow = double.Parse(resultTemp[0][2].ToString());
                                    MQC.Line = resultTemp[0][1].ToString();
                                }
                                else
                                {
                                    MQC.NG_rate_allow = 2;
                                    MQC.Line = "L02";
                                }
                            }
                            if (double.TryParse(dt1.Rows[i]["NOGOOD"].ToString(), out fail))
                                MQC.NOGOOD = double.Parse(dt1.Rows[i]["NOGOOD"].ToString());
                            else
                                MQC.NOGOOD = 0;
                            if (double.TryParse(dt1.Rows[i]["OUTPUT"].ToString(), out fail))
                                MQC.OUTPUT = double.Parse(dt1.Rows[i]["OUTPUT"].ToString());
                            else
                                MQC.OUTPUT = 0;
                            MQC.REWORK = 0;
                            MQC.Total = double.Parse(dt1.Rows[i]["Total"].ToString());
                            MQC.NG_rate_realtime = Math.Round(MQC.NOGOOD / MQC.Total * 100, 1);
                            ListMQC.Add(MQC);
                            MQC = new ListMQC();
                            msf.UpdateProgress(100 * (i + 1) / dt1.Rows.Count, "Application is running, please wait ... ");
                        }
                        msf.BeginInvoke(new Action(() => msf.Close()));
                    }));
            if (dt1.Rows.Count > 0)
            {
                backgroundThreadFetchData.Start();
                msf.ShowDialog();
            }
            SaveData.dtTemp6 = new DataTable();
            DataTable dtMQC = new DataTable();
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
                    new DataColumn()
                    {
                        ColumnName="Line",
                        DataType=typeof(string),
                    },
                    new DataColumn()
                    {
                        ColumnName="OUTPUT",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="REWORK",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="NOGOOD",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="Total",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="DailyTarget",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="NG_rate_realtime",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="NG_rate_allow",
                        DataType=typeof(double),
                    }
            };
            DataColumn[] tableColumns1 = new DataColumn[]
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
                    new DataColumn()
                    {
                        ColumnName="Line",
                        DataType=typeof(string),
                    },
                    new DataColumn()
                    {
                        ColumnName="OUTPUT",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="REWORK",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="NOGOOD",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="Total",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="DailyTarget",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="NG_rate_realtime",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="NG_rate_allow",
                        DataType=typeof(double),
                    }
            };
            dtMQC.Columns.AddRange(tableColumns);
            SaveData.dtTemp6.Columns.AddRange(tableColumns1);
            foreach (var data in ListMQC)
            {
                dtMQC.Rows.Add(data.Model, data.Date, data.Line, data.OUTPUT, data.REWORK, data.NOGOOD, data.Total, data.DailyTarget, data.NG_rate_realtime, data.NG_rate_allow);
                SaveData.dtTemp6.Rows.Add(data.Model, data.Date, data.Line, data.OUTPUT, data.REWORK, data.NOGOOD, data.Total, data.DailyTarget, data.NG_rate_realtime, data.NG_rate_allow);
            }
            dtMQC.DefaultView.Sort = "Model, Line";
            dtMQC = dtMQC.DefaultView.ToTable();
            for (int i = 0; i < dtMQC.Rows.Count; i++)
            {
                dtMQC.Rows[i]["Date"] = Convert.ToDateTime(date).ToString("dd-MM-yyyy");
                if (dtMQC.Rows.Count == 1)
                {
                }
                else
                {
                    if (i + 1 != dtMQC.Rows.Count)
                    {
                        if (dtMQC.Rows[i]["Model"].ToString() == dtMQC.Rows[i + 1]["Model"].ToString() && dtMQC.Rows[i]["Line"].ToString() == dtMQC.Rows[i + 1]["Line"].ToString())
                        {
                            dtMQC.Rows[i]["OUTPUT"] = (double.Parse(dtMQC.Rows[i]["OUTPUT"].ToString()) + double.Parse(dtMQC.Rows[i + 1]["OUTPUT"].ToString())).ToString();
                            dtMQC.Rows[i]["NOGOOD"] = (double.Parse(dtMQC.Rows[i]["NOGOOD"].ToString()) + double.Parse(dtMQC.Rows[i + 1]["NOGOOD"].ToString())).ToString();
                            dtMQC.Rows[i]["Total"] = (double.Parse(dtMQC.Rows[i]["Total"].ToString()) + double.Parse(dtMQC.Rows[i + 1]["Total"].ToString())).ToString();
                            dtMQC.Rows[i + 1].Delete();
                            dtMQC.AcceptChanges();
                            i--;
                        }
                        else
                        {
                            dtMQC.Rows[i]["NG_rate_realtime"] = Math.Round(double.Parse(dtMQC.Rows[i]["NOGOOD"].ToString()) / double.Parse(dtMQC.Rows[i]["Total"].ToString()) * 100, 1).ToString();
                        }
                    }
                    else
                    {

                    }
                }
            }
            DataTable rsMQC;
            SaveData.dtTemp5 = new DataTable();
            SaveData.dtTemp5 = dtMQC;
            if (dtMQC.Rows.Count > 0)
            {
                DataRow[] rs = dtMQC.Select("Line like '%" + line + "%'");
                if (rs.Length > 0)
                {
                    rsMQC = rs.CopyToDataTable();
                    rsMQC.DefaultView.Sort = "NG_rate_realtime DESC";
                    rsMQC = rsMQC.DefaultView.ToTable();
                    SaveData.checknull = false;
                    return rsMQC;
                } 
                else
                {
                    MessageBox.Show("No data in this line");
                    return dtMQC;
                }    
            }
            else
            {
                SaveData.checknull = true;
                return dtMQC;
            }
        }
        //List PQC
        public static DataTable GetListPQC(string date, string line)
        {
            List<ListPQC> ListPQC = new List<ListPQC>();
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("select distinct m.Model, m.Date, m.line as Line, m.OUTPUT, m.REWORK, m.NOGOOD, ");
            sqlGetData.Append("(CASE WHEN (select top 1 rate from thu_SMESData_NGRate_PQC where Model = a.Model order by Date desc) IS NOT NULL ");
            sqlGetData.Append("THEN (select top 1 rate from thu_SMESData_NGRate_PQC where Model = a.Model order by Date desc) ELSE '2' END) as '%NG_allow', POCode, '2.5' as '%RW_allow' ");
            sqlGetData.Append("FROM ProcessHistory.PQCMesData as a ");
            sqlGetData.Append("LEFT JOIN thu_SMESData_NGRate_PQC as r on a.Model = r.Model and CAST(a.InspectDateTime as Date) = r.Date ");
            sqlGetData.Append("join(SELECT Model, CAST(InspectDateTime as Date) as Date, line, ");
            sqlGetData.Append("COALESCE(SUM(CASE WHEN AttributeType = 'OP' THEN Cast(Quantity as numeric(10,0)) END), 0) AS OUTPUT, ");
            sqlGetData.Append("COALESCE(SUM(CASE WHEN AttributeType = 'RW' THEN Cast(Quantity as numeric(10,0)) END), 0) AS REWORK, ");
            sqlGetData.Append("COALESCE(SUM(CASE WHEN AttributeType = 'NG' THEN Cast(Quantity as numeric(10,0)) END), 0) AS NOGOOD ");
            sqlGetData.Append("FROM ProcessHistory.PQCMesData ");
            sqlGetData.Append("WHERE InspectDateTime like '%" + date + "%' and line like '%" + line + "%' ");
            sqlGetData.Append("group by Model, line, CAST(InspectDateTime as Date)) as m ");
            sqlGetData.Append("on CAST(a.InspectDateTime as Date) = m.Date and a.Model = M.model and a.line = m.line ");
            //Do not change this sort for correcting logic in for loop. Model have same name and diffrent line will stand side by side
            sqlGetData.Append("order by Model desc, Line");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            ListPQC PQC = new ListPQC();
            PQC.Target = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows.Count == 1)
                {
                    string[] POCode = dt.Rows[i]["POCode"].ToString().Split(';');
                    PQC.Target = PQC.Target + double.Parse(POCode[4]);
                    PQC.Model = dt.Rows[i]["Model"].ToString();
                    PQC.Date = Convert.ToDateTime(dt.Rows[i]["Date"]).ToString("dd-MM-yyyy");
                    PQC.Line = dt.Rows[i]["Line"].ToString();
                    PQC.OUTPUT = double.Parse(dt.Rows[i]["OUTPUT"].ToString());
                    PQC.REWORK = double.Parse(dt.Rows[i]["REWORK"].ToString());
                    PQC.NOGOOD = double.Parse(dt.Rows[i]["NOGOOD"].ToString());
                    PQC.Total = PQC.OUTPUT + PQC.REWORK + PQC.NOGOOD;
                    PQC.NG_rate_realtime = Math.Round(PQC.NOGOOD / PQC.Total * 100, 1);
                    PQC.NG_rate_allow = double.Parse(dt.Rows[i]["%NG_allow"].ToString());
                    PQC.RW_rate_realtime = Math.Round(PQC.REWORK / PQC.Total * 100, 1);
                    PQC.RW_rate_allow = double.Parse(dt.Rows[i]["%RW_allow"].ToString());
                    ListPQC.Add(PQC);
                }
                else
                {
                    if (i + 1 != dt.Rows.Count)
                    {
                        if (dt.Rows[i]["Model"].ToString() == dt.Rows[i + 1]["Model"].ToString() && dt.Rows[i]["Line"].ToString() == dt.Rows[i + 1]["Line"].ToString())
                        {
                            string[] POCode = dt.Rows[i]["POCode"].ToString().Split(';');
                            string[] POCode1 = dt.Rows[i + 1]["POCode"].ToString().Split(';');
                            if (POCode[3] != POCode1[3])
                                PQC.Target = PQC.Target + double.Parse(POCode[4]);
                        }
                        else
                        {
                            string[] POCode = dt.Rows[i]["POCode"].ToString().Split(';');
                            PQC.Target = PQC.Target + double.Parse(POCode[4]);
                            PQC.Model = dt.Rows[i]["Model"].ToString();
                            PQC.Date = Convert.ToDateTime(dt.Rows[i]["Date"]).ToString("dd-MM-yyyy");
                            PQC.Line = dt.Rows[i]["Line"].ToString();
                            PQC.OUTPUT = double.Parse(dt.Rows[i]["OUTPUT"].ToString());
                            PQC.REWORK = double.Parse(dt.Rows[i]["REWORK"].ToString());
                            PQC.NOGOOD = double.Parse(dt.Rows[i]["NOGOOD"].ToString());
                            PQC.Total = PQC.OUTPUT + PQC.REWORK + PQC.NOGOOD;
                            PQC.NG_rate_realtime = Math.Round(PQC.NOGOOD / PQC.Total * 100, 1);
                            PQC.NG_rate_allow = double.Parse(dt.Rows[i]["%NG_allow"].ToString());
                            PQC.RW_rate_realtime = Math.Round(PQC.REWORK / PQC.Total * 100, 1);
                            PQC.RW_rate_allow = double.Parse(dt.Rows[i]["%RW_allow"].ToString());
                            ListPQC.Add(PQC);
                            PQC = new ListPQC();
                            PQC.Target = 0;
                        }
                    }
                    else
                    {
                        if (dt.Rows[i - 1]["Model"].ToString() == dt.Rows[i]["Model"].ToString() && dt.Rows[i - 1]["Line"].ToString() == dt.Rows[i]["Line"].ToString())
                        {
                            string[] POCode = dt.Rows[i - 1]["POCode"].ToString().Split(';');
                            string[] POCode1 = dt.Rows[i]["POCode"].ToString().Split(';');
                            if (POCode[3] != POCode1[3])
                                PQC.Target = PQC.Target + double.Parse(POCode1[4]);
                            PQC.Model = dt.Rows[i]["Model"].ToString();
                            PQC.Date = Convert.ToDateTime(dt.Rows[i]["Date"]).ToString("dd-MM-yyyy");
                            PQC.Line = dt.Rows[i]["Line"].ToString();
                            PQC.OUTPUT = double.Parse(dt.Rows[i]["OUTPUT"].ToString());
                            PQC.REWORK = double.Parse(dt.Rows[i]["REWORK"].ToString());
                            PQC.NOGOOD = double.Parse(dt.Rows[i]["NOGOOD"].ToString());
                            PQC.Total = PQC.OUTPUT + PQC.REWORK + PQC.NOGOOD;
                            PQC.NG_rate_realtime = Math.Round(PQC.NOGOOD / PQC.Total * 100, 1);
                            PQC.NG_rate_allow = double.Parse(dt.Rows[i]["%NG_allow"].ToString());
                            PQC.RW_rate_realtime = Math.Round(PQC.REWORK / PQC.Total * 100, 1);
                            PQC.RW_rate_allow = double.Parse(dt.Rows[i]["%RW_allow"].ToString());
                            ListPQC.Add(PQC);
                        }
                        else
                        {
                            string[] POCode = dt.Rows[i]["POCode"].ToString().Split(';');
                            PQC.Target = PQC.Target + double.Parse(POCode[4]);
                            PQC.Model = dt.Rows[i]["Model"].ToString();
                            PQC.Date = Convert.ToDateTime(dt.Rows[i]["Date"]).ToString("dd-MM-yyyy");
                            PQC.Line = dt.Rows[i]["Line"].ToString();
                            PQC.OUTPUT = double.Parse(dt.Rows[i]["OUTPUT"].ToString());
                            PQC.REWORK = double.Parse(dt.Rows[i]["REWORK"].ToString());
                            PQC.NOGOOD = double.Parse(dt.Rows[i]["NOGOOD"].ToString());
                            PQC.Total = PQC.OUTPUT + PQC.REWORK + PQC.NOGOOD;
                            PQC.NG_rate_realtime = Math.Round(PQC.NOGOOD / PQC.Total * 100, 1);
                            PQC.NG_rate_allow = double.Parse(dt.Rows[i]["%NG_allow"].ToString());
                            PQC.RW_rate_realtime = Math.Round(PQC.REWORK / PQC.Total * 100, 1);
                            PQC.RW_rate_allow = double.Parse(dt.Rows[i]["%RW_allow"].ToString());
                            ListPQC.Add(PQC);
                        }
                    }
                }
            }
            DataTable dtPQC = new DataTable();
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
                new DataColumn()
                {
                    ColumnName="Line",
                    DataType=typeof(string),
                },
                new DataColumn()
                {
                    ColumnName="OUTPUT",
                    DataType=typeof(double),
                },
                new DataColumn()
                {
                    ColumnName="REWORK",
                    DataType=typeof(double),
                },
                new DataColumn()
                {
                    ColumnName="NOGOOD",
                    DataType=typeof(double),
                },
                new DataColumn()
                {
                    ColumnName="Total",
                    DataType=typeof(double),
                },
                new DataColumn()
                {
                    ColumnName="Target",
                    DataType=typeof(double),
                },
                new DataColumn()
                {
                    ColumnName="NG_rate_realtime",
                    DataType=typeof(double),
                },
                new DataColumn()
                {
                    ColumnName="NG_rate_allow",
                    DataType=typeof(double),
                },
                new DataColumn()
                {
                    ColumnName="RW_rate_realtime",
                    DataType=typeof(double),
                },
                new DataColumn()
                {
                    ColumnName="RW_rate_allow",
                    DataType=typeof(double),
                }
            };
            dtPQC.Columns.AddRange(tableColumns);
            foreach (var data in ListPQC)
            {
                dtPQC.Rows.Add(data.Model, data.Date, data.Line, data.OUTPUT, data.REWORK, data.NOGOOD, data.Total, data.Target, data.NG_rate_realtime, data.NG_rate_allow, data.RW_rate_realtime, data.RW_rate_allow);
            }
            dtPQC.DefaultView.Sort = "NG_rate_realtime DESC";
            dtPQC = dtPQC.DefaultView.ToTable();
            return dtPQC;
            if (dtPQC.Rows.Count > 0)
            {
                SaveData.checknullPQC = false;
            }
            else
                SaveData.checknullPQC = true;
        }
        //Get Info of product
        public static DataTable GetInfo(string model, string line, string date)
        {

            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();

            if (SaveData.PQC == true)
            {
                DataColumn[] tableColumns = new DataColumn[]
{
                new DataColumn()
                {
                    ColumnName="Model",
                    DataType=typeof(string),
                },
                new DataColumn()
                {
                    ColumnName="LotNumber",
                    DataType=typeof(string),
                },
                new DataColumn()
                {
                    ColumnName="Line",
                    DataType=typeof(string),
                },
                new DataColumn()
                {
                    ColumnName="Date",
                    DataType=typeof(string),
                },
                new DataColumn()
                {
                    ColumnName="Time",
                    DataType=typeof(string),
                },
                new DataColumn()
                {
                    ColumnName="DateTime",
                    DataType=typeof(string),
                }
};
                dt.Columns.AddRange(tableColumns);
                sqlGetData.Append("SELECT Model, LotNumber, Line, InspectDateTime as DateTime, Quantity, Inspector, AttributeType as Remark, POCode as Serno FROM ProcessHistory.PQCMesData ");
                sqlGetData.Append("where Model = '" + model + "' and Line = '" + line + "' and InspectDateTime like '%" + date + "%'");
                sqlGetData.Append("order by InspectDateTime desc, AttributeType");
                sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string DtIn = Convert.ToDateTime(dt.Rows[i]["DateTime"]).ToString("dd-MM-yyyy HH:mm:ss");
                    dt.Rows[i]["DateTime"] = DtIn;
                }
            }
            else
            {
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
                    new DataColumn()
                    {
                        ColumnName="Line",
                        DataType=typeof(string),
                    },
                    new DataColumn()
                    {
                        ColumnName="OUTPUT",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="REWORK",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="NOGOOD",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="Total",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="DailyTarget",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="NG_rate_realtime",
                        DataType=typeof(double),
                    },
                    new DataColumn()
                    {
                        ColumnName="NG_rate_allow",
                        DataType=typeof(double),
                    }
            };
                dt.Columns.AddRange(tableColumns);
                DataRow[] rs;
                if (SaveData.dtTemp6 != null)
                {
                    rs = SaveData.dtTemp6.Select("Model = '" + model + "' and Line = '" + line + "'");
                    if (rs.Length > 0)
                        dt = rs.CopyToDataTable();
                }         
            }
            return dt;
        }
        //Get all model in table m_ERPMQC_REALTIME
        public static DataTable getAllModel()
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            if (SaveData.PQC == true)
            {
                sqlGetData.Append("SELECT distinct Model FROM ProcessHistory.PQCMesData where Model != ''");
                sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            }
            else
            {
                sqlGetData.Append("SELECT distinct model FROM m_ERPMQC_REALTIME where model != ''");
                sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            }
            return dt;
        }
    }
}