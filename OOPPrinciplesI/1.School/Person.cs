using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    /// <summary>
    /// Abstract class for people
    /// </summary>
    public abstract class Person
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
