using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_Generics.Generic2_NonGeneric.Model;

namespace Exercise_Generics.Generic2_NonGeneric
{
    internal class Manager
    {
        public static void Main(string[] args)
        {
            OrderedPairString fruit = new OrderedPairString("apple", "banana");
            Console.WriteLine("Order of strings");
            Console.WriteLine(fruit);
            fruit.ChangeOrder();
            Console.WriteLine("Order changed!");
            Console.WriteLine(fruit);
            // OrderedPair type int
            OrderedPairInteger numbers = new OrderedPairInteger(9, 11);
            Console.WriteLine(Environment.NewLine + "Order of integers");
            Console.WriteLine(numbers);
            numbers.ChangeOrder();
            Console.WriteLine("Order changed!");
            Console.WriteLine(numbers);
            // OrderedPair type City
            City aCity = new City("Nuuk", 40000);
            City bCity = new City("Thorshavn", 20000);
            OrderedPairCity cities = new OrderedPairCity(aCity, bCity);
            Console.WriteLine(Environment.NewLine + "Order of cities");
            Console.WriteLine(cities);
            cities.ChangeOrder();
            Console.WriteLine("Order changed!");
            Console.WriteLine(cities);
            Console.ReadLine();
        }
    }

}
