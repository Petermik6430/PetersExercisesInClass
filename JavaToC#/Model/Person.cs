using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToC_.Model
{
    class Person
    {
        public string Name { get; set; }
        public int YearOfBirth{ get; set; }

        public Person(string name, int yearOfBirth)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
        }

        public override string? ToString()
        {
            string str = string.Format($"Name: {Name}, Year of Birth: {YearOfBirth}");
            return str;
        }
    }
}
