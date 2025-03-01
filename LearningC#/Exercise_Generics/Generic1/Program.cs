using Exercise_Generics.Generic1.Utilities;

namespace Exercise_Generics.Generic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper1 helper1 = new Helper1();

            Console.WriteLine("Comparison");
            // Integers
            int int1 = 5, int2 = 7;
            bool intEqual = Helper1.AreEqual(int1, int2);
            Console.WriteLine($"Integers {int1} and {int2} are equal: {intEqual}");
            // Decimals
            decimal dec1 = 5m, dec2 = 5.00m;
            bool decEqual = Helper1.AreEqual(dec1, dec2);
            Console.WriteLine($"Decimals {dec1} and {dec2} are equal: {decEqual}");
            // Strings
            string str1 = "Bad", str2 = "Good";
            bool strEqual = Helper1.AreEqual(str1, str2);
            Console.WriteLine($"Strings {str1} and {str2} are equal: {strEqual}");

            Helper2 helper2 = new Helper2();

            Console.WriteLine("Comparison");
            // Integers
            int int4 = 5, int5 = 7;
            bool intEqual2 = Helper2.AreEqual(int1, int2);
            Console.WriteLine($"Integers {int1} and {int2} are equal: {intEqual2}");
            // Decimals
            decimal dec4 = 5m, dec5 = 5.00m;
            bool decEqual2 = Helper2.AreEqual(dec1, dec2);
            Console.WriteLine($"Decimals {dec1} and {dec2} are equal: {decEqual2}");
            // Strings
            string str4 = "Bad", str5 = "Good";
            bool strEqual2 = Helper2.AreEqual(str1, str2);
            Console.WriteLine($"Strings {str1} and {str2} are equal: {strEqual2}");

        }
    }
}