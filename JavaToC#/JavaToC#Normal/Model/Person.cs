using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToC_.Model
{
    internal class Person
    {

        public Person(string? name, int yearOfBirth)
        {
            Name = name;
            YearOfBirth = yearOfBirth;

        }
        public string? Name { get; set; }
        public int YearOfBirth { get; set; }

        public override string? ToString()
        {
            string? str = $"{Name} {YearOfBirth}";
            return str;
        }
    }


}
