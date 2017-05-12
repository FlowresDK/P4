namespace IGEN_Storage_System_V1
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.giverManagementBtn = new System.Windows.Forms.Button();
            this.frontPagePanel = new System.Windows.Forms.Panel();
            this.giverManagentPanel = new System.Windows.Forms.Panel();
            this.registerGiverBtn = new System.Windows.Forms.Button();
            this.editGiverBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.cashRegisterBtn = new System.Windows.Forms.Button();
            this.itemManagementBtn = new System.Windows.Forms.Button();
            this.giverManagementTxt = new System.Windows.Forms.Label();
            this.backBtn_frontPage = new System.Windows.Forms.Button();
            this.registerGiverPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn_giverManagement = new System.Windows.Forms.Button();
            this.frontPagePanel.SuspendLayout();
            this.giverManagentPanel.SuspendLayout();
            this.registerGiverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // giverManagementBtn
            // 
            this.giverManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.giverManagementBtn.Location = new System.Drawing.Point(183, 453);
            this.giverManagementBtn.Name = "giverManagementBtn";
            this.giverManagementBtn.Size = new System.Drawing.Size(564, 505);
            this.giverManagementBtn.TabIndex = 0;
            this.giverManagementBtn.Text = "Giver management";
            this.giverManagementBtn.UseVisualStyleBackColor = true;
            this.giverManagementBtn.Click += new System.EventHandler(this.giverManagementBtn_Click);
            // 
            // frontPagePanel
            // 
            this.frontPagePanel.AutoSize = true;
            this.frontPagePanel.Controls.Add(this.giverManagentPanel);
            this.frontPagePanel.Controls.Add(this.logOutBtn);
            this.frontPagePanel.Controls.Add(this.adminBtn);
            this.frontPagePanel.Controls.Add(this.giverManagementBtn);
            this.frontPagePanel.Controls.Add(this.cashRegisterBtn);
            this.frontPagePanel.Controls.Add(this.itemManagementBtn);
            this.frontPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frontPagePanel.Location = new System.Drawing.Point(0, 0);
            this.frontPagePanel.Name = "frontPagePanel";
            this.frontPagePanel.Size = new System.Drawing.Size(2544, 1403);
            this.frontPagePanel.TabIndex = 1;
            // 
            // giverManagentPanel
            // 
            this.giverManagentPanel.Controls.Add(this.registerGiverPanel);
            this.giverManagentPanel.Controls.Add(this.backBtn_frontPage);
            this.giverManagentPanel.Controls.Add(this.giverManagementTxt);
            this.giverManagentPanel.Controls.Add(this.registerGiverBtn);
            this.giverManagentPanel.Controls.Add(this.editGiverBtn);
            this.giverManagentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giverManagentPanel.Location = new System.Drawing.Point(0, 0);
            this.giverManagentPanel.Name = "giverManagentPanel";
            this.giverManagentPanel.Size = new System.Drawing.Size(2544, 1403);
            this.giverManagentPanel.TabIndex = 6;
            this.giverManagentPanel.Visible = false;
            // 
            // registerGiverBtn
            // 
            this.registerGiverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.registerGiverBtn.Location = new System.Drawing.Point(594, 453);
            this.registerGiverBtn.Name = "registerGiverBtn";
            this.registerGiverBtn.Size = new System.Drawing.Size(564, 505);
            this.registerGiverBtn.TabIndex = 4;
            this.registerGiverBtn.Text = "Register giver";
            this.registerGiverBtn.UseVisualStyleBackColor = true;
            this.registerGiverBtn.Click += new System.EventHandler(this.registerGiverBtn_Click);
            // 
            // editGiverBtn
            // 
            this.editGiverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editGiverBtn.Location = new System.Drawing.Point(1387, 453);
            this.editGiverBtn.Name = "editGiverBtn";
            this.editGiverBtn.Size = new System.Drawing.Size(564, 505);
            this.editGiverBtn.TabIndex = 5;
            this.editGiverBtn.Text = "Edit giver";
            this.editGiverBtn.UseVisualStyleBackColor = true;
            this.editGiverBtn.Click += new System.EventHandler(this.editGiverBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.logOutBtn.Location = new System.Drawing.Point(41, 36);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(278, 86);
            this.logOutBtn.TabIndex = 5;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.adminBtn.Location = new System.Drawing.Point(2094, 1243);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(20);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(398, 121);
            this.adminBtn.TabIndex = 4;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // cashRegisterBtn
            // 
            this.cashRegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cashRegisterBtn.Location = new System.Drawing.Point(1751, 453);
            this.cashRegisterBtn.Name = "cashRegisterBtn";
            this.cashRegisterBtn.Size = new System.Drawing.Size(564, 505);
            this.cashRegisterBtn.TabIndex = 3;
            this.cashRegisterBtn.Text = "Cash register";
            this.cashRegisterBtn.UseVisualStyleBackColor = true;
            this.cashRegisterBtn.Click += new System.EventHandler(this.cashRegisterBtn_Click);
            // 
            // itemManagementBtn
            // 
            this.itemManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.itemManagementBtn.Location = new System.Drawing.Point(976, 453);
            this.itemManagementBtn.Name = "itemManagementBtn";
            this.itemManagementBtn.Size = new System.Drawing.Size(564, 505);
            this.itemManagementBtn.TabIndex = 2;
            this.itemManagementBtn.Text = "Item management";
            this.itemManagementBtn.UseVisualStyleBackColor = true;
            this.itemManagementBtn.Click += new System.EventHandler(this.itemManagementBtn_Click);
            // 
            // giverManagementTxt
            // 
            this.giverManagementTxt.AutoSize = true;
            this.giverManagementTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.giverManagementTxt.Location = new System.Drawing.Point(1116, 194);
            this.giverManagementTxt.Name = "giverManagementTxt";
            this.giverManagementTxt.Size = new System.Drawing.Size(326, 55);
            this.giverManagementTxt.TabIndex = 6;
            this.giverManagementTxt.Text = "Your text here";
            // 
            // backBtn_frontPage
            // 
            this.backBtn_frontPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backBtn_frontPage.Location = new System.Drawing.Point(41, 36);
            this.backBtn_frontPage.Name = "backBtn_frontPage";
            this.backBtn_frontPage.Size = new System.Drawing.Size(278, 86);
            this.backBtn_frontPage.TabIndex = 7;
            this.backBtn_frontPage.Text = "Back";
            this.backBtn_frontPage.UseVisualStyleBackColor = true;
            this.backBtn_frontPage.Click += new System.EventHandler(this.backBtn_frontPage_Click);
            // 
            // registerGiverPanel
            // 
            this.registerGiverPanel.Controls.Add(this.backBtn_giverManagement);
            this.registerGiverPanel.Controls.Add(this.label1);
            this.registerGiverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerGiverPanel.Location = new System.Drawing.Point(0, 0);
            this.registerGiverPanel.Name = "registerGiverPanel";
            this.registerGiverPanel.Size = new System.Drawing.Size(2544, 1403);
            this.registerGiverPanel.TabIndex = 8;
            this.registerGiverPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(1116, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your text here";
            // 
            // backBtn_giverManagement
            // 
            this.backBtn_giverManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backBtn_giverManagement.Location = new System.Drawing.Point(41, 36);
            this.backBtn_giverManagement.Name = "backBtn_giverManagement";
            this.backBtn_giverManagement.Size = new System.Drawing.Size(278, 86);
            this.backBtn_giverManagement.TabIndex = 8;
            this.backBtn_giverManagement.Text = "Back";
            this.backBtn_giverManagement.UseVisualStyleBackColor = true;
            this.backBtn_giverManagement.Click += new System.EventHandler(this.backBtn_giverManagement_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2544, 1403);
            this.Controls.Add(this.frontPagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nemt";
            this.frontPagePanel.ResumeLayout(false);
            this.giverManagentPanel.ResumeLayout(false);
            this.giverManagentPanel.PerformLayout();
            this.registerGiverPanel.ResumeLayout(false);
            this.registerGiverPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giverManagementBtn;
        private System.Windows.Forms.Panel frontPagePanel;
        private System.Windows.Forms.Button itemManagementBtn;
        private System.Windows.Forms.Button cashRegisterBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Panel giverManagentPanel;
        private System.Windows.Forms.Button registerGiverBtn;
        private System.Windows.Forms.Button editGiverBtn;
        private System.Windows.Forms.Button backBtn_frontPage;
        private System.Windows.Forms.Label giverManagementTxt;
        private System.Windows.Forms.Panel registerGiverPanel;
        private System.Windows.Forms.Button backBtn_giverManagement;
        private System.Windows.Forms.Label label1;
    }
}

