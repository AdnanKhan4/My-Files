using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
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
        public ActionResult Create(Student obj)
        {
            db.Students.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}