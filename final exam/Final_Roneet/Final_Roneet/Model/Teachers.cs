using System;
using System.Collections.Generic;

namespace Final_Roneet.Model
{
    public partial class Teachers
    {
        public Teachers()
        {
            CourseAssignment = new HashSet<CourseAssignment>();
        }

        public int TeacherId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CourseAssignment> CourseAssignment { get; set; }
    }
}
