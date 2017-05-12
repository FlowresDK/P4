using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGEN_Storage_System_V1
{
    class SqlConnection
    {

        private void ExecuteSQL(string query)
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
