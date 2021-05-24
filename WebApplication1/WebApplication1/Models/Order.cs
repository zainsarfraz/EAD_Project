using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order
    {
        public int id { get; set; }
        public DateTime orderTime { get; set; }
        public double amount { get; set; }
        public int itemCount { get; set; }
        public User User { get; set; }

        public string recordStatus { get; set; }
    }
}


