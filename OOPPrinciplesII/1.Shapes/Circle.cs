using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shapes
{
    /// <summary>
    /// Represents a circle. Derives from Shape
    /// </summary>
    class Circle : Shape
    {
        public Circle(double width, double height)
        {
            if (width != height)
            {
                throw new ArgumentException("The width and height should be equal");
            }

            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return Math.PI*Math.Pow(this.Width/2, 2);
        }
    }
}
