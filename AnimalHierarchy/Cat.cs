using AnimalsHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public string Breed { get; set; }

        public Cat(string name, int age, string breed)
        {

            Name = name;
            Age = age;
            Breed = breed;
            Sound = "Meow!!";
            Console.WriteLine($"A Cat Named {Name} is Created. It is {Age} years old and it is a {Breed}");
        }
        public override void MakeSound()
        {
            base.MakeSound();
        }
    }
}
