﻿
using MySqlConnector;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DatabaseSQLServerUtils
    {
        public static SqlConnection GetSoftDBConnection(string datasource, string database, string username, string password)
        {
            string connectionString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
        public static MySqlConnection GetMesDBConnection(string host, string user, string password)
        {
            string connectionString = string.Format("host={0};user={1};password={2};", host, user, password);
            MySqlConnection con = new MySqlConnection(connectionString);
            return con;
        }
    }
}
