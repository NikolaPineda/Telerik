using System;
using System.IO;
using System.Linq;

namespace StructurePoint3D
{
    internal static class PathStorage
    {
        public static Path LoadPath(string filePath)
        {
            var path = new Path();
            var SR = new StreamReader(filePath);
            using (SR)
            {
                var line = SR.ReadLine();

                while (line != null)
                {
                    var coordinates = line.Split(';').Select(Convert.ToDouble).ToArray();
                    path.AddPath(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    line = SR.ReadLine();
                }
            }
            return path;
        }

        public static void PathToSave(Path pathToSave, string pathFile)
        {
            var sw = new StreamWriter(pathFile);
            using (sw)
            {
                sw.Write(pathToSave);
            }
        }
    }
}