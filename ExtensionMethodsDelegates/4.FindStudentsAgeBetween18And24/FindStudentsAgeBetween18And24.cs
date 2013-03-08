using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.FindStudentsAgeBetween18And24
{
    class FindStudentsAgeBetween18And24
    {
        static void Main(string[] args)
        {
            // find students with LINQ
            var between18And24 = (from s in StudentData.Student.Students
                                  where s.Age > 18 && s.Age < 24
                                  select new { s.FirstName, s.LastName });

            // print results
            Console.WriteLine("Student names aged between 18 and 24: ");
            foreach (var student in between18And24)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
