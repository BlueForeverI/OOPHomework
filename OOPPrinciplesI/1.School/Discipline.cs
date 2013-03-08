using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    /// <summary>
    /// Represents a discipline
    /// </summary>
    public class Discipline
    {
        public string Name { get; private set; }
        public int NumberOfLectures { get; private set; }
        public int NumberOfExercises { get; private set; }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfLectures;
        }
    }
}
