using System;
using System.Collections.Generic;

namespace SAT_Project.DATA.EF.Models
{
    public partial class ScheduledClass
    {
        public ScheduledClass()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InstructorName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int Scisid { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual ScheduledClassStatus Scis { get; set; } = null!;
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
