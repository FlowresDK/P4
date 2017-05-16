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

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {

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

        }

        private void MoveItemBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
