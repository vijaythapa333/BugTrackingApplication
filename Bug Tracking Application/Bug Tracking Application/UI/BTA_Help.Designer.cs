namespace Bug_Tracking_Application.UI
{
    partial class BTA_Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTA_Help));
            this.label_Help = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox_CLose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CLose)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Help
            // 
            this.label_Help.AutoSize = true;
            this.label_Help.BackColor = System.Drawing.Color.Transparent;
            this.label_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Help.Location = new System.Drawing.Point(201, 9);
            this.label_Help.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Help.Name = "label_Help";
            this.label_Help.Size = new System.Drawing.Size(54, 24);
            this.label_Help.TabIndex = 0;
            this.label_Help.Text = "Help";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(419, 124);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Maroon;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Exit.Location = new System.Drawing.Point(158, 169);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(116, 48);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "EXIT";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox_CLose
            // 
            this.pictureBox_CLose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CLose.Image = global::Bug_Tracking_Application.Properties.Resources.Closeb;
            this.pictureBox_CLose.Location = new System.Drawing.Point(418, 9);
            this.pictureBox_CLose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_CLose.Name = "pictureBox_CLose";
            this.pictureBox_CLose.Size = new System.Drawing.Size(18, 18);
            this.pictureBox_CLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_CLose.TabIndex = 3;
            this.pictureBox_CLose.TabStop = false;
            this.pictureBox_CLose.Click += new System.EventHandler(this.pictureBox_CLose_Click);
            this.pictureBox_CLose.MouseLeave += new System.EventHandler(this.pictureBox_CLose_MouseLeave);
            this.pictureBox_CLose.MouseHover += new System.EventHandler(this.pictureBox_CLose_MouseHover);
            // 
            // BTA_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 226);
            this.Controls.Add(this.pictureBox_CLose);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Help);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BTA_Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTA_Help";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CLose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Help;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox_CLose;
    }
}