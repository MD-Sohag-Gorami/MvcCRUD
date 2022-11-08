using System.ComponentModel.DataAnnotations;

namespace MvcCRUD.Models
{
    public class Course
    {
        public Course()
        {
            StudentCourses = new List<StudentCourse>();
        }
        [Key]
        public string CourseID { get; set; }   
        public string CourseName { get; set; }
        public string Description { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
