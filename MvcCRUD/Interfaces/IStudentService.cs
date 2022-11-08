using MvcCRUD.Models;

namespace MvcCRUD.Interfaces
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllAsync();
        Task<Student> GetByIdAsync(string id);
        Task Insert(Student student);
        Task DeleteAsync(Student student);
        Task UpdateAsync(Student student);

    }
}
