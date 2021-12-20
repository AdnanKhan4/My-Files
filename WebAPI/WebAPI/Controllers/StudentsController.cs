using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class StudentsController : ApiController
    {
        private MyClass db = new MyClass();

        // GET: api/Students
        public IQueryable<Student> GetStudents()
        {
            return db.Students;
        }

       [HttpGet]
       [Route("Student/insert")]
       public string insertstudent(string Name, string Phone , string Email , string Password)
        {
            try
            {
                Student obj = new Student { Name = Name, Phone = Phone, Email = Email, Password = Password };
                db.Students.Add(obj);
                db.SaveChanges();
                return "inserted";

            }

            catch (Exception ex)
            {
                return "" + ex.Message;
            }
        }
    }
}