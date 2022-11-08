namespace MvcCRUD.Interfaces
{
    public interface IStudentCourseService
    {
        IStudentService student { get; }
        ICourseService course { get; }
        void Save();
    }
}
