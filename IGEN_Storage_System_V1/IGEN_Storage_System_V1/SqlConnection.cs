using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGEN_Storage_System_V1
{
    class SqlConnection
    {

        public void ExecuteSQL(string query)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = query;
			cmd.Connection = sqlConn;

			sqlConn.Open();
			cmd.ExecuteNonQuery();
			sqlConn.Close();
		}
	    
	 public Item RetrieveItem(string query)//To be done
	 {
	 		
		 
		 return item
	 }
	    
	 public User RetrieveItem(string query)//To be done
	 {
	 		
		 
		 return user
	 }
	    
	 public Giver RetrieveItem(string query)//To be done
	 {
	 		
		 
		 return giver
	 }
    }
}
