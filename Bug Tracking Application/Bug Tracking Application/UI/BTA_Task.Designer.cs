namespace Bug_Tracking_Application.UI
{
    partial class BTA_Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTA_Task));
            this.dataGridView_TaskBug = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_submitCode = new System.Windows.Forms.TextBox();
            this.label_SubmitCode = new System.Windows.Forms.Label();
            this.textBox_BugID = new System.Windows.Forms.TextBox();
            this.label_BugID = new System.Windows.Forms.Label();
            this.dateTimePicker_reportdate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.comboBox_severity = new System.Windows.Forms.ComboBox();
            this.textBox_bugdescription = new System.Windows.Forms.TextBox();
            this.textBox_bugtitle = new System.Windows.Forms.TextBox();
            this.label_reportdate = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_severity = new System.Windows.Forms.Label();
            this.label_bugdescription = new System.Windows.Forms.Label();
            this.label_bugtitle = new System.Windows.Forms.Label();
            this.label_project = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.pictureBox_BugImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ProjectURL = new System.Windows.Forms.Label();
            this.linkLabel_ProjectURL = new System.Windows.Forms.LinkLabel();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.label_ImagePath = new System.Windows.Forms.Label();
            this.textBox_Project = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskBug)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BugImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_TaskBug
            // 
            this.dataGridView_TaskBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaskBug.Location = new System.Drawing.Point(404, 71);
            this.dataGridView_TaskBug.Name = "dataGridView_TaskBug";
            this.dataGridView_TaskBug.Size = new System.Drawing.Size(597, 304);
            this.dataGridView_TaskBug.TabIndex = 0;
            this.dataGridView_TaskBug.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_TaskBug_RowHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.usersToolStripMenuItem.Text = "Bugs";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.projectsToolStripMenuItem.Text = "Tasks";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help ";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(413, 30);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(56, 20);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Tasks";
            // 
            // textBox_submitCode
            // 
            this.textBox_submitCode.Location = new System.Drawing.Point(180, 264);
            this.textBox_submitCode.Multiline = true;
            this.textBox_submitCode.Name = "textBox_submitCode";
            this.textBox_submitCode.Size = new System.Drawing.Size(200, 111);
            this.textBox_submitCode.TabIndex = 43;
            // 
            // label_SubmitCode
            // 
            this.label_SubmitCode.AutoSize = true;
            this.label_SubmitCode.BackColor = System.Drawing.Color.Transparent;
            this.label_SubmitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SubmitCode.Location = new System.Drawing.Point(19, 308);
            this.label_SubmitCode.Name = "label_SubmitCode";
            this.label_SubmitCode.Size = new System.Drawing.Size(85, 16);
            this.label_SubmitCode.TabIndex = 42;
            this.label_SubmitCode.Text = "Submit Code";
            // 
            // textBox_BugID
            // 
            this.textBox_BugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BugID.Location = new System.Drawing.Point(180, 71);
            this.textBox_BugID.Name = "textBox_BugID";
            this.textBox_BugID.ReadOnly = true;
            this.textBox_BugID.Size = new System.Drawing.Size(200, 22);
            this.textBox_BugID.TabIndex = 41;
            // 
            // label_BugID
            // 
            this.label_BugID.AutoSize = true;
            this.label_BugID.BackColor = System.Drawing.Color.Transparent;
            this.label_BugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BugID.Location = new System.Drawing.Point(19, 71);
            this.label_BugID.Name = "label_BugID";
            this.label_BugID.Size = new System.Drawing.Size(48, 16);
            this.label_BugID.TabIndex = 40;
            this.label_BugID.Text = "Bug ID";
            // 
            // dateTimePicker_reportdate
            // 
            this.dateTimePicker_reportdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_reportdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_reportdate.Location = new System.Drawing.Point(180, 427);
            this.dateTimePicker_reportdate.Name = "dateTimePicker_reportdate";
            this.dateTimePicker_reportdate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_reportdate.TabIndex = 39;
            // 
            // comboBox_status
            // 
            this.comboBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Choose status",
            "Submitted",
            "Assigned",
            "Pending",
            "Resolved"});
            this.comboBox_status.Location = new System.Drawing.Point(180, 387);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(200, 24);
            this.comboBox_status.TabIndex = 38;
            // 
            // comboBox_severity
            // 
            this.comboBox_severity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_severity.FormattingEnabled = true;
            this.comboBox_severity.Items.AddRange(new object[] {
            "Blocker",
            "Critical",
            "Major",
            "Normal",
            "Minor",
            "Trivial",
            "Enhancement"});
            this.comboBox_severity.Location = new System.Drawing.Point(180, 464);
            this.comboBox_severity.Name = "comboBox_severity";
            this.comboBox_severity.Size = new System.Drawing.Size(200, 24);
            this.comboBox_severity.TabIndex = 37;
            // 
            // textBox_bugdescription
            // 
            this.textBox_bugdescription.Location = new System.Drawing.Point(180, 168);
            this.textBox_bugdescription.Multiline = true;
            this.textBox_bugdescription.Name = "textBox_bugdescription";
            this.textBox_bugdescription.Size = new System.Drawing.Size(200, 85);
            this.textBox_bugdescription.TabIndex = 35;
            // 
            // textBox_bugtitle
            // 
            this.textBox_bugtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bugtitle.Location = new System.Drawing.Point(180, 135);
            this.textBox_bugtitle.Name = "textBox_bugtitle";
            this.textBox_bugtitle.ReadOnly = true;
            this.textBox_bugtitle.Size = new System.Drawing.Size(200, 22);
            this.textBox_bugtitle.TabIndex = 34;
            // 
            // label_reportdate
            // 
            this.label_reportdate.AutoSize = true;
            this.label_reportdate.BackColor = System.Drawing.Color.Transparent;
            this.label_reportdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reportdate.Location = new System.Drawing.Point(19, 427);
            this.label_reportdate.Name = "label_reportdate";
            this.label_reportdate.Size = new System.Drawing.Size(81, 16);
            this.label_reportdate.TabIndex = 33;
            this.label_reportdate.Text = "Report Date";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(19, 387);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(45, 16);
            this.label_status.TabIndex = 32;
            this.label_status.Text = "Status";
            // 
            // label_severity
            // 
            this.label_severity.AutoSize = true;
            this.label_severity.BackColor = System.Drawing.Color.Transparent;
            this.label_severity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_severity.Location = new System.Drawing.Point(19, 464);
            this.label_severity.Name = "label_severity";
            this.label_severity.Size = new System.Drawing.Size(57, 16);
            this.label_severity.TabIndex = 31;
            this.label_severity.Text = "Severity";
            // 
            // label_bugdescription
            // 
            this.label_bugdescription.AutoSize = true;
            this.label_bugdescription.BackColor = System.Drawing.Color.Transparent;
            this.label_bugdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bugdescription.Location = new System.Drawing.Point(19, 198);
            this.label_bugdescription.Name = "label_bugdescription";
            this.label_bugdescription.Size = new System.Drawing.Size(103, 16);
            this.label_bugdescription.TabIndex = 30;
            this.label_bugdescription.Text = "Bug Description";
            // 
            // label_bugtitle
            // 
            this.label_bugtitle.AutoSize = true;
            this.label_bugtitle.BackColor = System.Drawing.Color.Transparent;
            this.label_bugtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bugtitle.Location = new System.Drawing.Point(19, 135);
            this.label_bugtitle.Name = "label_bugtitle";
            this.label_bugtitle.Size = new System.Drawing.Size(61, 16);
            this.label_bugtitle.TabIndex = 29;
            this.label_bugtitle.Text = "Bug Title";
            // 
            // label_project
            // 
            this.label_project.AutoSize = true;
            this.label_project.BackColor = System.Drawing.Color.Transparent;
            this.label_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project.Location = new System.Drawing.Point(19, 100);
            this.label_project.Name = "label_project";
            this.label_project.Size = new System.Drawing.Size(50, 16);
            this.label_project.TabIndex = 28;
            this.label_project.Text = "Project";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Green;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Save.Location = new System.Drawing.Point(180, 533);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(200, 49);
            this.button_Save.TabIndex = 44;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // pictureBox_BugImage
            // 
            this.pictureBox_BugImage.Location = new System.Drawing.Point(483, 381);
            this.pictureBox_BugImage.Name = "pictureBox_BugImage";
            this.pictureBox_BugImage.Size = new System.Drawing.Size(518, 113);
            this.pictureBox_BugImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_BugImage.TabIndex = 45;
            this.pictureBox_BugImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Bug Image";
            // 
            // label_ProjectURL
            // 
            this.label_ProjectURL.AutoSize = true;
            this.label_ProjectURL.BackColor = System.Drawing.Color.Transparent;
            this.label_ProjectURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProjectURL.Location = new System.Drawing.Point(19, 506);
            this.label_ProjectURL.Name = "label_ProjectURL";
            this.label_ProjectURL.Size = new System.Drawing.Size(80, 16);
            this.label_ProjectURL.TabIndex = 31;
            this.label_ProjectURL.Text = "Project URL";
            // 
            // linkLabel_ProjectURL
            // 
            this.linkLabel_ProjectURL.AutoSize = true;
            this.linkLabel_ProjectURL.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_ProjectURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_ProjectURL.Location = new System.Drawing.Point(180, 506);
            this.linkLabel_ProjectURL.Name = "linkLabel_ProjectURL";
            this.linkLabel_ProjectURL.Size = new System.Drawing.Size(77, 16);
            this.linkLabel_ProjectURL.TabIndex = 47;
            this.linkLabel_ProjectURL.TabStop = true;
            this.linkLabel_ProjectURL.Text = "ProjectURL";
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(975, 0);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(26, 24);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 48;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            this.pictureBox_Close.MouseHover += new System.EventHandler(this.pictureBox_Close_MouseHover);
            // 
            // label_ImagePath
            // 
            this.label_ImagePath.AutoSize = true;
            this.label_ImagePath.BackColor = System.Drawing.Color.Transparent;
            this.label_ImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ImagePath.Location = new System.Drawing.Point(401, 506);
            this.label_ImagePath.Name = "label_ImagePath";
            this.label_ImagePath.Size = new System.Drawing.Size(84, 16);
            this.label_ImagePath.TabIndex = 46;
            this.label_ImagePath.Text = "[Image Path]";
            // 
            // textBox_Project
            // 
            this.textBox_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Project.Location = new System.Drawing.Point(180, 100);
            this.textBox_Project.Name = "textBox_Project";
            this.textBox_Project.ReadOnly = true;
            this.textBox_Project.Size = new System.Drawing.Size(200, 22);
            this.textBox_Project.TabIndex = 41;
            // 
            // BTA_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 594);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.linkLabel_ProjectURL);
            this.Controls.Add(this.label_ImagePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_BugImage);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_submitCode);
            this.Controls.Add(this.label_SubmitCode);
            this.Controls.Add(this.textBox_Project);
            this.Controls.Add(this.textBox_BugID);
            this.Controls.Add(this.label_BugID);
            this.Controls.Add(this.dateTimePicker_reportdate);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.comboBox_severity);
            this.Controls.Add(this.textBox_bugdescription);
            this.Controls.Add(this.textBox_bugtitle);
            this.Controls.Add(this.label_reportdate);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_ProjectURL);
            this.Controls.Add(this.label_severity);
            this.Controls.Add(this.label_bugdescription);
            this.Controls.Add(this.label_bugtitle);
            this.Controls.Add(this.label_project);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.dataGridView_TaskBug);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BTA_Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTA_Task";
            this.Load += new System.EventHandler(this.BTA_Task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskBug)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BugImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_TaskBug;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_submitCode;
        private System.Windows.Forms.Label label_SubmitCode;
        private System.Windows.Forms.TextBox textBox_BugID;
        private System.Windows.Forms.Label label_BugID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reportdate;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.ComboBox comboBox_severity;
        private System.Windows.Forms.TextBox textBox_bugdescription;
        private System.Windows.Forms.TextBox textBox_bugtitle;
        private System.Windows.Forms.Label label_reportdate;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_severity;
        private System.Windows.Forms.Label label_bugdescription;
        private System.Windows.Forms.Label label_bugtitle;
        private System.Windows.Forms.Label label_project;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.PictureBox pictureBox_BugImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ProjectURL;
        private System.Windows.Forms.LinkLabel linkLabel_ProjectURL;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Label label_ImagePath;
        private System.Windows.Forms.TextBox textBox_Project;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}