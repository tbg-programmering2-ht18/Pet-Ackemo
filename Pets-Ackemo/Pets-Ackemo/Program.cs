using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static List<Animal> animals = new List<Animal>();
        private static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {
            // This list adds new objects to the class Animal, more exactly adds the "name" value (string) to the "child" class inside
            // animal class.
            animals.Add(new Cat("Bosse"));
            animals.Add(new Dog("Petsson"));
            animals.Add(new Bird("Gullan"));

            Console.WriteLine(@"This is a animal tester, see what spirit animal you have!
            Press any key to see what you are! (esc. ends it all)");



            // Each time a button except esc is pressed, the console will continue to show random animals, no specific order.
            // If esc is pressed, the console app will shut down.
            ConsoleKey ck = Console.ReadKey().Key;
            while (ck != ConsoleKey.Escape)
            {
                int x = getrandom.Next(0, animals.Count - 1);
                Console.WriteLine("\nYour spirit animal is...");
                Console.WriteLine(animals[x].Show());
                Console.WriteLine("Press ESC to quit or any key to : \n");
                ck = Console.ReadKey().Key;

            }
        }
    }
}