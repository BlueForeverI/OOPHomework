using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shapes
{
    /// <summary>
    /// Abstract class to hold information about generic shape
    /// </summary>
    abstract class Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public Shape()
        {

        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Virtual method to calculate the shape's surface
        /// </summary>
        /// <returns>Surface of the shape</returns>
        public virtual double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
