using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGEN_Storage_system_v2
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void GiverManagementBtn_Click(object sender, EventArgs e)
        {
            GiverManagementPanel.Visible = true;
        }

        private void ItemManagementBtn_Click(object sender, EventArgs e)
        {
            ItemManagementPanel.Visible = true;
        }

        private void CashRegisterBtn_Click(object sender, EventArgs e)
        {
            CashRegisterPanel.Visible = true;
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminPanel.Visible = true;
        }

        private void BackBtn_GiverManagement_Click(object sender, EventArgs e)
        {
            GiverManagementPanel.Visible = false;
        }

        private void RegisterGiverBtn_Click(object sender, EventArgs e)
        {
            RegisterGiverPanel.Visible = true;
        }

        private void EditGiverBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_RegisterGiver_Click(object sender, EventArgs e)
        {
            RegisterGiverPanel.Visible = false;
        }

        private void BackBtn_ItemManagement_Click(object sender, EventArgs e)
        {
            ItemManagementPanel.Visible = false;
        }

        private void RegisterItemBtn_Click(object sender, EventArgs e)
        {
            ChooseCategoryPanel.Visible = true;
        }

        private void MoveItemBtn_Click(object sender, EventArgs e)
        {
            MoveItemPanel.Visible = true;
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            DeleteItemPanel.Visible = true;
        }

        private void FurnitureBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
        }

        private void DecorationBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
        }

        private void KidsBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
        }

        private void CrockeryBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
        }

        private void ElectronicsBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
        }

        private void EntertainmentBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
        }

        private void ClothingBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
        }

        private void MiscBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
        }

        private void BackBtn_ChooseCategory_Click(object sender, EventArgs e)
        {
            ChooseCategoryPanel.Visible = false;
        }

        private void BackBtn_RegisterItem_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = false;
        }

        private void BackBtn_MoveItem_Click(object sender, EventArgs e)
        {
            MoveItemPanel.Visible = false;
        }

        private void MoveToStorageBtn_Click(object sender, EventArgs e)
        {

        }

        private void MoveToShowroomBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_DeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItemPanel.Visible = false;
        }

        private void DeleteThisItemBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_CashRegister_Click(object sender, EventArgs e)
        {
            CashRegisterPanel.Visible = false;
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Admin_Click(object sender, EventArgs e)
        {
            AdminPanel.Visible = false;
        }

        private void BackBtn_RegisterUser_Click(object sender, EventArgs e)
        {
            RegisterUserPanel.Visible = false;
        }

        private void CreateThisUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void RegisterUserBtn_Click(object sender, EventArgs e)
        {
            RegisterUserPanel.Visible = true;
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            EditUserPanel.Visible = true;
        }

        private void StatisticsBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_EditUser_Click(object sender, EventArgs e)
        {
            EditUserPanel.Visible = false;
        }
    }
}
