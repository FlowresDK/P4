using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGEN_Storage_system_v2
{
    class Item
    {
        public int ItemID { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }
        public string Comment { get; set; }
        private int NumberOfPrints;

        List<Item> SelectedItemsList = new List<Item>(); // List to be used with SelectItem-methods
        BindingSource bs = new BindingSource();
       

        public void RegisterItem()
        {

        }

        public void DeleteItem(int userID)
        {
            foreach (var item in SelectedItemsList)
            {
                SqlConnector.ExecuteSQL("DELETE FROM item WHERE itemID = " + item.ItemID);//Cheeck query-string upon implementation
                SqlConnector.ExecuteSQL("INSERT INTO itemAction(Actiontype, State, UserID) VALUES(Item moved, Item discarded" + "," + userID);//Check query-string upon implementation
            }
            SelectedItemsList.Clear();//clears the list, so that it is ready for next usages.
        }

        public void SellItem()
        {

        }

        
        public void MoveItem(int locationID, int userID)
        {
            foreach (var item in SelectedItemsList)
            {
                SqlConnector.ExecuteSQL("UPDATE item SET location = " + locationID + "WHERE itemID = " + item.ItemID);//Check query-string upon implementation
                SqlConnector.ExecuteSQL("INSERT INTO itemAction(Actiontype, State, UserID) VALUES(Item moved," + locationID + "," + userID);//Check query-string upon implementation
            }

            SelectedItemsList.Clear();//clears the list, so that it is ready for next usages.
        }

        //
        //Method for adding/removing item to list with scanner - to be used when moving/discarding/selling items.
        //

        public List<Item> CheckSelectedItem(Item tempItem, List<Item> selectedItems)
        {
            int itemID = tempItem.ItemID;

            if (!selectedItems.Exists(item => item.ItemID == itemID))
            {
                selectedItems.Add(tempItem);
            }
            else
            {
                selectedItems.RemoveAll(item => item.ItemID == itemID);
            }
            return selectedItems;
        }
        
        //
        //Når der klikkes på move item-button kaldes først ShowDataGrid - der viser et tomt datagrid. Når der så klikkes på vælges/scannes_button et item kaldes ItemSelector
        //
        public void ItemSelector(object sender, EventArgs e)
        {
            var enteredItemID = 35; //det her skal være input fra scanner/keyboard

            var selectedItem = SqlConnector.RetrieveItem("SELECT * FROM item WHERE itemID =" + enteredItemID);

            SelectedItemsList = CheckSelectedItem(selectedItem, SelectedItemsList);

            ShowDataGridItems();
        }
        
         public void ShowDataGridItems()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            bs.DataSource = typeof(Item);

            foreach(var item in SelectedItemsList)
            {
                bs.Add(item);
            }

            dataGridView1.DataSource = bs;
            dataGridView1.AutoGenerateColumns = true;
        }
    }
}
