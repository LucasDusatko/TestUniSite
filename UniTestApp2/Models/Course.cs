﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniTestApp2.Models
{
    public class Course
    {

        ////These are teh Properties of the "Course"
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        //One to one
        public virtual Department Department { get; set; }
        //one to many
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        //one to many
        public virtual ICollection<Instructor> Instructors { get; set; }


    }
}