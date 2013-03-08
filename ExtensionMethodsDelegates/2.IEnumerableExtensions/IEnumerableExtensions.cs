using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.IEnumerableExtensions
{
    static class IEnumerableExtensions
    {
        /// <summary>
        /// Calculates the total sum of a collection
        /// </summary>
        /// <typeparam name="T">Return type</typeparam>
        /// <param name="colection">Collection to sum</param>
        /// <returns>The sum of the collection</returns>
        static T Sum<T>(this IEnumerable<T> colection)
        {
            // use dynamic types to support addition
            dynamic sum = default(T);
            foreach (var variable in colection)
            {
                dynamic x = variable;
                sum += x;
            }

            return sum;
        }

        /// <summary>
        /// Calculates the product of two collections
        /// </summary>
        /// <typeparam name="T">Return typ1</typeparam>
        /// <param name="collection1">First collection</param>
        /// <param name="collection2">Second collection</param>
        /// <returns>The product of the two collections</returns>
        static IEnumerable<T> Product<T>(this IEnumerable<T> collection1, IEnumerable<T> collection2)
        {
            List<T> product = new List<T>();
            foreach (var variable in collection1)
            {
                product.Add(variable);
            }

            int index = 0;
            foreach (var variable in collection2)
            {
                // use dynamic types to support multiplication
                dynamic result = (dynamic)product[index] * (dynamic)variable;
                product[index] = result;
                index++;
            }

            return product;
        }

        /// <summary>
        /// Gets the minimal element of a collection
        /// </summary>
        /// <typeparam name="T">Return type</typeparam>
        /// <param name="collection">Collection to check</param>
        /// <returns>The minimal element of the collection</returns>
        static T Min<T>(this IEnumerable<T> collection)
        {
            IEnumerator<T> enumerator = collection.GetEnumerator();
            enumerator.MoveNext();
            T min = enumerator.Current;

            foreach (var variable in collection)
            {
                // use dynamic types for comparing
                dynamic dMin = min;
                dynamic current = variable;

                if (current < dMin)
                {
                    min = current;
                }
            }

            return min;
        }

        /// <summary>
        /// Gets the maximal element of a collection
        /// </summary>
        /// <typeparam name="T">Return type</typeparam>
        /// <param name="collection">Collection to check</param>
        /// <returns>The maximal element of the collection</returns>
        static T Max<T>(this IEnumerable<T> collection)
        {
            IEnumerator<T> enumerator = collection.GetEnumerator();
            enumerator.MoveNext();
            T max = enumerator.Current;

            foreach (var variable in collection)
            {
                // use dynamic types for comparing 
                dynamic dMax = max;
                dynamic current = variable;

                if (current > dMax)
                {
                    max = current;
                }
            }

            return max;
        }

        /// <summary>
        /// Gets the average of a collection
        /// </summary>
        /// <typeparam name="T">Return type</typeparam>
        /// <param name="collection">The collection</param>
        /// <returns>The average of the collection</returns>
        static double Average<T>(this IEnumerable<T> collection)
        {
            int count = 0;

            // count the elements
            IEnumerator<T> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                count++;
            }

            // use dynamic type for summing
            dynamic sum = collection.Sum();
            return (double)sum / (double)count;
        }

        static void Main(string[] args)
        {
            // test with samle input
            int[] data1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] data2 = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Min: {0}", data1.Min());
            Console.WriteLine("Max: {0}", data1.Max());
            Console.WriteLine("Sum: {0}", data1.Sum());
            Console.WriteLine("Average: {0}", data1.Average());
            Console.WriteLine("Product with {0}: {1}",
                String.Join(", ", data1), String.Join(", ", data1.Product(data2)));
        }
    }
}
