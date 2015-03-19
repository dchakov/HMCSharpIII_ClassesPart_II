using System;

namespace Structure
{
    public static class Distance
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double result = Math.Sqrt(
                (point1.X - point2.X) * (point1.X - point2.X) +
                (point1.Y - point2.Y) * (point1.Y - point2.Y) +
                (point1.Z - point2.Z) * (point1.Z - point2.Z)
             );
            return result;
        }
    }
}
