using System.Collections.Generic;

namespace StructurePoint3D
{
    internal class Path
    {
        private readonly List<Point3D> pointList = new List<Point3D>();

        public void AddPath(Point3D input)
        {
            pointList.Add(input);
        }
    }
}