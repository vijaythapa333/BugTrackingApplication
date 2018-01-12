using Bug_Tracking_Application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracking_Application.UI
{
    public partial class BTA_Help : Form
    {
        public BTA_Help()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            string type = Form1.UserType;
            if (type == "Admin")
            {
                BTA_Admin_Panel admin = new BTA_Admin_Panel();
                admin.Show();
                this.Hide();
            }
            else
            {
                BTA_HomePage home = new BTA_HomePage();
                home.Show();
                this.Hide();
            }
        }

        private void pictureBox_CLose_MouseHover(object sender, EventArgs e)
        {
            pictureBox_CLose.Image = Resources.close;
        }

        private void pictureBox_CLose_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_CLose.Image = Resources.Closeb;
        }

        private void pictureBox_CLose_Click(object sender, EventArgs e)
        {
            string type = Form1.UserType;
            if(type=="Admin")
            {
                BTA_Admin_Panel admin = new BTA_Admin_Panel();
                admin.Show();
                this.Hide();
            }
            else
            {
                BTA_HomePage home = new BTA_HomePage();
                home.Show();
                this.Close();
            }
            
        }
    }
}
