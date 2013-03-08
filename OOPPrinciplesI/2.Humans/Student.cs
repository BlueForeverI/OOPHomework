using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Humans
{
    /// <summary>
    /// Represents a typical student. Derives from Human
    /// </summary>
    class Student : Human
    {
        public int Grade { get; private set; }

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
