using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int uid { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

    }
}