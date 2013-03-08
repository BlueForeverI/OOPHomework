using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Humans
{
    /// <summary>
    /// Test the functionality of the classes Human, Student and Worker
    /// </summary>
    class HumansTest
    {
        static void Main(string[] args)
        {
            // initialize an array of 10 student with random names
            Student[] students = new Student[10]
            {
                new Student("Petar", "Petrov", 6),
                new Student("Georgi", "Petrov", 4),
                new Student("Vladimir", "Petrov", 4),
                new Student("Ivan", "Petrov", 5),
                new Student("Petar", "Georgiev", 2),
                new Student("Petar", "Ivanov", 3),
                new Student("Vladimir", "Georgiev", 6),
                new Student("Georgi", "Georgiev", 5),
                new Student("Ivan", "Ivanov", 3),
                new Student("Stoqn", "Petrov", 4),
            };

            // sort by Grade in ascending order
            var sortedByGrade = students.ToList();
            sortedByGrade.Sort((x, y) => x.Grade.CompareTo(y.Grade));

            // print sorted students
            Console.WriteLine("Students sorted by grade:");
            foreach (var student in sortedByGrade)
            {
                Console.WriteLine("{0}, {1}, {2}", 
                    student.FirstName, student.LastName, student.Grade);
            }

            // initialize array of 10 workers with random names
            Worker[] workers = new Worker[10]
            {
                new Worker("Petar", "Petrov", 1000, 8),
                new Worker("Georgi", "Petrov", 1200, 9),
                new Worker("Vladimir", "Petrov", 1000, 6),
                new Worker("Ivan", "Petrov", 2000, 10),
                new Worker("Petar", "Georgiev", 1500, 7),
                new Worker("Petar", "Ivanov", 1300, 8),
                new Worker("Vladimir", "Georgiev", 1400, 9),
                new Worker("Georgi", "Georgiev", 2100, 9),
                new Worker("Ivan", "Ivanov", 900, 6),
                new Worker("Stoqn", "Petrov", 1000, 5),                      
            };

            // sort by MoneyPerHour in descending order
            var sortedByMoneyPerHour = workers.ToList();
            sortedByMoneyPerHour.Sort((x, y) => y.MoneyPerHour().CompareTo(x.MoneyPerHour()));

            // print sorted workers
            Console.WriteLine("\n\nWorkers sorted by money per hour: ");
            foreach (var worker in sortedByMoneyPerHour)
            {
                Console.WriteLine("{0}, {1}, ${2}, {3}", 
                    worker.FirstName, worker.LastName, worker.WeekSalary, worker.WorkHoursPerDay);
            }
        }
    }
}
