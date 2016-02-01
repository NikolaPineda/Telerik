namespace MobilePhone
{
    public class Display
    {
        public Display() : this(0, 0)
        {
        }

        public Display(double sizeInInches) : this(sizeInInches, 0)
        {
        }

        public Display(double sizeInInches, ColorDepth colordepth)
        {
            Size = sizeInInches;
            Color = colordepth;
        }

        public double Size { get; private set; }
        public ColorDepth Color { get; private set; }
    }
}