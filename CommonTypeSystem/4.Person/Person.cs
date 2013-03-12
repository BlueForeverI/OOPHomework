using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Person
{
    /// <summary>
    /// A class that holds information about a person
    /// </summary>
    class Person
    {
        // public properties
        public string Name { get; set; }
        public int? Age { get; set; }

        // constructor that initializes the properties
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        /// <summary>
        /// Overrides the default ToString() method
        /// </summary>
        /// <returns>
        /// String representation of the person, with all properties displayed
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " +  this.Name);
            sb.AppendLine(string.Format("Age: {0}\n", ((this.Age == null)
                              ? "(not specified)"
                              : this.Age.ToString())));

            return sb.ToString();
        }
    }
}
