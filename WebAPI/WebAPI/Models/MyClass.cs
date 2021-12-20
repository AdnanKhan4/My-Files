using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class MyClass:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}