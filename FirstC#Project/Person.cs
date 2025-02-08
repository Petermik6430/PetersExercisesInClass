using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FirstC_Project
{
    internal class Person
    {

        public Person(string? helloStr)
        {
            HelloStr = helloStr;
        }

        public string? HelloStr {  get; set; }

        // man kan også bruge metoden neden under.
        // Men bruges kun vis man ønsker at ændre logikken.

     //   public static bool IsNullOrWhiteSpace(string? value)
     //   {
     //       return !string.IsNullOrWhiteSpace(value);
     //   }



        public override string? ToString()
        {
          

            string? str = $"{HelloStr}";

            if (String.IsNullOrWhiteSpace(str))
            {

                return "error";
            }
            else 
            {
                return str;
            }
            
        }
    }

   
}
