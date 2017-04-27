using System.Collections.Generic;
using System.Linq;
using ConsoleApplication.Models;
using ConsoleApplication.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class StudentController : Controller
    {
        //tightly Couple
        MyDbContext db = new MyDbContext();

        //Loosly Coupled
        private IStudentRepository studentRepository;

        public StudentController(IStudentRepository StudentRepository){
            this.studentRepository = studentRepository;
        }

        // Read
        [HttpGet]
        public IActionResult Index()
        {
            //List<Student> students = db.Students.ToList();
            IEnumerable<Student> students = studentRepository.GetAll();
            return View(students);
        }

        // Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create
        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                studentRepository.Save(st);
                //db.Students.Add(st);
                //db.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
        }

        // Update
        [HttpGet]
        public IActionResult Update(int id)
        {
            
            Student student = studentRepository.Get(id);
            //Student student = db.Students.Find(id);
           // studentRepository.Save(student);
            return View(student);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                studentRepository.Update(student);
                // db.Students.Update(student);
                // db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student student = db.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(Student st)
        {
            //Student student = db.Students.Find(st.StudentID);
            db.Students.Remove(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id){
            var student = studentRepository.Get(id);
            return View(student);
        }

    }
}