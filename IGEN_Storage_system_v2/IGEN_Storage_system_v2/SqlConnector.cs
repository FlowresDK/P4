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
        
        public static List<User> RetrieveUsers(string query)
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataReader reader;
			User tempUser = null;
            List<User> userList = new List<User>();

			cmd.CommandType = CommandType.Text;
			cmd.CommandText = query;
			cmd.Connection = sqlConn;
			sqlConn.Open();
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
                //
                // Henter data fra DB og laver et object
                //
				int userID = Convert.ToInt32(reader["userID"].ToString());
                string firstName = reader["firstname"].ToString();
                string lastName = reader["lastname"].ToString();
                int phoneNumber = Convert.ToInt32(reader["phonenumber"].ToString());
                string mail = reader["mail"].ToString();
                string streetName = reader["streetname"].ToString();
                string cityName = reader["cityname"].ToString();
                int zipCode = Convert.ToInt32(reader["zipcode"].ToString()); 
                int role = Convert.ToInt32(reader["role"].ToString()); 
                int rights = Convert.ToInt32(reader["rights"].ToString());
                tempUser = new User(userID, firstName, lastName, phoneNumber, mail, streetName, cityName, zipCode, role, rights);
                userList.Add(tempUser);

                //
                // Tar' data fra object og viser det som "placeholder"
                //Dette kode skal nok være på panelet istedet på en eller anden måde.
                //
                TextboxNavnHer.Text = tempUser.UserID;
                TextboxNavnHer.Text = tempUser.FirstName;
                TextboxNavnHer.Text = tempUser.LastName;
                TextboxNavnHer.Text = tempUser.PhoneNumber;
                TextboxNavnHer.Text = tempUser.Mail;
                TextboxNavnHer.Text = tempUser.StreetName;
                TextboxNavnHer.Text = tempUser.CityName;
                TextboxNavnHer.Text = tempUser.ZipCode;
                TextboxNavnHer.Text = tempUser.Role;//her vil der bare blive vist et tal, så laves lidt lækkert der viser rolen bag tallet
                TextboxNavnHer.Text = tempUser.Rights;//same as above

			}
			sqlConn.Close();


            return userList;
		}
}
