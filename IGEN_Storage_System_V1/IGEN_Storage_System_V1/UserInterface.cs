using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGEN_Storage_System_V1
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void giverManagementBtn_Click(object sender, EventArgs e)
        {
            giverManagentPanel.Visible = true;
        }

        private void itemManagementBtn_Click(object sender, EventArgs e)
        {

        }

        private void cashRegisterBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {

        }

        private void registerGiverBtn_Click(object sender, EventArgs e)
        {
            registerGiverPanel.Visible = true;
        }

        private void editGiverBtn_Click(object sender, EventArgs e)
        {
            //editGiverPanel.Visible = true;
        }
        
        private void backBtn_frontPage_Click(object sender, EventArgs e)
        {
            giverManagentPanel.Visible = false;
        }

        private void backBtn_giverManagement_Click(object sender, EventArgs e)
        {
            registerGiverPanel.Visible = false;
            giverManagentPanel.Visible = true;
        }
    }
}
