using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var studentInfo = _context.Students.ToList();
            return View(studentInfo);
        }
        [HttpGet]
        public IActionResult Add()
        {
            //Student student = new Student();
            //var students = new Student();
            //return View(student);
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var studentinfo = _context.Students.FirstOrDefault(x => x.Id == id);
            return View(studentinfo);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var studentinfo = _context.Students.FirstOrDefault(x => x.Id == student.Id);
           

            studentinfo.FullName = student.FullName;
            studentinfo.RollNO = student.RollNO;
            studentinfo.Class = student.Class;
            studentinfo.Email = student.Email;
            studentinfo.PhoneNumber = student.PhoneNumber;
            _context.Update(studentinfo);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var studentinfo = _context.Students.FirstOrDefault(x => x.Id == id);
            return View(studentinfo);
        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            var studentinfo = _context.Students.FirstOrDefault(x => x.Id == student.Id);


            studentinfo.FullName = student.FullName;
            studentinfo.RollNO = student.RollNO;
            studentinfo.Class = student.Class;
            studentinfo.Email = student.Email;
            studentinfo.PhoneNumber = student.PhoneNumber;
            _context.Remove(studentinfo);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public IActionResult AddEdit(int id)
        {
            Student student = new Student();

            if (id>0)
            {
                var studentinfo = _context.Students.FirstOrDefault(x => x.Id == student.Id);

            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult AddEdit(Student student)
        {
            if (student.Id == 0)
            {
                _context.Add(student);
                _context.SaveChanges();
            }
            else
            {
                var studentinfo = _context.Students.FirstOrDefault(x => x.Id == student.Id);


                studentinfo.FullName = student.FullName;
                studentinfo.RollNO = student.RollNO;
                studentinfo.Class = student.Class;
                studentinfo.Email = student.Email;
                studentinfo.PhoneNumber = student.PhoneNumber;
                _context.Update(studentinfo);
                _context.SaveChanges();

            }


            return RedirectToAction(nameof(Index));
        }
    }
}
