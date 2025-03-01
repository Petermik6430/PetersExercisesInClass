using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAbstractStart.Model
{
    internal class Dog : Animal
    {
        public Dog(string species, string breed) : base(species, breed)
        {
        }

        public override string PerformTrick()
        {
            return "Dog Sits";
        }

        public override string FeedAnimal()
        {
            return "Yum - Sauges";
        }


    }
}
