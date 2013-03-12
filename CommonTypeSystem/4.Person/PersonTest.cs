using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Person
{
    /// <summary>
    /// Test the functionality of the Person class
    /// </summary>
    class PersonTest
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Petar", 20);
            Person secondPerson = new Person("Georgi");

            Console.WriteLine("Information about the first student: ");
            Console.WriteLine(firstPerson);

            Console.WriteLine("Information about the second person: ");
            Console.WriteLine(secondPerson);
        }
    }
}
