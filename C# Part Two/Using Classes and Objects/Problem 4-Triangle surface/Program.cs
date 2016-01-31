using System;

namespace Problem_4_Triangle_surface
{
    internal class Program
    {
        private static void FirstChois()
        {
            Console.WriteLine("Enter side:");
            var side = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter heigth:");
            var heigth = int.Parse(Console.ReadLine());
            var area = Math.BigMul(side, heigth)/2;
            Console.WriteLine("Area by one side and heigth: {0}", area);
        }

        private static void SecondChois()
        {
            Console.WriteLine("Enter side A:");
            var A = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B:");
            var B = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C:");
            var C = double.Parse(Console.ReadLine());
            var area = (A + B + C)/2;
            Console.WriteLine(Math.Sqrt(area*(area - A)*(area - B)*(area - C)));
        }

        private static void ThirdChois()
        {
            Console.WriteLine("Enter first side:");
            var firstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side:");
            var secondSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter angle:");
            var angle = int.Parse(Console.ReadLine());
            var area = Math.BigMul(firstSide, secondSide)/2*Math.Sin(angle*Math.PI/180);
            Console.WriteLine("{0:F}", area);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to calculate area by side and heigth:");
            Console.WriteLine("Press 2 to  calculate area by three sides:");
            Console.WriteLine("Press 3 to calculate area by two sides and angle between them:");
            var chois = int.Parse(Console.ReadLine());
            if (chois == 1)
            {
                FirstChois();
            }
            else if (chois == 2)
            {
                SecondChois();
            }
            else if (chois == 3)
            {
                ThirdChois();
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}