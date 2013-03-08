using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shapes
{
    /// <summary>
    /// A class to test the functionality of Shape and its related classes
    /// </summary>
    class ShapesTest
    {
        static void Main(string[] args)
        {
            // create a few shapes
            Shape[] shapes = new Shape[]
            {
                new Rectangle(10, 15),
                new Triangle(17.5, 4), 
                new Circle(8, 8),
                new Triangle(17, 9)
            };

            // print all surfaces
            for(int i = 0; i < shapes.Length; i ++)
            {
                Console.WriteLine("Shape {0} surface: {1}", i, shapes[i].CalculateSurface());
            }
        }
    }
}
