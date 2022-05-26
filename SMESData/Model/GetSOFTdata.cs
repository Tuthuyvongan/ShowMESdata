using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace SMESData
{
    class GetSOFTdata

    {
        // Get OP data from LO1 - L07
        public static DataTable getOPData(/*string line, string remark, string date*/) // get all order to data grid view
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            //sqlGetData.Append("select SUM(Cast(data as numeric(10,0))) from m_ERPMQC_REALTIME where line = '" + line + "' and remark = '" + remark + "' and inspectdate = '" + date + "'");
            sqlGetData.Append("select SUM(CASE WHEN line = 'L01' and remark = 'OP' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L01, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L02' and remark = 'OP' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L02, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L03' and remark = 'OP' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L03, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L04' and remark = 'OP' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L04, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L05' and remark = 'OP' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L05, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L06' and remark = 'OP' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L06, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L07' and remark = 'OP' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L07 ");
            sqlGetData.Append("from m_ERPMQC_REALTIME");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
        // Get RW data from LO1 - L07
        public static DataTable getRWData(/*string line, string remark, string date*/) // get all order to data grid view
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            //sqlGetData.Append("select SUM(Cast(data as numeric(10,0))) from m_ERPMQC_REALTIME where line = '" + line + "' and remark = '" + remark + "' and inspectdate = '" + date + "'");
            sqlGetData.Append("select SUM(CASE WHEN line = 'L01' and remark = 'RW' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L01, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L02' and remark = 'RW' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L02, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L03' and remark = 'RW' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L03, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L04' and remark = 'RW' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L04, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L05' and remark = 'RW' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L05, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L06' and remark = 'RW' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L06, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L07' and remark = 'RW' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L07 ");
            sqlGetData.Append("from m_ERPMQC_REALTIME");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
        // Get NG data from LO1 - L07
        public static DataTable getNGData(/*string line, string remark, string date*/) // get all order to data grid view
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            //sqlGetData.Append("select SUM(Cast(data as numeric(10,0))) from m_ERPMQC_REALTIME where line = '" + line + "' and remark = '" + remark + "' and inspectdate = '" + date + "'");
            sqlGetData.Append("select SUM(CASE WHEN line = 'L01' and remark = 'NG' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L01, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L02' and remark = 'NG' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L02, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L03' and remark = 'NG' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L03, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L04' and remark = 'NG' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L04, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L05' and remark = 'NG' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L05, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L06' and remark = 'NG' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L06, ");
            sqlGetData.Append("SUM(CASE WHEN line = 'L07' and remark = 'NG' and inspectdate = '2022-05-25' THEN Cast(data as numeric(10,0)) END) AS Data_L07 ");
            sqlGetData.Append("from m_ERPMQC_REALTIME");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
        public static DataTable getTotalOP(/*string line, string remark, string date*/) // get all order to data grid view
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            //sqlGetData.Append("select SUM(Cast(data as numeric(10,0))) from m_ERPMQC_REALTIME where line = '" + line + "' and remark = '" + remark + "' and inspectdate = '" + date + "'");
            sqlGetData.Append("select serno ");
            sqlGetData.Append("from m_ERPMQC_REALTIME ");
            sqlGetData.Append("where remark = 'OP' ");
            sqlGetData.Append("and inspectdate = '2022-05-25'");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
        public static DataTable getTotalaRW(/*string line, string remark, string date*/) // get all order to data grid view
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            //sqlGetData.Append("select SUM(Cast(data as numeric(10,0))) from m_ERPMQC_REALTIME where line = '" + line + "' and remark = '" + remark + "' and inspectdate = '" + date + "'");
            sqlGetData.Append("select serno ");
            sqlGetData.Append("from m_ERPMQC_REALTIME ");
            sqlGetData.Append("where remark = 'RW' ");
            sqlGetData.Append("and inspectdate = '2022-05-25'");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
        public static DataTable getTotalNG(/*string line, string remark, string date*/) // get all order to data grid view
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            //sqlGetData.Append("select SUM(Cast(data as numeric(10,0))) from m_ERPMQC_REALTIME where line = '" + line + "' and remark = '" + remark + "' and inspectdate = '" + date + "'");
            sqlGetData.Append("select serno ");
            sqlGetData.Append("from m_ERPMQC_REALTIME ");
            sqlGetData.Append("where remark = 'NG' ");
            sqlGetData.Append("and inspectdate = '2022-05-25'");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
    }
}
