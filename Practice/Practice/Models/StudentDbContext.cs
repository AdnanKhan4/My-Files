using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentDbContext():base("conn")
        {

        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public byte[] img { get; set; }
    }
}