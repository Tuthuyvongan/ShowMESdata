using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMESData
{
    public class sqlSOFTCon
    {
        public SqlConnection conn = DatabaseUtils.GetSoftDBConnection();

        public string sqlExecuteScalarString(string sql)
        {
            string outstring;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                outstring = cmd.ExecuteScalar().ToString();
                conn.Close();
                return outstring;
            }
            catch (Exception)
            {
                conn.Close();
               
                return string.Empty;
            }
        }
        public void sqlDataAdapterFillDatatable(string sql, ref DataTable dt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();
                {
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                }
            }
            catch (Exception)
            {
                
            }
        }

        public bool sqlExecuteNonQuery(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                int response = cmd.ExecuteNonQuery();
                if (response >= 1)
                {                    
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception)
            {
               
                conn.Close();
                return false;
            }
        }
    }
}
