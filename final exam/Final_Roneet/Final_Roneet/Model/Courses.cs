using System;
using System.Collections.Generic;

namespace Final_Roneet.Model
{
    public partial class Courses
    {
        public Courses()
        {
            CourseAssignment = new HashSet<CourseAssignment>();
        }

        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<CourseAssignment> CourseAssignment { get; set; }
    }
}
