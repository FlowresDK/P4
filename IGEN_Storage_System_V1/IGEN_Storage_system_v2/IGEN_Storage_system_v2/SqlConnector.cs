using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IGEN_Storage_system_v2
{

        public class SqlConnector

        {
            private static string serverIP = "localhost\\SQLEXPRESS";
            private static string database = "IGEN";
            private static string userID = "testuser";
            private static string password = "testuser";

            private static SqlConnection sqlConn = new SqlConnection("Server=" + serverIP + ";Database="
                + database + ";User id=" + userID + ";Password= " + password + ";");

            public static void ExecuteSQL(string query)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
        }
}
