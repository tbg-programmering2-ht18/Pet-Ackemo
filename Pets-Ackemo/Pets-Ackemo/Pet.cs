using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public bool CanFly { get; set; }

        public string Show()
        {
            // Checks if the animal class is able to fly, they all got a CanFly bool value, if true, text
            // says that the animal can fly, if false, returns can't fly
            if (CanFly == true)
            {
                return String.Format("name: {0}\nSound: {1}\nType: {2} and can fly", Name, Sound, GetType());
            }
            else
            {
                return String.Format("name: {0}\nSound: {1}\nType: {2}", Name, Sound, GetType());
            }
        }

    }
    // The classes are "children classes" to the main class called Animal. Each one have their own values and functions
    // that, in this case, are public and called in Program.cs code
    class Dog : Animal
    {
        public Dog(String name)
        {
            Name = name;
            Sound = "Arf";
            CanFly = false;
        }
    }
    class Cat : Animal
    {
        public Cat(String name)
        {
            Name = name;
            Sound = "Nya";
            CanFly = false;
        }
    }
    class Bird : Animal
    {
        public Bird(String name)
        {
            Name = name;
            Sound = "KAHKAAAH";
            CanFly = true;
        }
    }
}