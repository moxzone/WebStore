using System.Data.Entity;

namespace WebStore.Models
{
    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}