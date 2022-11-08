using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCRUD.Interfaces;
using MvcCRUD.Models;
using MvcCRUD.ViewModel.StudentViewModel;

namespace MvcCRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentCourseService _studentCourse;
        private IMapper _mapper;
        public StudentController(IStudentCourseService studentCourse, IMapper mapper)
        {
            _studentCourse = studentCourse;
            _mapper = mapper;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            var model = _studentCourse.student.GetAllAsync().Result;
            var vm = _mapper.Map<List<StudentViewModel>>(model);
            return View(vm);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateStudentViewModel viewModel)
        {
            try
            {
                var model = _mapper.Map<Student>(viewModel);
                 _studentCourse.student.Insert(model);
                _studentCourse.Save();
                return RedirectToAction("Index","Student");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
