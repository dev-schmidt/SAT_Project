using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT_Project.DATA.EF.MetaData
{
    public class EnrollmentsMetadata 
    {
        [Required(ErrorMessage = "Enrollment ID is required")]
        [Display(Name = "EnrollmentId")]
        public int EnrollmentId { get; set; }

        [Required(ErrorMessage = "Student ID is required")]
        [Display(Name = "StudentId")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Scheduled class ID is required")]
        [Display(Name = "ScheduledClassId")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "Enrollment date is required")]
        [Display(Name = "EnrollmentDate")]
        public DateTime EnrollmentDate { get; set; }
    }

    public class CoursesMetadata
    {
        [Required(ErrorMessage = "Course ID is required")]
        [Display(Name = "CourseId")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [StringLength(50, ErrorMessage = "*Max 50 characters")]
        [Display(Name = "CourseName")]
        public string CourseName { get; set; } = null!;

        [Required(ErrorMessage = "Course description is required")]
        [StringLength(500, ErrorMessage = "*Max 500 characters")]
        [Display(Name = "CourseDescription")]
        public string CourseDescription { get; set; } = null!;

        [Required(ErrorMessage = "Amount of credit hours is required")]
        [Display(Name = "CreditHours")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "*Max 250 characters")]
        [Display(Name = "Curriculum")]
        public string? Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "*Max 500 characters")]
        [Display(Name = "Notes")]
        public string? Notes { get; set; }

        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
    }

    public class StudentsMetadata
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20, ErrorMessage = "*Max 20 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, ErrorMessage = "*Max 20 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;


        [StringLength(15, ErrorMessage = "*Max 15 characters")]
        public string? Major { get; set; }

        [StringLength(50, ErrorMessage = "*Max 50 characters")]
        public string? Addresss { get; set; }

        [StringLength(2, ErrorMessage = "*Max 2 characters")]
        public string? State { get; set; }

        [StringLength(7, ErrorMessage = "*Max 7 characters")]
        [DataType(DataType.PostalCode)]
        public string? ZipCode { get; set; }

        [StringLength(13, ErrorMessage = "*Max 13 characters")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [StringLength(60, ErrorMessage = "*Max 60 characters")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [StringLength(100, ErrorMessage = "*Max 100 characters")]
        public string? PhotoUrl { get; set; }

    }

    public class SheduledClassesMetadata
    {
        [Required(ErrorMessage = "Start Date Required")]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date Required")]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Instructor Name Required")]
        [StringLength(40, ErrorMessage = "*Maximum 40 characters")]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; } = null!;

        [Required(ErrorMessage = "Location Required")]
        [StringLength(20, ErrorMessage = "*Maximum 20 characters")]
        public string Location { get; set; } = null!;

    }

    public class Enrollments
    {
        [Required(ErrorMessage = "Enrollment Date Required")]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }

    public class SudentStatues
    {
        [Required(ErrorMessage = "Student Service Name Required")]
        [StringLength(40, ErrorMessage = "*Maximum 30 characters")]
        [Display(Name = "Student Service Name")]
        public string SSName { get; set; } = null!;

        [StringLength(40, ErrorMessage = "*Maximum 250 characters")]
        [Display(Name = "Student Service Description")]
        public string? SSDescription { get; set; } = null!;
    }

}
