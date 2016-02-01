namespace SurfaceCalculator
{
    public class Triangle : Shape
    {
        public Triangle(decimal inputW, decimal inputH) : base(inputW, inputH)
        {
        }

        public override decimal CalculateSurface()
        {
            return Wigth*Height/2;
        }
    }
}