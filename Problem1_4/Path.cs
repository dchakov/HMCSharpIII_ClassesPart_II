using System;
using System.Collections.Generic;

namespace Structure
{
    public class Path
    {
        private List<Point3D> points3D;
       
        public Path()
        {
            this.points3D = new List<Point3D>();
        }
        public void AddPoint(Point3D point)
        {
            this.points3D.Add(point);
        }
        public Point3D this[int index]
        {
            get { return this.points3D[index]; }
            set { this.points3D[index] = value; }
        }
        public int Count
        {
            get { return this.points3D.Count; }
        }
        public override string ToString()
        {
            return String.Format("{0}",this.points3D);
        }
    }
}
