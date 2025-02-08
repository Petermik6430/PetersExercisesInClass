


using FirstC_Challenge;
using System.Text;

namespace FirstC_Challenge

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person persons = new Person();

           
            foreach (var person in persons.Persons)
            {
                if (String.IsNullOrWhiteSpace(person))
                {
                    Console.WriteLine(person);
                }

            }


        }

    }

}


