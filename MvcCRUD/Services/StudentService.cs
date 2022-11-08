using MvcCRUD.Data;
using MvcCRUD.Interfaces;
using MvcCRUD.Models;

namespace MvcCRUD.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _db;

        public StudentService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task DeleteAsync(Student student)
        {
            _db.Students.Remove(student);
        }

        public async Task<List<Student>> GetAllAsync()
        {
           return  _db.Students.ToList();
        }

        public async Task<Student> GetByIdAsync(string id)
        {
            return _db.Students.FirstOrDefault(x => x.StudenId == id);
        }

        public async Task Insert(Student student)
        {
            _db.Students.Add(student);
           _db.SaveChanges();
        }

        public async Task UpdateAsync(Student student)
        {
           _db.Students.Update(student);
        }
    }
}
