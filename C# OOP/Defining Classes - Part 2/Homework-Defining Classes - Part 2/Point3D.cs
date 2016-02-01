namespace StructurePoint3D
{
    internal struct Point3D
    {
        public Point3D(double x, double y, double z) : this()
        {
            PointX = x;
            PointY = y;
            PointZ = z;
        }

        public double PointX { get; set; }
        public double PointY { get; set; }
        public double PointZ { get; set; }

        public static Point3D PrintO { get; } = new Point3D();

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", PointX, PointY, PointZ);
        }
    }
}