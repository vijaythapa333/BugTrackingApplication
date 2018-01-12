namespace Bug_Tracking_Application.UI
{
    partial class BTA_BugAssign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTA_BugAssign));
            this.label_title = new System.Windows.Forms.Label();
            this.label_BugID = new System.Windows.Forms.Label();
            this.label_bugTitle = new System.Windows.Forms.Label();
            this.label_AssignTo = new System.Windows.Forms.Label();
            this.comboBox_AssignTo = new System.Windows.Forms.ComboBox();
            this.button_Assign = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.dataGridView_Bugs = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_bugID = new System.Windows.Forms.TextBox();
            this.textBox_BugTitle = new System.Windows.Forms.TextBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(324, 51);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(116, 24);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Assign Bug";
            // 
            // label_BugID
            // 
            this.label_BugID.AutoSize = true;
            this.label_BugID.BackColor = System.Drawing.Color.Transparent;
            this.label_BugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BugID.Location = new System.Drawing.Point(32, 121);
            this.label_BugID.Name = "label_BugID";
            this.label_BugID.Size = new System.Drawing.Size(48, 16);
            this.label_BugID.TabIndex = 1;
            this.label_BugID.Text = "Bug ID";
            // 
            // label_bugTitle
            // 
            this.label_bugTitle.AutoSize = true;
            this.label_bugTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_bugTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bugTitle.Location = new System.Drawing.Point(32, 160);
            this.label_bugTitle.Name = "label_bugTitle";
            this.label_bugTitle.Size = new System.Drawing.Size(61, 16);
            this.label_bugTitle.TabIndex = 2;
            this.label_bugTitle.Text = "Bug Title";
            // 
            // label_AssignTo
            // 
            this.label_AssignTo.AutoSize = true;
            this.label_AssignTo.BackColor = System.Drawing.Color.Transparent;
            this.label_AssignTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AssignTo.Location = new System.Drawing.Point(32, 202);
            this.label_AssignTo.Name = "label_AssignTo";
            this.label_AssignTo.Size = new System.Drawing.Size(69, 16);
            this.label_AssignTo.TabIndex = 3;
            this.label_AssignTo.Text = "Assign To";
            // 
            // comboBox_AssignTo
            // 
            this.comboBox_AssignTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_AssignTo.FormattingEnabled = true;
            this.comboBox_AssignTo.Location = new System.Drawing.Point(140, 202);
            this.comboBox_AssignTo.Name = "comboBox_AssignTo";
            this.comboBox_AssignTo.Size = new System.Drawing.Size(189, 24);
            this.comboBox_AssignTo.TabIndex = 6;
            this.comboBox_AssignTo.Text = "Select User";
            // 
            // button_Assign
            // 
            this.button_Assign.BackColor = System.Drawing.Color.Green;
            this.button_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Assign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Assign.Location = new System.Drawing.Point(140, 247);
            this.button_Assign.Name = "button_Assign";
            this.button_Assign.Size = new System.Drawing.Size(83, 33);
            this.button_Assign.TabIndex = 7;
            this.button_Assign.Text = "ASSIGN";
            this.button_Assign.UseVisualStyleBackColor = false;
            this.button_Assign.Click += new System.EventHandler(this.button_Assign_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Cancel.Location = new System.Drawing.Point(251, 247);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(83, 33);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // dataGridView_Bugs
            // 
            this.dataGridView_Bugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bugs.Location = new System.Drawing.Point(354, 87);
            this.dataGridView_Bugs.Name = "dataGridView_Bugs";
            this.dataGridView_Bugs.Size = new System.Drawing.Size(438, 184);
            this.dataGridView_Bugs.TabIndex = 11;
            this.dataGridView_Bugs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Bugs_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_bugID
            // 
            this.textBox_bugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bugID.Location = new System.Drawing.Point(140, 121);
            this.textBox_bugID.Name = "textBox_bugID";
            this.textBox_bugID.ReadOnly = true;
            this.textBox_bugID.Size = new System.Drawing.Size(189, 22);
            this.textBox_bugID.TabIndex = 13;
            // 
            // textBox_BugTitle
            // 
            this.textBox_BugTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BugTitle.Location = new System.Drawing.Point(140, 159);
            this.textBox_BugTitle.Name = "textBox_BugTitle";
            this.textBox_BugTitle.ReadOnly = true;
            this.textBox_BugTitle.Size = new System.Drawing.Size(189, 22);
            this.textBox_BugTitle.TabIndex = 14;
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(780, 12);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(30, 26);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 15;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            this.pictureBox_Close.MouseHover += new System.EventHandler(this.pictureBox_Close_MouseHover);
            // 
            // BTA_BugAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 343);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.textBox_BugTitle);
            this.Controls.Add(this.textBox_bugID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView_Bugs);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Assign);
            this.Controls.Add(this.comboBox_AssignTo);
            this.Controls.Add(this.label_AssignTo);
            this.Controls.Add(this.label_bugTitle);
            this.Controls.Add(this.label_BugID);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BTA_BugAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTA_BugAssign";
            this.Load += new System.EventHandler(this.BTA_BugAssign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_BugID;
        private System.Windows.Forms.Label label_bugTitle;
        private System.Windows.Forms.Label label_AssignTo;
        private System.Windows.Forms.ComboBox comboBox_AssignTo;
        private System.Windows.Forms.Button button_Assign;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.DataGridView dataGridView_Bugs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_bugID;
        private System.Windows.Forms.TextBox textBox_BugTitle;
        private System.Windows.Forms.PictureBox pictureBox_Close;
    }
}