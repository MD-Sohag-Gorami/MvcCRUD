using MvcCRUD.Data;
using MvcCRUD.Interfaces;
using MvcCRUD.Models;

namespace MvcCRUD.Services
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _db;

        public CourseService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task DeleteAsync(Course course)
        {
            _db.courses.Remove(course);
        }

        public async Task<List<Course>> GetAllAsync()
        {
            return _db.courses.ToList();
        }

        public async Task<Course> GetByIdAsync(string id)
        {
            return _db.courses.FirstOrDefault(x => x.CourseID == id);
        }

        public async Task InsertAsync(Course course)
        {
            _db.courses.Add(course);
        }

        public async Task UpdateAsync(Course course)
        {
            _db.courses.Update(course);
        }
    }
}
