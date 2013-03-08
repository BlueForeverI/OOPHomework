using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shapes
{
    /// <summary>
    /// Represents a Triangle. Derives from Shape
    /// </summary>
    class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return (this.Height*this.Width)/2;
        }
    }
}
