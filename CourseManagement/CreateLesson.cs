using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    internal class CreateLesson
    {
        public string CourseName { get; set; }
        public string Teacher_Name_Surname { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Weekdays { get; set; }
    }
}
