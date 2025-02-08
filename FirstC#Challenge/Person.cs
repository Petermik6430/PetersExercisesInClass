using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Challenge
{
    internal class Person
    {

        public Person() 
        {
            Persons = new List<string>() { "Hello", "Hans" , " ", "Hansen", null };
        }
        public IEnumerable<string?>? Persons { get; set; }

        public override string? ToString()
        {

            string str = $"{Persons}";
            return str;
        }
    }
}
