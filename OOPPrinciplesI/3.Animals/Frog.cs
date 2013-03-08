using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    /// <summary>
    /// Represents a frog. Derives from Animal
    /// </summary>
    class Frog : Animal
    {
        public Frog(string name, int age, Sex sex) : base(name, age, sex)
        {
            Sound = Animal.AnimalSounds[1];
        }
    }
}
