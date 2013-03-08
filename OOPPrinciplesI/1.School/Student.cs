using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    /// <summary>
    /// Represents a typical student. Derives from Person
    /// </summary>
    public class Student : Person
    {
        public int ClassNumber { get; private set; }

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }
    }
}
