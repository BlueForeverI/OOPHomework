using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentData
{
    /// <summary>
    /// Represents a student
    /// </summary>
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}, Last Name: {1}, Age: {2}",
                                 this.FirstName, this.LastName, this.Age);
        }

        // sample data to use in the next tasks
        public static Student[] Students = new Student[]
        {
            new Student("Petar", "Stefanov", 19),
            new Student("Kamen", "Petrov", 20), 
            new Student("Georgi", "Ivanov", 21),
            new Student("Ivan", "Georgiev", 18),
            new Student("Dimitar", "Angelov", 23),
            new Student("Tihomir", "Stoqnov", 17), 
        };
    }
}
