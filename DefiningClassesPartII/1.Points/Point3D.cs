using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Points
{
    /// <summary>
    /// Represents a 3-D coordinate in the space
    /// </summary>
    public class Point3D
    {
        public long X { get; set; }
        public long Y { get; set; }
        public long Z { get; set; }

        //holds the start of the coordinate system
        private static readonly Point3D start = new Point3D(0, 0 ,0);
        public static Point3D Start 
        {
            get
            {
                return start;
            }
        }

        public Point3D()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        public Point3D(long x = 0, long y = 0, long z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format("{X = {0}; Y = {1}; Z = {2}}",
                                 this.X, this.Y, this.Z);
        }

        public override bool Equals(object obj)
        {
            Point3D p = (Point3D) obj;

            if(this.X == p.X && this.Y == p.Y && this.Z == p.Z)
            {
                return true;
            }

            return false;
        }
    }
}
