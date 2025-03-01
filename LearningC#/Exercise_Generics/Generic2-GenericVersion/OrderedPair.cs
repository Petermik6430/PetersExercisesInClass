using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_Generics.Generic2_NonGeneric.Model;

namespace Exercise_Generics.Generic2_GenericVersion
{
    internal class OrderedPair<T> : IPairable<T>
    {
        public OrderedPair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public void ChangeOrder()
        {
            T temp = First;
            First = Second;
            Second = temp;
        }

        public T First { get; set; }
        public T Second { get; set; }

        public override string ToString()
        {
            return $"First: {First} \nSecond: {Second}";
        }
    }
}
