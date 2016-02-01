using System;

namespace SurfaceCalculator
{
    public abstract class Shape
    {
        private decimal height;
        private decimal width;

        public Shape(decimal inputWidth, decimal inputHeight)
        {
            width = inputWidth;
            height = inputHeight;
        }

        public decimal Wigth
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The wigth can't be zero, or negative number!");
                }
                width = value;
            }
        }

        public decimal Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The height can't be zero, or negative number!");
                }
                height = value;
            }
        }

        public abstract decimal CalculateSurface();

        public override string ToString()
        {
            return string.Format("I am {0}, and my surface is: {1}", GetType().Name, CalculateSurface());
        }
    }
}