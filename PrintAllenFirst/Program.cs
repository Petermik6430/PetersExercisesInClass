
using System.Security.Cryptography.X509Certificates;

namespace PrintAllenFirst
{

    internal class Program
    {
      static void Main()
        {
            // Declare someNames and assign some values to the variable

            IList<string> someNames = new List<string>() { null, "Egon", "Hans", "Kurt"};

           

            ChangeName(someNames);

            Console.WriteLine("First name:" + someNames[0]);
            foreach (string name in someNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();


        }

        public static void ChangeName(IList<string> names)
        {
            names[0] = "Allen";

            
        }
    }
}