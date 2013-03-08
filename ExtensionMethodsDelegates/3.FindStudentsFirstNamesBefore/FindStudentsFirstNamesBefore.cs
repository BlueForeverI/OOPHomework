using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.FindStudentsFirstNamesBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            // get students with LINQ
            var firstNameBeforeLastName = (from s in StudentData.Student.Students
                                           where s.FirstName.CompareTo(s.LastName) < 0
                                           select s);

            // print results
            Console.WriteLine("Students whose first name is before its last name alphabetically:");
            foreach (var student in firstNameBeforeLastName)
            {
                Console.WriteLine("{0} {1}, {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
