using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportsShop.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(25)]
        [MinLength(5)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25)]
        [MinLength(5)]
        public string LastName { get; set; }
        [Required]
        [StringLength(25)]
        [MinLength(5)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(10,100)]
        public int Age { get; set; }
        [Required]
        [StringLength(100)]
        [MinLength(5)]
        public string FullAddress { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }

    public class CustomersDbContext : DbContext
    {
        public System.Data.Entity.DbSet<SportsShop.Models.Customer> Customers { get; set; }
    }
}