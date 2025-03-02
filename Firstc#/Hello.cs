using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace Firstc_
{
    class Hello
    {
        public string? Name { get; set; }
        public Hello(string name)
        {
            Name = name;
        }

        public override string? ToString()
        {
            string str = "Hello " + Name;
            if (!IsNullOrWhiteSpace(str))
            {
                return "Error no Input";
            }
            return str;
        }
    }
}
