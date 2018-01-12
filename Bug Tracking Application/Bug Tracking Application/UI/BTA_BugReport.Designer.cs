namespace Bug_Tracking_Application
{
    partial class BTA_BugReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTA_BugReport));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_ManageBugs = new System.Windows.Forms.Label();
            this.label_project = new System.Windows.Forms.Label();
            this.label_bugtitle = new System.Windows.Forms.Label();
            this.label_bugdescription = new System.Windows.Forms.Label();
            this.label_severity = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_reportdate = new System.Windows.Forms.Label();
            this.textBox_bugtitle = new System.Windows.Forms.TextBox();
            this.textBox_bugdescription = new System.Windows.Forms.TextBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.comboBox_severity = new System.Windows.Forms.ComboBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_reportdate = new System.Windows.Forms.DateTimePicker();
            this.label_BugImage = new System.Windows.Forms.Label();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_addbug = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_BugID = new System.Windows.Forms.Label();
            this.textBox_BugID = new System.Windows.Forms.TextBox();
            this.dataGridView_Bugs = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_SubmitCode = new System.Windows.Forms.Label();
            this.pictureBox_BugImage = new System.Windows.Forms.PictureBox();
            this.pictureBox_CLose = new System.Windows.Forms.PictureBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_path = new System.Windows.Forms.Label();
            this.richTextBox_submitCode = new System.Windows.Forms.RichTextBox();
            this.button_push = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BugImage)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label_ManageBugs
            // 
            this.label_ManageBugs.AutoSize = true;
            this.label_ManageBugs.BackColor = System.Drawing.Color.Transparent;
            this.label_ManageBugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ManageBugs.Location = new System.Drawing.Point(441, 34);
            this.label_ManageBugs.Name = "label_ManageBugs";
            this.label_ManageBugs.Size = new System.Drawing.Size(119, 20);
            this.label_ManageBugs.TabIndex = 1;
            this.label_ManageBugs.Text = "Manage Bugs";
            // 
            // label_project
            // 
            this.label_project.AutoSize = true;
            this.label_project.BackColor = System.Drawing.Color.Transparent;
            this.label_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project.Location = new System.Drawing.Point(27, 104);
            this.label_project.Name = "label_project";
            this.label_project.Size = new System.Drawing.Size(50, 16);
            this.label_project.TabIndex = 2;
            this.label_project.Text = "Project";
            // 
            // label_bugtitle
            // 
            this.label_bugtitle.AutoSize = true;
            this.label_bugtitle.BackColor = System.Drawing.Color.Transparent;
            this.label_bugtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bugtitle.Location = new System.Drawing.Point(27, 139);
            this.label_bugtitle.Name = "label_bugtitle";
            this.label_bugtitle.Size = new System.Drawing.Size(61, 16);
            this.label_bugtitle.TabIndex = 3;
            this.label_bugtitle.Text = "Bug Title";
            // 
            // label_bugdescription
            // 
            this.label_bugdescription.AutoSize = true;
            this.label_bugdescription.BackColor = System.Drawing.Color.Transparent;
            this.label_bugdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bugdescription.Location = new System.Drawing.Point(27, 202);
            this.label_bugdescription.Name = "label_bugdescription";
            this.label_bugdescription.Size = new System.Drawing.Size(103, 16);
            this.label_bugdescription.TabIndex = 4;
            this.label_bugdescription.Text = "Bug Description";
            // 
            // label_severity
            // 
            this.label_severity.AutoSize = true;
            this.label_severity.BackColor = System.Drawing.Color.Transparent;
            this.label_severity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_severity.Location = new System.Drawing.Point(27, 468);
            this.label_severity.Name = "label_severity";
            this.label_severity.Size = new System.Drawing.Size(57, 16);
            this.label_severity.TabIndex = 5;
            this.label_severity.Text = "Severity";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(27, 391);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(45, 16);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "Status";
            // 
            // label_reportdate
            // 
            this.label_reportdate.AutoSize = true;
            this.label_reportdate.BackColor = System.Drawing.Color.Transparent;
            this.label_reportdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reportdate.Location = new System.Drawing.Point(27, 431);
            this.label_reportdate.Name = "label_reportdate";
            this.label_reportdate.Size = new System.Drawing.Size(81, 16);
            this.label_reportdate.TabIndex = 7;
            this.label_reportdate.Text = "Report Date";
            // 
            // textBox_bugtitle
            // 
            this.textBox_bugtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bugtitle.Location = new System.Drawing.Point(188, 139);
            this.textBox_bugtitle.Name = "textBox_bugtitle";
            this.textBox_bugtitle.Size = new System.Drawing.Size(200, 22);
            this.textBox_bugtitle.TabIndex = 8;
            // 
            // textBox_bugdescription
            // 
            this.textBox_bugdescription.Location = new System.Drawing.Point(188, 172);
            this.textBox_bugdescription.Multiline = true;
            this.textBox_bugdescription.Name = "textBox_bugdescription";
            this.textBox_bugdescription.Size = new System.Drawing.Size(200, 85);
            this.textBox_bugdescription.TabIndex = 9;
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(188, 104);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProject.TabIndex = 11;
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
            this.comboBox_severity.Location = new System.Drawing.Point(188, 468);
            this.comboBox_severity.Name = "comboBox_severity";
            this.comboBox_severity.Size = new System.Drawing.Size(200, 24);
            this.comboBox_severity.TabIndex = 12;
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
            this.comboBox_status.Location = new System.Drawing.Point(188, 391);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(200, 24);
            this.comboBox_status.TabIndex = 13;
            // 
            // dateTimePicker_reportdate
            // 
            this.dateTimePicker_reportdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_reportdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_reportdate.Location = new System.Drawing.Point(188, 431);
            this.dateTimePicker_reportdate.Name = "dateTimePicker_reportdate";
            this.dateTimePicker_reportdate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_reportdate.TabIndex = 14;
            // 
            // label_BugImage
            // 
            this.label_BugImage.AutoSize = true;
            this.label_BugImage.BackColor = System.Drawing.Color.Transparent;
            this.label_BugImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BugImage.Location = new System.Drawing.Point(423, 394);
            this.label_BugImage.Name = "label_BugImage";
            this.label_BugImage.Size = new System.Drawing.Size(73, 16);
            this.label_BugImage.TabIndex = 15;
            this.label_BugImage.Text = "Bug Image";
            // 
            // button_browse
            // 
            this.button_browse.BackColor = System.Drawing.Color.SteelBlue;
            this.button_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_browse.Location = new System.Drawing.Point(514, 539);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(89, 36);
            this.button_browse.TabIndex = 16;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = false;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_addbug
            // 
            this.button_addbug.BackColor = System.Drawing.Color.Green;
            this.button_addbug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addbug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addbug.Location = new System.Drawing.Point(193, 539);
            this.button_addbug.Name = "button_addbug";
            this.button_addbug.Size = new System.Drawing.Size(92, 38);
            this.button_addbug.TabIndex = 17;
            this.button_addbug.Text = "SAVE";
            this.button_addbug.UseVisualStyleBackColor = false;
            this.button_addbug.Click += new System.EventHandler(this.button_addbug_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Navy;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reset.Location = new System.Drawing.Point(302, 539);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(86, 38);
            this.button_reset.TabIndex = 18;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_BugID
            // 
            this.label_BugID.AutoSize = true;
            this.label_BugID.BackColor = System.Drawing.Color.Transparent;
            this.label_BugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BugID.Location = new System.Drawing.Point(27, 75);
            this.label_BugID.Name = "label_BugID";
            this.label_BugID.Size = new System.Drawing.Size(48, 16);
            this.label_BugID.TabIndex = 21;
            this.label_BugID.Text = "Bug ID";
            // 
            // textBox_BugID
            // 
            this.textBox_BugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BugID.Location = new System.Drawing.Point(188, 75);
            this.textBox_BugID.Name = "textBox_BugID";
            this.textBox_BugID.ReadOnly = true;
            this.textBox_BugID.Size = new System.Drawing.Size(200, 22);
            this.textBox_BugID.TabIndex = 22;
            // 
            // dataGridView_Bugs
            // 
            this.dataGridView_Bugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bugs.Location = new System.Drawing.Point(426, 104);
            this.dataGridView_Bugs.Name = "dataGridView_Bugs";
            this.dataGridView_Bugs.Size = new System.Drawing.Size(540, 275);
            this.dataGridView_Bugs.TabIndex = 23;
            this.dataGridView_Bugs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Bugs_RowHeaderMouseClick);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(426, 75);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(446, 22);
            this.textBox_Search.TabIndex = 24;
            this.textBox_Search.Text = "SEARCH";
            this.textBox_Search.Click += new System.EventHandler(this.textBox_Search_Click);
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            this.textBox_Search.Leave += new System.EventHandler(this.textBox_Search_Leave);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Delete.Location = new System.Drawing.Point(411, 539);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(86, 38);
            this.button_Delete.TabIndex = 25;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_SubmitCode
            // 
            this.label_SubmitCode.AutoSize = true;
            this.label_SubmitCode.BackColor = System.Drawing.Color.Transparent;
            this.label_SubmitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SubmitCode.Location = new System.Drawing.Point(27, 312);
            this.label_SubmitCode.Name = "label_SubmitCode";
            this.label_SubmitCode.Size = new System.Drawing.Size(85, 16);
            this.label_SubmitCode.TabIndex = 26;
            this.label_SubmitCode.Text = "Submit Code";
            // 
            // pictureBox_BugImage
            // 
            this.pictureBox_BugImage.Location = new System.Drawing.Point(514, 394);
            this.pictureBox_BugImage.Name = "pictureBox_BugImage";
            this.pictureBox_BugImage.Size = new System.Drawing.Size(452, 139);
            this.pictureBox_BugImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_BugImage.TabIndex = 30;
            this.pictureBox_BugImage.TabStop = false;
            // 
            // pictureBox_CLose
            // 
            this.pictureBox_CLose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CLose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CLose.Image")));
            this.pictureBox_CLose.Location = new System.Drawing.Point(961, 1);
            this.pictureBox_CLose.Name = "pictureBox_CLose";
            this.pictureBox_CLose.Size = new System.Drawing.Size(23, 23);
            this.pictureBox_CLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_CLose.TabIndex = 31;
            this.pictureBox_CLose.TabStop = false;
            this.pictureBox_CLose.Click += new System.EventHandler(this.pictureBox_CLose_Click);
            this.pictureBox_CLose.MouseLeave += new System.EventHandler(this.pictureBox_CLose_MouseLeave);
            this.pictureBox_CLose.MouseHover += new System.EventHandler(this.pictureBox_CLose_MouseHover);
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(878, 75);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(88, 23);
            this.button_Search.TabIndex = 32;
            this.button_Search.Text = "SEARCH";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.BackColor = System.Drawing.Color.Transparent;
            this.label_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_path.Location = new System.Drawing.Point(609, 552);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(84, 16);
            this.label_path.TabIndex = 33;
            this.label_path.Text = "[Image Path]";
            // 
            // richTextBox_submitCode
            // 
            this.richTextBox_submitCode.Location = new System.Drawing.Point(188, 266);
            this.richTextBox_submitCode.Name = "richTextBox_submitCode";
            this.richTextBox_submitCode.Size = new System.Drawing.Size(200, 112);
            this.richTextBox_submitCode.TabIndex = 34;
            this.richTextBox_submitCode.Text = "";
            this.richTextBox_submitCode.TextChanged += new System.EventHandler(this.richTextBox_submitCode_TextChanged);
            // 
            // button_push
            // 
            this.button_push.BackColor = System.Drawing.Color.Purple;
            this.button_push.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_push.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_push.Location = new System.Drawing.Point(79, 538);
            this.button_push.Name = "button_push";
            this.button_push.Size = new System.Drawing.Size(92, 38);
            this.button_push.TabIndex = 35;
            this.button_push.Text = "PUSH";
            this.button_push.UseVisualStyleBackColor = false;
            this.button_push.Click += new System.EventHandler(this.button_push_Click);
            // 
            // BTA_BugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 591);
            this.Controls.Add(this.button_push);
            this.Controls.Add(this.richTextBox_submitCode);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.pictureBox_CLose);
            this.Controls.Add(this.pictureBox_BugImage);
            this.Controls.Add(this.label_SubmitCode);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView_Bugs);
            this.Controls.Add(this.textBox_BugID);
            this.Controls.Add(this.label_BugID);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_addbug);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.label_BugImage);
            this.Controls.Add(this.dateTimePicker_reportdate);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.comboBox_severity);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.textBox_bugdescription);
            this.Controls.Add(this.textBox_bugtitle);
            this.Controls.Add(this.label_reportdate);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_severity);
            this.Controls.Add(this.label_bugdescription);
            this.Controls.Add(this.label_bugtitle);
            this.Controls.Add(this.label_project);
            this.Controls.Add(this.label_ManageBugs);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BTA_BugReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTA_BugReport";
            this.Load += new System.EventHandler(this.BTA_BugReport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BugImage)).EndInit();
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
        private System.Windows.Forms.Label label_ManageBugs;
        private System.Windows.Forms.Label label_project;
        private System.Windows.Forms.Label label_bugtitle;
        private System.Windows.Forms.Label label_bugdescription;
        private System.Windows.Forms.Label label_severity;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_reportdate;
        private System.Windows.Forms.TextBox textBox_bugtitle;
        private System.Windows.Forms.TextBox textBox_bugdescription;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.ComboBox comboBox_severity;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reportdate;
        private System.Windows.Forms.Label label_BugImage;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_addbug;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_BugID;
        private System.Windows.Forms.TextBox textBox_BugID;
        private System.Windows.Forms.DataGridView dataGridView_Bugs;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label_SubmitCode;
        private System.Windows.Forms.PictureBox pictureBox_BugImage;
        private System.Windows.Forms.PictureBox pictureBox_CLose;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.RichTextBox richTextBox_submitCode;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button_push;
    }
}