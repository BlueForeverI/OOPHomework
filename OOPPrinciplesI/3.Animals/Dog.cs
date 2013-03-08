using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    /// <summary>
    /// Represents a dog. Derives from Animal
    /// </summary>
    class Dog : Animal
    {
        public Dog(string name, int age, Sex sex) : base(name, age, sex)
        {
            Sound = Animal.AnimalSounds[0];
        }
    }
}
