using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    /// <summary>
    /// A class to test the functionality of the Animal and its related classes
    /// </summary>
    class AnimalsTest
    {
        static void Main(string[] args)
        {
            // create a few dogs
            Dog[] dogs = new Dog[]
            {
                new Dog("Gosho", 4, Sex.Male),
                new Dog("Rex", 5, Sex.Male),
                new Dog("Linda", 3, Sex.Female),
                new Dog("Ivan", 6, Sex.Male), 
            };

            // create a few frogs
            Frog[] frogs = new Frog[]
            {
                new Frog("Misho", 3, Sex.Male),
                new Frog("Tisho", 6, Sex.Male),
                new Frog("Pesho", 4, Sex.Male), 
            };

            // create a few cats
            Cat[] cats = new Cat[]
            {
                new Cat("Pisa", 7, Sex.Female),
                new Kitten("Lubov", 3),
                new Tomcat("Tom", 10),
                new Cat("Vesko", 7, Sex.Male), 
            };

            // calculate the average age of all dogs
            Console.WriteLine("Dogs' average age is {0}", Animal.CalculateAverageAge(dogs));

            // calculate the average age of all cats
            Console.WriteLine("Cats' average age is {0}", Animal.CalculateAverageAge(cats));

            // calculate the average age of all frogs
            Console.WriteLine("Frogs' average age is {0}", Animal.CalculateAverageAge(frogs));
        }
    }
}
