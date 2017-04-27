using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IGEN_storage_system
{
	public class ItemManager
	{
		private SqlConnection sqlConn;


		public ItemManager(string serverip, string database, string userID, string password)
		{
			sqlConn = new SqlConnection("Server=" + serverip + ";Database=" + database + ";User id=" + userID + ";Password= " + password + ";");
		}

		public void RegisterItem()
		{
			Console.WriteLine("Enter category: (1 = Kids | 2 = Clothing and accessories | 3 = Furniture | 4 = Decoration" +
							  " | 5 = Crockery and kitchenware | 6 = Electronics | 7 = Entertainment | 8 = Misc)");
			var category = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter price: ");
			var price = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter giver ID: ");
			var giverID = Convert.ToInt32(Console.ReadLine());

			ExecuteSQL("INSERT INTO item (category, price, ID) VALUES (" + category + ", " + price + "," + giverID + ", 1)");
		}

		public void SellItem()
		{
			Console.WriteLine("Please scan or enter the barcode of the item: ");
			var barcode = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the price of the item: ");
			var price = Convert.ToInt32(Console.ReadLine());

			ExecuteSQL("UPDATE item SET (location, price) = (4," + price + ") WHERE barcode =" + barcode + "");
		}

		public void ManageItem()
		{
			Console.WriteLine("Choose function: (Move item to storage = 1 | Move item to showroom = 2 | Delete item = 3)");
			var functionChoice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please scan or enter the barcode of the item: ");
			var barcode = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Are you sure you want to do this? Y = Yes / N = No");
			var answer = Convert.ToString(Console.ReadLine());
			if (answer == "Y" || answer == "y")
			{
				if (functionChoice == 3)
				{
					ExecuteSQL("DELETE FROM item WHERE ID =" + barcode + "");
				}
				if (functionChoice == 1 || functionChoice == 2)
				{
					ExecuteSQL("UPDATE item SET location =" + functionChoice + " WHERE barcode =" + barcode + "");
				}
			}
		}

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

	public class StorageSystemLauncher 
	{
		static void Main(string[] args)
		{
			ItemManager im = new ItemManager("localhost", "IGEN", "root", "123456");
			
			while (true)
			{
				Console.WriteLine("Choose function: (Register item = 1, Sell item = 2, Manage item = 3, Close program = 4)");
				var chooseFunction = Convert.ToInt32(Console.ReadLine());
			
				if (chooseFunction == 1)
				{
					im.RegisterItem();
				}
				else if (chooseFunction == 2)
				{
					im.SellItem();
				}
				else if (chooseFunction == 3)
				{
					im.ManageItem();
				}
				else if (chooseFunction == 4)
				{
					break;
				}
				else
				{
					Console.WriteLine("Wrong input");
				}
			}
		}
	}
}