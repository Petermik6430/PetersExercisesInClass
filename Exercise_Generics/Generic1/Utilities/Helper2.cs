using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics.Generic1.Utilities
{
    internal class Helper2
    {
        public static bool AreEqual<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }

    }
}
