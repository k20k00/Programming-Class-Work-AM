using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegClasses
{
    class Animal
    {
        string name;
        string species;
        string color;
        int age;

        public Animal(string Name, string Species, string Color, int Age)
        {
            this.name = Name;
            this.species = Species;
            this.color = Color;
            this.age = Age;
        }
        public void MakeSound()
        {
            Console.WriteLine("Grrrrr");
        }
        public void SetAge(int newAge)
        {
            age = newAge;
        }
        public void PrintDescription()
        {
            Console.WriteLine(name + " is a " + age + " year old, " + color + " " + species);
        }


    }
}
