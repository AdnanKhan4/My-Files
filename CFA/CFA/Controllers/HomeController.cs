using CFA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CFA.Controllers
{
    public class HomeController : Controller
    {
        StudentDbContext db = new StudentDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Student std, bool ch_html, bool ch_android, bool ch_java)
        {
          
            string subjects = "";
            if (ch_html) subjects = "HTML ";
            if (ch_android) subjects += "Android ";
            if (ch_java) subjects += "Java ";


            std.Subjects = subjects;
            db.Students.Add(std);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}