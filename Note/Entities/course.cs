using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Entities
{
    internal class course
    {
        public int ID { get; set; }

        public string Title { get; set; }

        //public ICollection <student> Students { get; set; }

        public ICollection  <StudentCourse> CourseStudents { get; set; }

        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();
    }
}
