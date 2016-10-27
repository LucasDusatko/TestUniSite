using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniTestApp2.Models
{
    public class Student
    {
        //These are teh Properties of the "Student"
        public int ID { get; set; }
        //Last Name
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //First Name 
        [StringLength(50, MinimumLength = 2,  ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        //Email 
        public string Email { get; set; }

        //Date
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public string Secret { get; set; }

        /// <summary>
        /// Combines Names to create full name, callable from class, nice right.
        /// </summary>
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        //This is a navigation property. A Many-To-Many Relationship
        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}