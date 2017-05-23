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
        private static string database = "igen_data_test2";
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


        public static User RetrieveUsers(string query)

        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            User tempUser = null;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = sqlConn;
            sqlConn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int userID = Convert.ToInt32(reader["user_id"].ToString());
                string firstName = reader["first_name"].ToString();
                string lastName = reader["last_name"].ToString();
                int phoneNumber = Convert.ToInt32(reader["phone_num"].ToString());
                string mail = reader["mail"].ToString();
                string streetName = reader["street_name"].ToString();
                string cityName = reader["city"].ToString();
                int zipCode = Convert.ToInt32(reader["zip_code"].ToString());
                int rights = Convert.ToInt32(reader["rights"].ToString());
                int role = Convert.ToInt32(reader["role_id"].ToString());
                
                tempUser = new User(userID, firstName, lastName, phoneNumber, mail, streetName, cityName, zipCode, rights, role);
            }

            sqlConn.Close();
            return tempUser;

        }

        public static Giver RetrieveGivers(string query)

        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            Giver tempGiver = null;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = sqlConn;
            sqlConn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int giverID = Convert.ToInt32(reader["giver_id"].ToString());
                string firstName = reader["first_name"].ToString();
                string lastName = reader["last_name"].ToString();
                int phoneNumber = Convert.ToInt32(reader["phone_num"].ToString());
                string mail = reader["mail"].ToString();
                string streetName = reader["street_name"].ToString();
                string cityName = reader["city"].ToString();
                int zipCode = Convert.ToInt32(reader["zip_code"].ToString());
                DateTime pickUpDate = DateTime.Parse(reader["pickup_Date"].ToString());
                DateTime pickUpTime = DateTime.Parse(reader["pickup_Time"].ToString());
                string pickUpComment = reader["comment"].ToString();
                tempGiver = new Giver(giverID, firstName, lastName, phoneNumber, mail, streetName,
            cityName, zipCode, pickUpDate, pickUpTime, pickUpComment);
            }

            sqlConn.Close();
            return tempGiver;

        }

        public static Item RetrieveItem(string query)

        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            Item tempItem = null;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = sqlConn;
            sqlConn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int itemID = Convert.ToInt32(reader["item_id"].ToString());
                int category = Convert.ToInt32(reader["category_id"].ToString());
                int price = Convert.ToInt32(reader["price"].ToString());
                int giverID = Convert.ToInt32(reader["giver_id"].ToString());

                tempItem = new Item(itemID, category, price, giverID);
            }
            sqlConn.Close();
            return tempItem;
        }

        public static List<Tax> RetrieveTax(string query)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            Tax tempTax = null;
            List<Tax> taxList = new List<Tax>();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = sqlConn;
            sqlConn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int taxID = Convert.ToInt32(reader["taxID"].ToString());
                int giverID = Convert.ToInt32(reader["giverID"].ToString());
                int itemID = Convert.ToInt32(reader["itemID"].ToString());
                int taxState = Convert.ToInt32(reader["taxState"].ToString());
                tempTax = new Tax(taxID, giverID, itemID, taxState);
                taxList.Add(tempTax);
            }
            sqlConn.Close();

            return taxList;
        }

    }
}
