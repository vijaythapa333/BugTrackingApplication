using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracking_Application.Classes
{
    class Project
    {
        public int ProjectID { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectUrl { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
