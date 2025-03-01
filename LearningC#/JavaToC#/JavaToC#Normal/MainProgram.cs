using System;
using JavaToC_.Model;



namespace JavaToC_.Model
{


    internal class Program
    {
    public static void Main(string[] args)
        {

            Person p1 = new Person("Peter", 2002);
            Person p2 = new Person("Anna", 1994);

            Console.WriteLine($"{p1} \n{p2}");
        }

   
    }  
}