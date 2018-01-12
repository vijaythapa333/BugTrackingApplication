namespace Bug_Tracking_Application
{
    partial class BTA_AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTA_AddUser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_adduser = new System.Windows.Forms.Label();
            this.label_fullname = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_contact = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_usertype = new System.Windows.Forms.Label();
            this.textBox_fullname = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.comboBox_usertype = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.dataGridView_userlist = new System.Windows.Forms.DataGridView();
            this.pictureBox_CLose = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CLose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.bugsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // bugsToolStripMenuItem
            // 
            this.bugsToolStripMenuItem.Name = "bugsToolStripMenuItem";
            this.bugsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bugsToolStripMenuItem.Text = "Bugs";
            this.bugsToolStripMenuItem.Click += new System.EventHandler(this.bugsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label_adduser
            // 
            this.label_adduser.AutoSize = true;
            this.label_adduser.BackColor = System.Drawing.Color.Transparent;
            this.label_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adduser.Location = new System.Drawing.Point(404, 36);
            this.label_adduser.Name = "label_adduser";
            this.label_adduser.Size = new System.Drawing.Size(125, 20);
            this.label_adduser.TabIndex = 1;
            this.label_adduser.Text = "Manage Users";
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fullname.Location = new System.Drawing.Point(31, 104);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(69, 16);
            this.label_fullname.TabIndex = 2;
            this.label_fullname.Text = "Full Name";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(31, 140);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(42, 16);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "Email";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(31, 179);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(71, 16);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(31, 221);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(68, 16);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Password";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(31, 260);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(53, 16);
            this.label_gender.TabIndex = 6;
            this.label_gender.Text = "Gender";
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.Location = new System.Drawing.Point(31, 303);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(53, 16);
            this.label_contact.TabIndex = 7;
            this.label_contact.Text = "Contact";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(31, 339);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(59, 16);
            this.label_address.TabIndex = 8;
            this.label_address.Text = "Address";
            // 
            // label_usertype
            // 
            this.label_usertype.AutoSize = true;
            this.label_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usertype.Location = new System.Drawing.Point(31, 413);
            this.label_usertype.Name = "label_usertype";
            this.label_usertype.Size = new System.Drawing.Size(72, 16);
            this.label_usertype.TabIndex = 9;
            this.label_usertype.Text = "User Type";
            // 
            // textBox_fullname
            // 
            this.textBox_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fullname.Location = new System.Drawing.Point(126, 104);
            this.textBox_fullname.Name = "textBox_fullname";
            this.textBox_fullname.Size = new System.Drawing.Size(187, 22);
            this.textBox_fullname.TabIndex = 10;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(126, 140);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(187, 22);
            this.textBox_email.TabIndex = 11;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(126, 179);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(187, 22);
            this.textBox_username.TabIndex = 12;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(126, 221);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(187, 22);
            this.textBox_password.TabIndex = 13;
            // 
            // textBox_contact
            // 
            this.textBox_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contact.Location = new System.Drawing.Point(126, 303);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(187, 22);
            this.textBox_contact.TabIndex = 14;
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(126, 339);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(187, 54);
            this.textBox_address.TabIndex = 15;
            // 
            // comboBox_usertype
            // 
            this.comboBox_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_usertype.FormattingEnabled = true;
            this.comboBox_usertype.Items.AddRange(new object[] {
            "Admin",
            "Tester",
            "Debugger"});
            this.comboBox_usertype.Location = new System.Drawing.Point(126, 413);
            this.comboBox_usertype.Name = "comboBox_usertype";
            this.comboBox_usertype.Size = new System.Drawing.Size(187, 24);
            this.comboBox_usertype.TabIndex = 18;
            this.comboBox_usertype.Text = "User Type";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Green;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.Location = new System.Drawing.Point(343, 457);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 31);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "SAVE";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Navy;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reset.Location = new System.Drawing.Point(447, 457);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(82, 31);
            this.button_reset.TabIndex = 20;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_Gender.Location = new System.Drawing.Point(126, 260);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(187, 24);
            this.comboBox_Gender.TabIndex = 21;
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserID.Location = new System.Drawing.Point(31, 72);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(53, 16);
            this.label_UserID.TabIndex = 22;
            this.label_UserID.Text = "User ID";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserID.Location = new System.Drawing.Point(126, 72);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.ReadOnly = true;
            this.textBox_UserID.Size = new System.Drawing.Size(187, 22);
            this.textBox_UserID.TabIndex = 23;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Delete.Location = new System.Drawing.Point(556, 457);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(88, 31);
            this.button_Delete.TabIndex = 24;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // dataGridView_userlist
            // 
            this.dataGridView_userlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_userlist.Location = new System.Drawing.Point(338, 72);
            this.dataGridView_userlist.Name = "dataGridView_userlist";
            this.dataGridView_userlist.Size = new System.Drawing.Size(600, 362);
            this.dataGridView_userlist.TabIndex = 25;
            this.dataGridView_userlist.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_userlist_RowHeaderMouseClick);
            // 
            // pictureBox_CLose
            // 
            this.pictureBox_CLose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CLose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CLose.Image")));
            this.pictureBox_CLose.Location = new System.Drawing.Point(953, 0);
            this.pictureBox_CLose.Name = "pictureBox_CLose";
            this.pictureBox_CLose.Size = new System.Drawing.Size(23, 24);
            this.pictureBox_CLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_CLose.TabIndex = 26;
            this.pictureBox_CLose.TabStop = false;
            this.pictureBox_CLose.Click += new System.EventHandler(this.pictureBox_CLose_Click);
            this.pictureBox_CLose.MouseLeave += new System.EventHandler(this.pictureBox_CLose_MouseLeave);
            this.pictureBox_CLose.MouseHover += new System.EventHandler(this.pictureBox_CLose_MouseHover);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BTA_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 510);
            this.Controls.Add(this.pictureBox_CLose);
            this.Controls.Add(this.dataGridView_userlist);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_usertype);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_fullname);
            this.Controls.Add(this.label_usertype);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_fullname);
            this.Controls.Add(this.label_adduser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BTA_AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTA_AddUser";
            this.Load += new System.EventHandler(this.BTA_AddUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CLose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label_adduser;
        private System.Windows.Forms.Label label_fullname;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_usertype;
        private System.Windows.Forms.TextBox textBox_fullname;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.ComboBox comboBox_usertype;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridView dataGridView_userlist;
        private System.Windows.Forms.PictureBox pictureBox_CLose;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}