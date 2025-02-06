using System;
using JavaToC_.Model;



namespace JavaToC_.Model
{


    internal class Manager
    {
    public static void Main(string[] args)
        {

            Employee eml = new Employee("Peter");

            eml.AddFavouriteWord("Jeg");
            eml.AddFavouriteWord("Elsker");
            eml.AddFavouriteWord("Anna");
            eml.AddFavouriteWord("Dinh");

            List<string?>? favWords = eml.FaverouriteWord;

            Console.WriteLine(" The Favourite word of " + eml.Name + ":");
            foreach(var favW in favWords)
            {
                Console.WriteLine(favW);
            }
        }


   
    }  
}