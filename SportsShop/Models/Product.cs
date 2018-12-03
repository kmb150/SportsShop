using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportsShop.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [MinLength(5)]
        public string Description { get; set; }

        [Required]
        [Range(0,999999)]
        public double Price { get; set; }

        [Required]
        public string DiscountCode { get; set; }

    }

    public class ProductDbContext: DbContext
    {
        public System.Data.Entity.DbSet<SportsShop.Models.Product> Products { get; set; }
    }
}