using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SMESData
{
    class DatabaseUtils
    {
        public static SqlConnection GetSoftDBConnection()
        {
            string datasource = "172.16.0.12";
            string database = "ERPSOFT";
            string username = "ERPUSER";
            string password = "12345";
            return DatabaseSQLServerUtils.GetSoftDBConnection(datasource, database, username, password);
        }
    }
}
