using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelMenu.Models.dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public bool IsNonVeg { get; set; } = false;
        public string ProductImage { get; set; }
        public double Price { get; set; }
    }
}
