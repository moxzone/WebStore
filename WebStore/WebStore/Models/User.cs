using System;
using System.Data.Entity;

namespace WebStore.Models
{
    public class User
    {
        public int uid { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public DateTime regDate { get; set; }
    }

    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}