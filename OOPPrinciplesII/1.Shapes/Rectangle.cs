using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shapes
{
    /// <summary>
    /// Represents a rectangle. Derives from Shape
    /// </summary>
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return this.Width*this.Height;
        }
    }
}
