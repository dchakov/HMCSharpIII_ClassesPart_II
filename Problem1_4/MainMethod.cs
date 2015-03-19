using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class MainMethod
    {
        static void Main()
        {
            Point3D point1 = new Point3D(1, 2, 3);
            Point3D point2 = new Point3D(-3, 2, 5);
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            
            Console.WriteLine(Point3D.PointO);
            Console.WriteLine();

            Console.WriteLine(Distance.CalculateDistance(point1, point2));

            Console.WriteLine();
            Path points = new Path();
            points.AddPoint(point1);
            points.AddPoint(point2);
            Console.WriteLine("Points in List");          
            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine(points[i]);
            }
            PathStorage.SavePats(point1);
            PathStorage.SavePats(point2);
            Console.WriteLine();
            Console.WriteLine("Points in file");
            string filename = @"..\..\result.txt";
            Path textFilePoint = PathStorage.LoadPaths(filename);
            for (int i = 0; i < textFilePoint.Count; i++)
            {
                Console.WriteLine(textFilePoint[i]);
            }
        }
    }
}
