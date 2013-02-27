using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace _1.Points
{
    /// <summary>
    /// Holds a sequence of 3D points
    /// </summary>
    public class Path
    {
        public List<Point3D> Points { get; set; }

        public Path()
        {
            this.Points = new List<Point3D>();
        }

        public Path(List<Point3D> points = null)
        {
            if(points == null)
            {
                this.Points = new List<Point3D>();
            }
            else
            {
                this.Points = points;
            }
        }

        public override bool Equals(object obj)
        {
            Path p = (Path) obj;
            if(p.Points.Count != this.Points.Count)
            {
                return false;
            }

            for(int i = 0; i < this.Points.Count; i ++)
            {
                if(!this.Points[i].Equals(p.Points[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
