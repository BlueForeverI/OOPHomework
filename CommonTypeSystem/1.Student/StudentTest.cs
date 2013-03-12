using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Student
{
    /// <summary>
    /// A class to test all of the functionality of the Student class
    /// </summary>
    class StudentTest
    {
        static void Main(string[] args)
        {
            // test the constructor with initializerz
            Student firstStudent = new Student("Petar", "Ivanov", "Georgiev", "3210-2112-35435",
                "Sofia, Vasil Levski Str., No 201", "0888197143",
                "petar.georgiev@gmail.com", "Java Programming", Specialty.ComputerScience,
                Faculty.MathsAndInformatics, University.SofiaUniversity);

            // test the Clone() method
            Student cloned = (Student)firstStudent.Clone();

            // test the ToString() method
            Console.WriteLine("Information about the first student:");
            Console.WriteLine(firstStudent.ToString());

            Console.WriteLine("Information about the cloned student: ");
            Console.WriteLine(cloned.ToString());

            //test the equality operator
            Console.WriteLine("The two students are equal: {0}",
                firstStudent == cloned);

            cloned.MiddleName = "Dimitrov";
            cloned.SSN = "98978989-8984934-0435";

            //test the CompareTo() method
            Console.WriteLine("Some properties were changed. CompareTo returns: {0}",
                firstStudent.CompareTo(cloned));
        }
    }
}
