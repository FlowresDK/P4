using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IGEN_storage_system

{
	public class MangageItem
	{
		//Metode der opretter forbindelse til serveren
		static void SqlConnect()
		{

			//Forkortet version, men burde virke
			SqlConnection SqlConn = new SqlConnection("Server=localhost;" + "Database=IGEN;" + "User id=root;" + "Password=123456;");
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.Connection = SqlConn;

			//Version fra microsoft.com

			/*
			System.Data.SqlClient.SqlConnection SqlConn = new System.Data.SqlClient.SqlConnection("Server=localhost;" + "Database=IGEN;" + "User id=root;" + "Password=123456;");
			System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
			cmd.CommandType = System.Data.CommandType.Text;
			cmd.Connection = SqlConn;
			*/
		}

		//Metode der åbner/lukker forbindelsen til serveren, samt eksekverer sql-forespørgslen 
		static void ExecuteSql()
		{
			SqlConn.Open();
			cmd.ExecuteNonQuery();
			SqlConn.Close();
		}

		//Metode til registrering af varer
		static void RegisterItem()
		{
			Console.WriteLine("Enter category: (1 = Kids | 2 = Clothing and accessories | 3 = Furniture | 4 = Decoration" +
							  " | 5 = Crockery and kitchenware | 6 = Electronics | 7 = Entertainment | 8 = Misc)");
			var category = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter price: ");
			var price = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter giver ID: ");
			var giverID = Convert.ToInt32(Console.ReadLine());

			SqlConnect();
			cmd.CommandText = "INSERT INTO item (category, price, ID) VALUES ('" + category + "', '" + price + "','" + giverID + "', 1)";
			ExecuteSql();
		}

		//Metode til salg af varer (Endnu ikke implementeret)
		static void SellItem()
		{
			Console.WriteLine("Please scan or enter the barcode of the item: ");
			var barcode = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the price of the item: ");
			var price = Convert.ToInt32(Console.ReadLine());

			SqlConnect();
			cmd.CommandText = "UPDATE item SET (location, price) = (4,'" + price + "') WHERE barcode ='" + barcode + "'";
			ExecuteSql();
		}

		//Metode til flytning og sletning af varer
		static void ManageItem()
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
					SqlConnect();
					cmd.CommandText = "DELTE FROM item WHERE ID ='" + barcode + "'";
					ExecuteSql();
				}

				if (functionChoice < 3)
				{
					SqlConnect();
					cmd.CommandText = "UPDATE item SET location ='" + functionChoice + "' WHERE barcode ='" + barcode + "'";
					ExecuteSql();
				}
			}

			if (answer == "N" || answer == "n")
			{
				ManageItem();
			}
		}

		//Main-metoden, der starter programmet ved at præsentere tre valgmuligheder: registrer, sælg eller håndtér vare
		static void Main(string[] args)
		{
			Console.WriteLine("Choose function: (Register item = 1, Sell item = 2, Manage item = 3)");
			var chooseFunction = Convert.ToInt32(Console.ReadLine());

			if (chooseFunction == 1)
			{
				RegisterItem();
			}

			if (chooseFunction == 2)
			{
				SellItem();
			}

			if (chooseFunction == 3)
			{
				ManageItem();
			}

		}
	}
}
