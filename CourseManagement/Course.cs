using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int Price { get; set; }
        public string CreationTime { get; set; }
        public string ModificationTime { get; set; }
        public int Duration { get; set; }
    }
}
