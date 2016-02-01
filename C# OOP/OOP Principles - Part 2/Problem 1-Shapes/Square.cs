namespace SurfaceCalculator
{
    public class Square : Shape
    {
        public Square(decimal inputSquare) : base(inputSquare, inputSquare)
        {
            Wigth = inputSquare;
            Height = inputSquare;
        }

        public override decimal CalculateSurface()
        {
            return Height*Wigth;
        }
    }
}