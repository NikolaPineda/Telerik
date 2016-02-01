using System;


namespace StructurePoint3D
{
    internal static class Distance
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            return Math.Sqrt((a.PointX - b.PointX) * (a.PointX - b.PointX) + (a.PointY - b.PointY) * (a.PointY - b.PointY) + (a.PointZ - b.PointZ) * (a.PointZ - b.PointZ));
        }
    }
}
