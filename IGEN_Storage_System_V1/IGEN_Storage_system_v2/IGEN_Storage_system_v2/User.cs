using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGEN_Storage_system_v2
{
    class User
    {

        public int ItemID { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }
        public string Comment { get; set; }
        private int NumberOfPrints;

        public List<Item> SelectedItems{ get; set; } // List to be used with SelectItem-methods
        public List<Item> ListOfAllItems;//Just a test list, DO NOT retrieve all items from database. 

        public void RegisterItem()

        {
        }

        public void DeleteItem(int userID)
        {
            foreach (var item in SelectedItems)
            {               
                SqlConnector.ExecuteSQL("DELETE FROM item WHERE itemID = " + item.ItemID);//Cheeck query-string upon implementation
                SqlConnector.ExecuteSQL("INSERT INTO itemAction(Actiontype, State, UserID) VALUES(Item moved, Item discarded" + "," + userID);//Check query-string upon implementation
	        }

            SelectedItems = null;//clears the list, so that it is ready for next usages.
        }

        public void SellItem()
        {

        }

        public void MoveItem(int locationID, int userID)

        {
	    foreach (var item in SelectedItems)

            { 
                SqlConnector.ExecuteSQL("UPDATE item SET location = " +  locationID + "WHERE itemID = " + item.ItemID);//Check query-string upon implementation
                SqlConnector.ExecuteSQL("INSERT INTO itemAction(Actiontype, State, UserID) VALUES(Item moved," + locationID + "," + userID);//Check query-string upon implementation                	
	        }

	    SelectedItems = null;//clears the list, so that it is ready for next usages.
	    }

        //

        //Method for adding/removing item to list with scanner - to be used when moving/discarding/selling items.

        //

        public void SelectItem(int choosenItemID)

        {             
            var itemToChoose = ListOfAllItems[ListOfAllItems.FindIndex(item => item.ItemID == choosenItemID)];//some SQL her instead
            //perhaps var itemToChoose = SqlConn(SELECT * FROM item WHERE itemID = choosenItemID)

            if (!SelectedItems.Exists(item => item.ItemID == choosenItemID))
            {
		    //SQL query here SELECT ..... itemId
                SelectedItems.Add(itemToChoose);
            }

            else

            {
                SelectedItems.RemoveAll(item => item.ItemID == choosenItemID);
            }

        }
    }
}
