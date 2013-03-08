using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Humans
{
    /// <summary>
    /// Abstract class to hold information about humans
    /// </summary>
    abstract class Human
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
