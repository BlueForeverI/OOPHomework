using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Points
{
    /// <summary>
    /// Holds methods for point operations
    /// </summary>
    static class PointOperations
    {
        public static double CalculateDistanceBetweenPoints(Point3D a, Point3D b)
        {
            long deltaX = Math.Abs(a.X - b.X);
            long deltaY = Math.Abs(a.Y - b.Y);
            long deltaZ = Math.Abs(a.Z - b.Z);

            return Math.Sqrt((
                Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2)));
        }
    }
}
