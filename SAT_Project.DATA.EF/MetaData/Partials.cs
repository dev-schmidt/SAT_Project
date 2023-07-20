using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace SAT_Project.DATA.EF.Models
{
    [ModelMetadataType(typeof(StudentsMetadata))]
    public partial class Students {}

    [ModelMetadataType(typeof(EnrollmentsMetadata))]
    public partial class Enrollments { }

    [ModelMetadataType(typeof(CoursesMetadata))]
    public partial class Courses { }

    [ModelMetadataType(typeof(ScheduledClassesMetadata))]
    public partial class ScheduledClasses { }

    [ModelMetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }

    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }
}


