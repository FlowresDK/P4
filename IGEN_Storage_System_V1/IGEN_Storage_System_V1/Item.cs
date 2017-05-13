using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGEN_Storage_System_V1
{
    class Item
    {
        public int ItemID { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }
        public string Comment { get; set; }
        private int NumberOfPrints;
        private List<Item> SelectedItems; // List to be used with SelectItem-methods
        public List<Item> ListOfAllItems;//Just a test list, DO NOT retrieve all items from database. 

        public Item()
        {

        }

        public void RegisterItem()
        {

        }

        public void DeleteItem(List<Item> ItemsToDelete)
        {
            var sqlConn = new SqlConnection();
            foreach(var item in SelectedItems )
            {
                var itemID = item.ItemID;
                sqlConn.ExecuteSQL("DELETE FROM item WHERE itemID ="+ itemID );//Check query-string upon implementation
            }

            SelectedItems = null;//clears the list, so that it is ready for next usages.
        }

        public void SellItem()
        {

        }

        public void MoveItem()
        {

        }

        //
        //Method for adding/removing item to list with scanner - to be used when moving/discarding/selling items.
        //
        public void SelectItem(int choosenItemID)
        { 
            var itemToChoose = ListOfAllItems[ListOfAllItems.FindIndex(item => item.ItemID == choosenItemID)];//some SQL her instead
            if (!SelectedItems.Exists(item => item.ItemID == choosenItemID))
            {
                SelectedItems.Add(itemToChoose);
            }

            else
            {
                SelectedItems.RemoveAll(item => item.ItemID == choosenItemID);
            }

        }

        

    }
}
