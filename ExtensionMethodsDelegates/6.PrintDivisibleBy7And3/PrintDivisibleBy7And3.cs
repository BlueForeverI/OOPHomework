using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.PrintDivisibleBy7And3
{
    class PrintDivisibleBy7And3
    {
        static void Main(string[] args)
        {
            // sample input data
            int[] numbers = new int[] { 3, 1, 7, 4, 14, 21, 27, 18, 42 };

            // find numbers with extension methods
            var extractedExtMethods = numbers.Where(x => (x % 7 == 0 && x % 3 == 0));

            // find numbers with LINQ
            var extractedLinq = from n in numbers
                                where n % 7 == 0 && n % 3 == 0
                                select n;

            // print extension method results
            Console.WriteLine("Divisible by 7 and 3, with Extension methods: {0}",
                String.Join(", ", extractedExtMethods));

            // print LINQ results
            Console.WriteLine("Divisible by 7 and 3, with LINQ: {0}",
                String.Join(", ", extractedLinq));
        }
    }
}
