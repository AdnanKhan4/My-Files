using Practice4_11_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice4_11_2021.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Class1 db = new Class1();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            User obj = db.Users.FirstOrDefault(i => i.Email == email && i.Password == password);
            if (obj==null)
            {
                ViewBag.msg = "incorrect Email or Password ";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Users");
            }
        }
    }
}