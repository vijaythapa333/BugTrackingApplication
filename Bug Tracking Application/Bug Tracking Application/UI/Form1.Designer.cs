namespace Bug_Tracking_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_login = new System.Windows.Forms.PictureBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.lbl_login = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.comboBox_usertype = new System.Windows.Forms.ComboBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).BeginInit();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_login
            // 
            this.pictureBox_login.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_login.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_login.Image")));
            this.pictureBox_login.Location = new System.Drawing.Point(51, 12);
            this.pictureBox_login.Name = "pictureBox_login";
            this.pictureBox_login.Size = new System.Drawing.Size(250, 26);
            this.pictureBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_login.TabIndex = 1;
            this.pictureBox_login.TabStop = false;
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.SystemColors.Control;
            this.panel_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_login.Controls.Add(this.lbl_login);
            this.panel_login.Controls.Add(this.button_reset);
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.comboBox_usertype);
            this.panel_login.Controls.Add(this.textBox_password);
            this.panel_login.Controls.Add(this.textBox_username);
            this.panel_login.Location = new System.Drawing.Point(12, 54);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(329, 284);
            this.panel_login.TabIndex = 2;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(123, 18);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(62, 24);
            this.lbl_login.TabIndex = 5;
            this.lbl_login.Text = "Login";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reset.Location = new System.Drawing.Point(57, 224);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(200, 41);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.DarkGreen;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_login.Location = new System.Drawing.Point(57, 169);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(200, 46);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // comboBox_usertype
            // 
            this.comboBox_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_usertype.FormattingEnabled = true;
            this.comboBox_usertype.Items.AddRange(new object[] {
            "Admin",
            "Tester",
            "Debugger"});
            this.comboBox_usertype.Location = new System.Drawing.Point(57, 131);
            this.comboBox_usertype.Name = "comboBox_usertype";
            this.comboBox_usertype.Size = new System.Drawing.Size(200, 24);
            this.comboBox_usertype.TabIndex = 2;
            this.comboBox_usertype.Text = "User Type";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(57, 95);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '٭';
            this.textBox_password.Size = new System.Drawing.Size(200, 22);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.Text = "PASSSWORD";
            this.textBox_password.Click += new System.EventHandler(this.textBox_password_Click);
            this.textBox_password.Leave += new System.EventHandler(this.textBox_password_Leave);
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(57, 56);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(200, 22);
            this.textBox_username.TabIndex = 0;
            this.textBox_username.Text = "USERNAME";
            this.textBox_username.Click += new System.EventHandler(this.textBox_username_Click);
            this.textBox_username.Leave += new System.EventHandler(this.textBox_username_Leave);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(317, 12);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(26, 25);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 3;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            this.pictureBox_Close.MouseHover += new System.EventHandler(this.pictureBox_Close_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(355, 359);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.pictureBox_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTA_LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_login;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.ComboBox comboBox_usertype;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.PictureBox pictureBox_Close;
    }
}

