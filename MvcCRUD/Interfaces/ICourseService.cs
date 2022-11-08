using MvcCRUD.Models;

namespace MvcCRUD.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetAllAsync();
        Task<Course> GetByIdAsync(string id);
        Task InsertAsync(Course course);
        Task DeleteAsync(Course course);
        Task UpdateAsync(Course course);

    }
}
