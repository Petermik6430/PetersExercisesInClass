

using ObjectInit.Model;

//DateTime dateTime = new DateTime(1994, 12, 13);

//Person person1 = new Person(new DateTime(1994, 12, 13), "Hans");

//Person person2 = new Person(new DateTime(1994, 12, 13, 12, 1, 14), "Bob");

//Person person3 = new Person();




//Console.WriteLine("name " + person1.Name, ", BirthDate " + person1.BirthDate);
//Console.WriteLine("name " + person2.Name, ", BirthDate " + person2.BirthDate);


//Console.WriteLine($"name: {person1.Name} BirthDate: {person1.BirthDate: yyyy MM dd}");
//Console.WriteLine($"name: {person2.Name} BirthDate: {person2.BirthDate:dd MM yyyy HH mm ss}");
//Console.WriteLine(person2);


namespace ObjectInit
{
    public class Program
    {
        public static void Main()
        {
            //  Person person = new Person
            //  {
            //  Name = "Hans"
            //  };

            //Console.WriteLine(person);

            Person person1 = new Person();
            Person person2 = new Person("Anna");
            Person person3 = new Person(new DateTime(1994, 09, 13), "Anna");
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);

        }

    }
}