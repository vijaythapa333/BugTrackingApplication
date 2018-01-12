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
    public partial class BTA_BugList : Form
    {
        public BTA_BugList()
        {
            InitializeComponent();
        }

        private void button_AddBug_Click(object sender, EventArgs e)
        {
            //opening Bug Report Form
            BTA_BugReport bugreport = new BTA_BugReport();
            bugreport.Show();
            this.Hide();
        }
    }
}
