using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst_Training.Models;

namespace CodeFirst_Training.Controllers
{
    public class UserController : Controller
    {
        DbCodeFirstContext db=new DbCodeFirstContext();

        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
    }
}