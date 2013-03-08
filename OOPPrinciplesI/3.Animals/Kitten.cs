using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    /// <summary>
    /// Represents a female cat. Derives from Cat
    /// </summary>
    class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, Sex.Female)
        {
            Sound = Animal.AnimalSounds[3];
        }
    }
}
