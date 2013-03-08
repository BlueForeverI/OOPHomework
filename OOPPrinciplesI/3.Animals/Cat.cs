using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    /// <summary>
    /// Represents a cat. Derives from Animal
    /// </summary>
    class Cat : Animal
    {
        public Cat(string name, int age, Sex sex) : base(name, age, sex)
        {
            Sound = Animal.AnimalSounds[2];
        }
    }
}
