using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.SortStudents
{
    class SortStudents
    {
        static void Main(string[] args)
        {
            // sort with extension methods
            var sortedExtMethods = StudentData.Student.Students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName);


            // sort with LINQ
            var sortedLinq = (from s in StudentData.Student.Students
                              orderby s.FirstName descending, s.LastName descending
                              select s);

            // print extension method results
            Console.WriteLine("Sorted with extension methods: ");
            foreach (var student in sortedExtMethods)
            {
                Console.WriteLine(student);
            }

            // print LINQ result
            Console.WriteLine("\nSorted with LINQ: ");
            foreach (var student in sortedLinq)
            {
                Console.WriteLine(student);
            }
        }
    }
}
