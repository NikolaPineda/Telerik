namespace SurfaceCalculator
{
    public class Rectangle : Shape
    {
        public Rectangle(decimal inputW, decimal inputH) : base(inputW, inputH)
        {
        }

        public override decimal CalculateSurface()
        {
            return Wigth*Height;
        }
    }
}