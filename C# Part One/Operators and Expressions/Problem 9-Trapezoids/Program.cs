using System;

namespace Problem_9_Trapezoids
{
    internal class Program
    {
        private static void Main()
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h.

            double sideA, sideB, hight;
            Console.WriteLine("Enter side A:");
            var isSideA = double.TryParse(Console.ReadLine(), out sideA);
            Console.WriteLine("Enter side B:");
            var isSideB = double.TryParse(Console.ReadLine(), out sideB);
            Console.WriteLine("Enter hight:");
            var isHight = double.TryParse(Console.ReadLine(), out hight);

            if (isSideA && isSideB && isHight && sideB > 0 && sideA > 0 && hight > 0)
            {
                var area = (sideA + sideB)*hight/2;
                Console.WriteLine("The area is equal to:{0}", area);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}