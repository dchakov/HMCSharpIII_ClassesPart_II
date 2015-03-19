using System;

namespace Structure
{
    public struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        private static readonly Point3D pointO;

        public static Point3D PointO
        {
            get { return pointO; }
        }
        static Point3D()
        {
            pointO = new Point3D(0, 0, 0);
        }
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override string ToString()
        {
            return String.Format("X = {0} Y = {1} Z = {2}", this.X, this.Y, this.Z);
        }
    }
}
