using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    /// <summary>
    /// Represents a typical Teacher. Derives from Person
    /// </summary>
    public class Teacher : Person
    {
        public List<Discipline> Disciplines { get; private set; }

        public Teacher(string name, List<Discipline> disciplines = null) : base(name)
        {
            this.Disciplines = (disciplines == null) ? new List<Discipline>() : disciplines;
        }
    }
}
