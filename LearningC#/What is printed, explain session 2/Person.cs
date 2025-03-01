using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_is_printed__explain_session_2
{
    internal class Person
    {

        public string? Name { get; set; }
        public string? Adress { get; set; }

        public Person(string? name, string? adress) 
        {
            this.Name = name;
            this.Adress = adress;
        }
    }
}
