using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Bug_Tracking_Application.Classes
{
    public class Bugs
    {
        public int BugID { get; set; }
        public int ProjectTitle { get; set; }
        public string BugTitle { get; set; }
        public string BugDescription { get; set; }
        public string Severity { get; set; }
        public string Status { get; set; }
        public string ReportDate { get; set; }
        public Image BugImage { get; set; }
        public string SubmitCode { get; set; }
        public int AssignTo { get; set; }
        public string ImagePath { get; set; }   
    }
}
