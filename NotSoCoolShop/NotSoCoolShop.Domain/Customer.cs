using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoCoolShop.Domain
{
    public class Customer
    {
        public Customer ()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
