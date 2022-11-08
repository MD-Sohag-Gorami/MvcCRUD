using AutoMapper;
using MvcCRUD.Models;
using MvcCRUD.ViewModel.StudentViewModel;

namespace MvcCRUD.Helpers
{
    public class Helper:Profile
    {
        public Helper()
        {
            CreateMap<Student, StudentViewModel>();
            CreateMap<CreateStudentViewModel, Student>();

        }
    }
}
