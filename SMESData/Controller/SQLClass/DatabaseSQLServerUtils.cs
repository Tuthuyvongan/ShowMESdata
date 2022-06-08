using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SMESData
{
    class DatabaseSQLServerUtils
    {
        public static SqlConnection GetSoftDBConnection(string datasource, string database, string username, string password)
        {
            string connectionString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
