using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_Generics.Generic2_NonGeneric.Model;

namespace Exercise_Generics.Generic2_NonGeneric
{
    internal class OrderedPairCity : IPairable
    {
        public OrderedPairCity(City first, City second)
        {
            First = first;
            Second = second;
        }

        public void ChangeOrder()
        {
            City temp = First;
            First = Second;
            Second = temp;
        }

        public City First { get; set; }
        public City Second { get; set; }

        public override string ToString()
        {
            return $"First: {First} \nSecond: {Second}";
        }
    }
}
