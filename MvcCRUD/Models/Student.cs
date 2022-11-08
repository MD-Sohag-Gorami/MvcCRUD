using System.ComponentModel.DataAnnotations;

namespace MvcCRUD.Models
{
    public class Student
    {
        public Student()
        {
            StudentCourses = new List<StudentCourse>();
        }
        [Key]
        public string   StudenId { get; set; }
        public string StudentName { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }
}
