using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class UserDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}