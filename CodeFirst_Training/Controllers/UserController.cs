using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst_Training.Models;
using CodeFirst_Training.Models.ViewModels;
using S05E01.OtherClasses;

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
                    Password = HashPass.GetSha256(NewStudent.Password),
                    RegisterDate = DateTime.Now,
                    isActive = true
                });

                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(NewStudent);
        }

        [HttpGet]
        public ActionResult LoginUser()
        {

            return View();
        }

        [HttpPost]
        public ActionResult LoginUser([Bind(Include = "UserName,Password")]LoginUserViewModel loginUser)
        {
            if (ModelState.IsValid)
            {
                string Pass = HashPass.GetSha256(loginUser.Password);

                var LoginUser = db.Users.FirstOrDefault(t => t.Phone == loginUser.UserName && t.Password == Pass);

                if (LoginUser == null)
                {
                    ModelState.AddModelError("UserName", "نام کاربری یا رمز عبور اشتباه است");
                }
                else
                {
                    return Redirect("https://www.varzesh3.com/");
                }

            }


            return View();
        }
    }

}