using System;
using System.Collections.Generic;

namespace Final_Roneet.Model
{
    public partial class CourseAssignment
    {
        public string CourseId { get; set; }
        public int TeacherId { get; set; }
        public DateTime? AssignmentDate { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Teachers Teacher { get; set; }
    }
}
