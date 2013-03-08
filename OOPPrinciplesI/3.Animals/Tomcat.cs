using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    /// <summary>
    /// Represents a male cat. Derives from Cat
    /// </summary>
    class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, Sex.Male)
        {
            Sound = Animal.AnimalSounds[4];
        }
    }
}
