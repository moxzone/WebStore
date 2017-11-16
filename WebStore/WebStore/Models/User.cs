﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WebStore.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int uid { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public DateTime regDate { get; set; }
    }

    
}