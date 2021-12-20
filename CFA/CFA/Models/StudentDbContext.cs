using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CFA.Models
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
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Subjects { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
      


    }
}