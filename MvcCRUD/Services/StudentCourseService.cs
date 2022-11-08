using MvcCRUD.Data;
using MvcCRUD.Interfaces;

namespace MvcCRUD.Services
{
    public class StudentCourseService : IStudentCourseService
    {
        private readonly ApplicationDbContext _db;
        private StudentService _studentService;
        private CourseService _courseService;
        public StudentCourseService(ApplicationDbContext db)
        {
            _db = db;
        }
        public IStudentService student
        {
            get { return _studentService = _studentService ?? new StudentService(_db); }
        }

        public ICourseService course
        {
            get
            {
                return _courseService = _courseService ?? new CourseService(_db); 
            }
        }

        public void Save()
        {
           _db.SaveChanges();
        }
    }
}
