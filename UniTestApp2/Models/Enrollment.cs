using System.ComponentModel.DataAnnotations;

namespace UniTestApp2.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //These are teh Properties of the "Enrollment"
        public int EnrollmentID { get; set; }
       
     
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        //one to many connection
        public int CourseID { get; set; }
        public virtual Course Course { get; set;}
        //one to many connection
        public int StudentID { get; set; }
        public virtual Student Student { get; set;}

    }

}