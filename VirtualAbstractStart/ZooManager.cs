

using VirtualAbstractStart.Model;

namespace VirtualAbstractStart
{

    public class ZooManager
    {
        public static void Main(string[] args)
        {
            Dog dog1 = new Dog("Dog", "French Bulldog");
            Cat cat1 = new Cat("Cat", "Siamese");
            List<Animal> animals = new List<Animal>() { dog1, cat1 };



            foreach (Animal ani in animals)
            {
                Console.WriteLine(ani);
                Console.WriteLine("Trick: " +ani.PerformTrick());
                Console.WriteLine("Feed: " +ani.FeedAnimal());
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

    }
}