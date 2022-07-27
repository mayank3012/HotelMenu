using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMenu.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string ProductName { get; set; }
        [MaxLength(1000)]
        public string ProductDescription { get; set; }
        public bool IsNonVeg { get; set; } = false;
        public string ProductImage { get; set; }
        public double Price { get; set; }
    }
}
