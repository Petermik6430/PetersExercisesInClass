using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoCoolShop.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public decimal Price { get; set; }

        public override string? ToString()
        {
            return Title +"("+ Price+ ")";
        }
    }
}
