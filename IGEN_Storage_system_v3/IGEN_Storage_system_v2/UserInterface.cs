using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGEN_Storage_system_v2
{
    public partial class UserInterface : Form
    {

        Giver tempGiver = new Giver();
        User tempUser = new User();
        Item tempItem = new Item();
        public User TempUser;
        public Giver TempGiver;
        public int UserID;
        public int TestPrice;
        private bool IsAdmin;
        private int SelectedCategory;


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
            tempItem.isCashRegister = true;
            tempItem.ShowDataGridItems(CashRegister_DataGrid);
            TestPrice = 0;
            this.TotalPrice.Text = Convert.ToString(TestPrice) + ",-";
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {

            if (IsAdmin == true)
            {
                AdminPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("You don't have the rights to this function.");
            }

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
            EditGiverPanel.Visible = true;
            //GiverManagementPanel.Visible = false;
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
            tempItem.isCashRegister = false;
            tempItem.ShowDataGridItems(MoveItem_DataGrid);
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {

            DeleteItemPanel.Visible = true;
            tempItem.isCashRegister = false;
            tempItem.ShowDataGridItems(DeleteItem_DataGrid);
        }

        private void FurnitureBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
            SelectedCategory = 1;
            CategoryInput.Text = "Furniture";
        }

        private void DecorationBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
            SelectedCategory = 2;
            CategoryInput.Text = "Decoration";
        }

        private void KidsBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
            SelectedCategory = 3;
            CategoryInput.Text = "Kids";
        }

        private void CrockeryBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
            SelectedCategory = 4;
            CategoryInput.Text = "Crockery and kitchenware";
        }

        private void ElectronicsBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
            SelectedCategory = 5;
            CategoryInput.Text = "Electronics";
        }

        private void EntertainmentBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
            SelectedCategory = 6;
            CategoryInput.Text = "Entertainment";
        }

        private void ClothingBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
            SelectedCategory = 7;
            CategoryInput.Text = "Clothing and accessories";
        }

        private void MiscBtn_Click(object sender, EventArgs e)
        {
            RegisterItemPanel.Visible = true;
            SelectedCategory = 8;
            CategoryInput.Text = "Miscellaneous";
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
            tempItem.SelectedItemsList.Clear();
        }

        private void MoveToStorageBtn_Click(object sender, EventArgs e)
        {
            var locationID = 1;
            tempItem.MoveItem(locationID);
            MessageBox.Show("Items moved succesfully");
            ItemManagementPanel.Visible = true;
            MoveItemPanel.Visible = false;
        }

        private void MoveToShowroomBtn_Click(object sender, EventArgs e)
        {
            var locationID = 2;
            tempItem.MoveItem(locationID);
            MessageBox.Show("Items moved succesfully");
            ItemManagementPanel.Visible = true;
            MoveItemPanel.Visible = false;
        }

        private void BackBtn_DeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItemPanel.Visible = false;
            tempItem.SelectedItemsList.Clear();
        }

        private void DeleteThisItemBtn_Click(object sender, EventArgs e)
        {
            tempItem.DeleteItem();
            MessageBox.Show("Items deleted succesfully");
            ItemManagementPanel.Visible = true;
            DeleteItemPanel.Visible = false;
        }

        private void BackBtn_CashRegister_Click(object sender, EventArgs e)
        {
            CashRegisterPanel.Visible = false;
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            tempItem.SellItem(CashRegister_DataGrid);
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
            var firstName = firstNameUserInput.Text;
            var lastName = lastNameUserInput.Text;
            var role_input = roleInput.Text;
            var rights_input = rightsInput.Text;                                   //FIX COMBOBOX
            var phoneNumber = Convert.ToInt32(phoneNumberUserInput.Text);
            var mail = mailUserInput.Text;
            var streetName = streetNameUserInput.Text;
            var cityName = cityNameUserInput.Text;
            var zipCode = Convert.ToInt32(zipCodeUserInput.Text);

            var role = Int32.Parse(Regex.Match(role_input, @"\d+").Value);
            var rights = Int32.Parse(Regex.Match(rights_input, @"\d+").Value);

            SqlConnector.ExecuteSQL("INSERT INTO employee(first_name, last_name, street_name, city, zip_code, phone_num, mail, role_id, rights) VALUES ('"
                + firstName + "','" + lastName + "','" + streetName + "','" + cityName + "','" + zipCode + "','" + phoneNumber + "','" + mail + "','" + role + "','" + rights + "')"); //TEST EFTER FK

            MessageBox.Show("The data was saved.");
            AdminPanel.Visible = true;
            RegisterUserPanel.Visible = false;

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
            MessageBox.Show("Not working yet.");
        }

        private void BackBtn_EditUser_Click(object sender, EventArgs e)
        {
            EditUserPanel.Visible = false;
        }

        private void RegisterAndPrintGiverBtn_Click(object sender, EventArgs e)
        {
            var firstName = this.firstNameGiverInput.Text;
            var lastName = this.lastNameGiverInput.Text;
            var phoneNumber = Convert.ToInt32(this.phoneNumberGiverInput.Text);
            var mail = this.mailGiverInput.Text;
            var streetName = this.streetNameGiverInput.Text;
            var cityName = this.cityNameInputGiver.Text;
            var zipCode = Convert.ToInt32(this.zipCodeGiverInput.Text);
            var pickUpDate = this.pickUpDateInput.Value.Date;
            var pickUpTime = this.pickUpTimeInput.Value.TimeOfDay;
            var pickUpComment = this.pickupCommentInput.Text;

            SqlConnector.ExecuteSQL(
                "INSERT INTO giver(first_name, last_name, street_name, city, zip_code, phone_num, mail, pickup_date, pickup_time, comment) VALUES ('"
                + firstName + "','" + lastName + "','" + streetName + "','" + cityName + "','" + zipCode + "','" + phoneNumber + "','" + mail + "','" 
                + pickUpDate + "','" + pickUpTime + "','"+ pickUpComment + "')"
                );

            MessageBox.Show("The data was saved.");
            GiverManagementPanel.Visible = true;
            RegisterGiverPanel.Visible = false;

                                                                                                                                  //TODO PRINT-METHOD & CLEAR FORMS
        }

        private void BackBtn_SearchGiver_Click(object sender, EventArgs e)
        {
            EditGiverPanel.Visible = false;
        }

        private void UserSearchAndEditBtn_Click(object sender, EventArgs e)
        {

            var userid = SearchForUserInput.Text;
            TempUser = SqlConnector.RetrieveUsers("SELECT * FROM employee WHERE user_id =" + userid);

            UserEditorPanel.Visible = true;
            firstName_EditUserInput.Text = Convert.ToString(TempUser.FirstName);
            lastName_EditUserInput.Text = Convert.ToString(TempUser.LastName);
            role_EditUserInput.Text = Convert.ToString(TempUser.Role);
            rights__EditUserInput.Text = Convert.ToString(TempUser.Rights);
            phoneNum_EditUserInput.Text = Convert.ToString(TempUser.PhoneNumber);
            mail__EditUserInput.Text = Convert.ToString(TempUser.Mail);
            streetName_EditUserInput.Text = Convert.ToString(TempUser.StreetName);
            city_EditUserInput.Text = Convert.ToString(TempUser.CityName);
            zipCode_EditUserInput.Text = Convert.ToString(TempUser.ZipCode);

        }

        private void BackBtn_EditUserInfo_Click(object sender, EventArgs e)
        {
            UserEditorPanel.Visible = false;
        }

        private void SearchAndEditGiverBtn_Click(object sender, EventArgs e)
        {

            var giverid = SearchForGiverInput.Text;
            TempGiver = SqlConnector.RetrieveGivers("SELECT * FROM giver WHERE giver_id =" + giverid);
            GiverEditorPanel.Visible = true;
            //EditGiverPanel.Visible = false;

            
            firstName_editGiver.Text = Convert.ToString(TempGiver.FirstName);
            lastName_editGiver.Text = Convert.ToString(TempGiver.LastName);
            phoneNumber_editGiver.Text = Convert.ToString(TempGiver.PhoneNumber);
            mail_editGiver.Text = Convert.ToString(TempGiver.Mail);
            street_editGiver.Text = Convert.ToString(TempGiver.StreetName);
            city_editGiver.Text = Convert.ToString(TempGiver.CityName);
            zipCode_editGiver.Text = Convert.ToString(TempGiver.ZipCode);
            pickUpDate_editGiver.Value = TempGiver.PickUpDate;
            pickUpTime_editGiver.Value = TempGiver.PickUpTime;
            pickUpComment_editGiver.Text = Convert.ToString(TempGiver.PickUpComment);
        }

        private void AddItemBtn_MoveItem_Click(object sender, EventArgs e)
        {
            var itemID = Convert.ToInt32(MoveItemInputBox.Text);
            tempItem.ItemSelector(itemID, MoveItem_DataGrid);

        }

        private void AddItemBtn_DeleteItem_Click(object sender, EventArgs e)
        {
            var itemID = Convert.ToInt32(DeleteItemInputBox.Text);
            tempItem.ItemSelector(itemID, DeleteItem_DataGrid);
        }

        private void BackBtn_EditGiverInfo_Click(object sender, EventArgs e)
        {
            GiverEditorPanel.Visible = false;
        }

        private void SaveChanges_EditGiverBtn_Click(object sender, EventArgs e)
        {
            var firstName = firstName_editGiver.Text;
            var lastName = lastName_editGiver.Text;
            var phoneNumber = Convert.ToInt32(phoneNumber_editGiver.Text);
            var mail = mail_editGiver.Text;
            var streetName = street_editGiver.Text;
            var cityName = city_editGiver.Text;
            var zipCode = Convert.ToInt32(zipCode_editGiver.Text);
            var pickUpDate = DateTime.Parse(pickUpDate_editGiver.Text);
            var pickUpTime = DateTime.Parse(pickUpTime_editGiver.Text);
            var pickUpComment = pickUpComment_editGiver.Text;

            SqlConnector.ExecuteSQL("UPDATE giver SET first_name = '"+ firstName + "', last_name ='" + lastName + "', phone_num = '"+ phoneNumber +"', mail = '"+ mail +"', street_name = '"+ streetName +"', city = '"
                +cityName+"', zip_code = '" + zipCode + "', pickup_date = '" + pickUpDate +"', pickup_time = '" + pickUpTime + "', comment = '"+ pickUpComment + "' WHERE giver_id = "+ TempGiver.GiverID);

            MessageBox.Show("The data was saved.");
            GiverManagementPanel.Visible = true;
            GiverEditorPanel.Visible = false;
        }

        private void EditUser_SaveChangesBtn_Click(object sender, EventArgs e)
        {
            var firstName = firstName_EditUserInput.Text;
            var lastName = lastName_EditUserInput.Text;
            var role_input = role_EditUserInput.Text;
            var rights_input = rights__EditUserInput.Text;
            var phoneNumber = Convert.ToInt32(phoneNum_EditUserInput.Text);
            var mail = mail__EditUserInput.Text;
            var streetName = streetName_EditUserInput.Text;
            var cityName = city_EditUserInput.Text;
            var zipCode = Convert.ToInt32(zipCode_EditUserInput.Text);

            var role = Int32.Parse(Regex.Match(role_input, @"\d+").Value);
            var rights = Int32.Parse(Regex.Match(rights_input, @"\d+").Value);

            SqlConnector.ExecuteSQL("UPDATE employee SET first_name = '" + firstName + "', last_name ='" + lastName + "', phone_num = " + phoneNumber + ", mail = '" + mail + "', street_name = '" + streetName + "', city = '"
                + cityName + "', zipCode = " + zipCode + ", role_id = " + role + ", rights = " + rights + " WHERE user_id = " + UserID);

            MessageBox.Show("The data was saved.");
            AdminPanel.Visible = true;
            RegisterUserPanel.Visible = false;
        }

        private void RegisterAndPrintItemBtn_Click(object sender, EventArgs e)
        {
            var giverID = Convert.ToInt32(GiverID_RegItemInput.Text);
            var price = Convert.ToInt32(Price_RegItemInput.Text);
            var comment = Comments_RegItemInput.Text;
            var reg_date = DateTime.Now;

            SqlConnector.ExecuteSQL("INSERT INTO item (price, category_id, giver_id, comment, reg_date) VALUES (" 
                + price + "," + SelectedCategory + "," + giverID + ",'" + comment + "','" + reg_date +"')");

            MessageBox.Show("The data was saved.");
            ChooseCategoryPanel.Visible = true;
            RegisterItemPanel.Visible = false;
        }

        private void DeleteUser_Btn_Click(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            UserID = Convert.ToInt32(LogIn_UserIdInput.Text);
            TempUser = SqlConnector.RetrieveUsers("SELECT * FROM employee WHERE user_id =" + UserID);
            var test = TempUser.CityName;

            if (UserID == TempUser.UserID)
            {

                if (TempUser.Rights == 2)
                {
                    IsAdmin = true;
                }
                else
                {
                    IsAdmin = true; // CHANGE TO FALSE
                }
                FrontPagePanel.Visible = true;
                LogInPanel.Visible = false;
            }

            else
            {
                MessageBox.Show("Invalid login.");
            }

        }

        private void AddItem_CashRegisterBtn_Click(object sender, EventArgs e)
        {
            var itemID = Convert.ToInt32(ItemID_InputCashReg.Text);
            tempItem.ItemSelector(itemID, CashRegister_DataGrid);
            tempItem.ShowDataGridItems(CashRegister_DataGrid);
            TestPrice = tempItem.CalculateTotalPrice(CashRegister_DataGrid);
            TotalPrice.Text = Convert.ToString(TestPrice) + ",-";

        }

        private void CashRegister_DataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TestPrice = tempItem.CalculateTotalPrice(CashRegister_DataGrid);
            TotalPrice.Text = Convert.ToString(TestPrice) + ",-";
        }

    }
}
