using System.Collections.Generic;

namespace ConsoleApplication.Models
{
    public class Course
    {
         public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //navigation property
        public virtual IEnumerable<Enrollment> Enrollments { get; set; }
    }
}