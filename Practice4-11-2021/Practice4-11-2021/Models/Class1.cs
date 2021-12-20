using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practice4_11_2021.Models
{
    public class Class1:DbContext
    {
        public DbSet<User> Users { get; set; }
    }

    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}