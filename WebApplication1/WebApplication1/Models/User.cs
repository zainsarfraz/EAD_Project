using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int? shopId { get; set; }
        public string phoneNo { get; set; }
        public string address { get; set; }

        public string email { get; set; }
        public string password { get; set; }
        public string recordStatus { get; set; }

        public string profilePicPath { get; set; }
    
    }
}

public enum recordStatus
{
    pending,
    approved,
    delete,
    delivered
}
public enum userType
{
    admin,
    customer,
    vendor
}