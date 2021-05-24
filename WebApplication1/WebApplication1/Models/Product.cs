using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        public User User { get; set; }
        public Shop Shop { get; set; }

        public List<ProductImage> images { get; set; }
    }
}
