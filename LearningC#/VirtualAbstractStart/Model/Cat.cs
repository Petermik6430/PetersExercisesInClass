using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractStart.Model
{
    internal class Cat : Animal
    {
        public Cat(string species, string breed) : base(species, breed)
        {
        }

        public override string PerformTrick()
        {
            return "Jump very high";
        }
    }
}
