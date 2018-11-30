using System;
using System.Collections.Generic;

namespace Pets_Ackemo
{
    class Program
    {
        public static List<Pet> PetList = new List<Pet>();

        static void Main(string[] args)
        {
            Console.WriteLine("WE GOT PETS! LOOK AT THEM");

            Console.WriteLine("");
            
            Console.ReadKey();

        }

        public static void AddPet()
        {
            string name = Console.ReadLine();
            Pet pet = new Pet();
            pet.name = name;
            PetList.Add(pet);
        }
    }
}
