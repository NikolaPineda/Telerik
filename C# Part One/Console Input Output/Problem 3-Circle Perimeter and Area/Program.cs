using System;

namespace Problem_3_Circle_Perimeter_and_Area
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/

            double radius;
            var isRadius = double.TryParse(Console.ReadLine(), out radius);
            if (isRadius)
            {
                Console.WriteLine("Perimeter = {0:0.00}", 2*Math.PI*radius);
                Console.WriteLine("Area = {0:0.00}", Math.PI*Math.Pow(radius, 2));
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}