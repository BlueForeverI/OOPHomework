using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.StringBuilderExtension
{
    static class StringBuilderExtension
    {
        /// <summary>
        /// Extension method for the StringBuilder class that mimics the functionality
        /// of the Substring method in the String class
        /// </summary>
        /// <param name="sb">The StringBuilder object</param>
        /// <param name="index">Index to start</param>
        /// <param name="length">Length of the substring</param>
        /// <returns>New StringBuilder with the substring content</returns>
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            string content = sb.ToString();

            // check input
            if(index < 0)
            {
                throw new ArgumentException("The index should not be a negative number", "index");
            }

            if(length > content.Length - index)
            {
                throw new ArgumentException("The length should not exceed the content boundaries",
                    "length");
            }

            return new StringBuilder(content.Substring(index, length));
        }

        static void Main(string[] args)
        {
            // sample usage
            StringBuilder sb = new StringBuilder("Hello! This is an extension method");
            
            // call the Substring extension method
            Console.WriteLine(sb.Substring(7, 7));
        }
    }
}
