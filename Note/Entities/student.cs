using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Entities
{
    internal class student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int? Age { get; set; }

        public string Address { get; set; }

        //public ICollection<course> Courses { get; set; }

        public ICollection <StudentCourse> StudentCourses { get; set; }

    }
}