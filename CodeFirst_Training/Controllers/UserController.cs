using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst_Training.Models;
using CodeFirst_Training.Models.ViewModels;

namespace CodeFirst_Training.Controllers
{
    public class UserController : Controller
    {
        DbCodeFirstContext db=new DbCodeFirstContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        [HttpGet]
        public ActionResult StudentList()
        {
            var Students= db.Users.Select(t => new {t.Name,t.Family,t.Phone,t.AddressEmail}).ToList();

            List<StudentsViewModel> StudentsView = new List<StudentsViewModel>();

            foreach (var student in Students)
            {
                StudentsView.Add(new StudentsViewModel { Name = student.Name, Family = student.Family, Phone = student.Phone, Email = student.AddressEmail });


            }
            return View(StudentsView);
        }

        [HttpGet]
        public ActionResult RegisterNewStudent()
        {

            return View();
        }

        [HttpPost]
        public ActionResult RegisterNewStudent([Bind(Include = "Name,Family,Phone,Password,PasswordConfirm")]RegisterStudentsViewModel NewStudent)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(new User
                {
                    Name = NewStudent.Name,
                    Family = NewStudent.Family,
                    Phone = NewStudent.Phone,
                    AddressEmail = "newStudent@gmail.com",
                    Password = NewStudent.Password,
                    RegisterDate = DateTime.Now,
                    isActive = true
                });

                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(NewStudent);
        }
    }
}