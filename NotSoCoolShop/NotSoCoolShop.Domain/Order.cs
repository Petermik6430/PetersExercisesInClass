using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoCoolShop.Domain
{
   public class Order
    {
        public Order()
        {
            OrderLine = new OrderLine();
        }
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderLine OrderLine { get; set; }
        public Customer Customer { get; set; }
    }
}
