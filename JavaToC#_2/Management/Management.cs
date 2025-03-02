
namespace JavaToC__2.db
{
    class Management
    {
        public static void Main(string[] args)
        {

            Employee e1 = new Employee("Hans");
            e1.AddFavoriteWord("Git");
            e1.AddFavoriteWord("Gut");
            e1.AddFavoriteWord("Got");
            List<string> words = e1.FavoriteWords;

            Console.WriteLine(e1);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}