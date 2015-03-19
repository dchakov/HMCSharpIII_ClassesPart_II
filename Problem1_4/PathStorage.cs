using System;
using System.IO;
using System.Linq;

namespace Structure
{
    public static class PathStorage
    {
        public static void SavePats(Point3D point)
        {
            StreamWriter resultFile = new StreamWriter(@"..\..\result.txt",true);
            using (resultFile)
            {
                resultFile.WriteLine(point.X +" "+point.Y+" "+point.Z);
            }
        }
        public static Path LoadPaths(string filename)
        {
            Path result = new Path();
            StreamReader reader = new StreamReader(filename);
            using (reader)
            {
                int linenumber = 0;
                string line = reader.ReadLine();
                while (line!=null)
                {
                    linenumber++;
                    double[] coord = line.Split(' ').Select(double.Parse).ToArray();
                    Point3D current = new Point3D(coord[0],coord[1],coord[2]);
                    result.AddPoint(current);
                    line = reader.ReadLine();
                }
            }
            return result;
        }
    }
}