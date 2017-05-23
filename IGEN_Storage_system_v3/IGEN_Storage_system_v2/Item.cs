using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace IGEN_Storage_system_v2
{
    public class Item
    {
        public int ItemID { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }
        public string Comment { get; set; }
        public int GiverID { get; set; }
        public bool isCashRegister { get; set; }

        public List<Item> SelectedItemsList = new List<Item>();
        BindingSource bs = new BindingSource();
       // UserInterface uif = new UserInterface();

        public Item()
        {

        }

        public Item(int itemID, int category, int price, int giverID)
        {
            ItemID = itemID;
            Category = category;
            Price = price;
            GiverID = giverID;
        }

        public Item(int itemID, int category, int price)
        {
            ItemID = itemID;
            Category = category;
            Price = price;
        }

        public void DeleteItem()
        {
            foreach (var item in SelectedItemsList)
            {
                SqlConnector.ExecuteSQL("DELETE FROM item WHERE itemID = " + item.ItemID);
                //SqlConnector.ExecuteSQL("INSERT INTO itemAction(Actiontype, State, UserID) VALUES(Item moved, Item discarded" + "," + uif.UserID);
            }

            SelectedItemsList.Clear();
        }

        public void SellItem(DataGridView dataGrid)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    var itemID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    var category = Convert.ToInt32(row.Cells[1].Value.ToString());
                    var giverID = Convert.ToInt32(row.Cells[4].Value.ToString());
                    var price = Convert.ToInt32(row.Cells[2].Value.ToString());

                    if (price >= 500 && giverID == 0)
                    {
                        var userInput = Interaction.InputBox("Meta kommunikation her");

                        if (userInput != "")
                        {
                            giverID = Convert.ToInt32(userInput);
                        }
                    }

                    if (price >= 500 && giverID != 0)
                    {
                        MessageBox.Show("Her bliver tax kaldt");
                        //Tax-metode kaldes her
                    }

                    MessageBox.Show("Varerne er solgt");
                    //SqlConnector.ExecuteSQL("SQL  update query her");
                    //insert i item-action table
                    //print kvittering metode
                }
            }
        }

        public void MoveItem(int locationID)
        {
            foreach (var item in SelectedItemsList)
            {
                SqlConnector.ExecuteSQL("UPDATE item SET location = " + locationID + "WHERE itemID = " + item.ItemID);
                //SqlConnector.ExecuteSQL("INSERT INTO itemAction(Actiontype, State, UserID) VALUES(Item moved," + locationID + "," + uif.UserID);
            }
            SelectedItemsList.Clear();
        }

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


        public int CalculateTotalPrice(DataGridView dataGrid)
        {
            var totalPrice = 0;
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    var price = Convert.ToInt32(row.Cells[2].Value.ToString());
                    totalPrice = totalPrice + price;
                }
            }
            return totalPrice;
        }

        public void ItemSelector(int itemID, DataGridView dataGrid)
        {
            var selectedItem = SqlConnector.RetrieveItem("SELECT * FROM item WHERE item_id =" + itemID);
            SelectedItemsList = CheckSelectedItem(selectedItem, SelectedItemsList);
            ShowDataGridItems(dataGrid);
        }

        public void ShowDataGridItems(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            dataGrid.Refresh();
            bs.DataSource = typeof(Item);

            foreach (var item in SelectedItemsList)
            {
                bs.Add(item);
            }
            if (!isCashRegister)
            {
                dataGrid.ReadOnly = true;
                dataGrid.DataSource = bs;
                dataGrid.Columns[3].Visible = false;
                dataGrid.Columns[5].Visible = false;
            }
            else
            {
                dataGrid.ReadOnly = false;
                dataGrid.DataSource = bs;
                dataGrid.Columns[0].ReadOnly = true;
                dataGrid.Columns[1].ReadOnly = true;          
                dataGrid.Columns[3].Visible = false;
                dataGrid.Columns[5].Visible = false;
            }


        }
    }
}
