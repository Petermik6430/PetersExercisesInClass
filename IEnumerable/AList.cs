using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class AList
    {

        public IEnumerable<string?>? SomeStrings { get; set; }

        public AList ()
        {
            SomeStrings = new List<string?> { null, "Hello", "Hans", "Hansen" };
        }



        public override string? ToString()
        {
            string str = $"{SomeStrings}";
                return str;
        }
    }
}
