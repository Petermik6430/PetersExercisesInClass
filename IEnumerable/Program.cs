
using System.Linq;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            AList listOfWord = new AList();
            List<string> numberOfEntries = new List<string>();
            int characters = 0;


            foreach (var word in listOfWord.SomeStrings)
            {
                if (string.IsNullOrWhiteSpace(word) || listOfWord == null)
                {
                    Console.WriteLine("Error no Input");

                }
                else
                {
                    Console.WriteLine(word);
                    numberOfEntries.Add(word);
                    characters += word.Length;

                }

            }
            Console.WriteLine( $"Numbers of entries: {numberOfEntries.Count}");
            //Console.WriteLine($"Numbers of entries {listOfWord.SomeStrings.Count()}");
            Console.WriteLine($"Numbers of entries: {characters}");


        }   
        
    }
}



