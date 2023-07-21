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
    public partial class Student
    {
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }


    [ModelMetadataType(typeof(EnrollmentsMetadata))]
    public partial class Enrollment { }

    [ModelMetadataType(typeof(CoursesMetadata))]
    public partial class Course { }

    [ModelMetadataType(typeof(ScheduledClassesMetadata))]
    public partial class ScheduledClass
    {
        public string? ClassInfo
        {
            get
            {
                if (Course == null)
                {
                    return null;
                }
                else
                {
                    return $"{Course.CourseName} - {StartDate:d}";
                }
            }
        }
    }

    [ModelMetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }

    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }
}


