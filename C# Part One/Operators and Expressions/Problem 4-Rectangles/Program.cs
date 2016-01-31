using System;

namespace Problem_4_Rectangles
{
    internal class Program
    {
        private static void Main()
        {
            //Write an expression that calculates rectangle’s perimeter and area by given width and height.

            double a;
            double b;
            Console.WriteLine("Enter side A:");
            var isA = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter side B:");
            var isB = double.TryParse(Console.ReadLine(), out b);

            if (isA && isB)
            {
                var perimeter = 2*(a + b);
                var area = a*b;
                Console.WriteLine("Perimeter is equal to:{0}", perimeter);
                Console.WriteLine("Area is equal to:{0}", area);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}