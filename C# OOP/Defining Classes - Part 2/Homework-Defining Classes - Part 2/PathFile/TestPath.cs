using System;

namespace StructurePoint3D
{
    internal class TestPath
    {
        private static void Main()
        {
            var myPath = PathStorage.LoadPath(@"..\..\path.txt");
            Console.WriteLine(myPath);
            var zero = Point3D.PrintO;
            var testPoin = new Point3D(6, 7, 1);
            Console.WriteLine("Distance between {0} and {1} is {2:0.00}", zero, testPoin,
                Distance.CalculateDistance(zero, testPoin));
            PathStorage.PathToSave(myPath, @"..\..\output.txt");
        }
    }
}