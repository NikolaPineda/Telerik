using System;

namespace Problem_1_Exchange_If_Greater
{
    internal class Program
    {
        private static void Main()
        {
            /*Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.*/

            double a, b, c;
            var isA = double.TryParse(Console.ReadLine(), out a);
            var isB = double.TryParse(Console.ReadLine(), out b);
            if (isA && isB)
            {
                if (a > b)
                {
                    c = a;
                    a = b;
                    b = c;
                    Console.WriteLine(a + " " + b);
                }
                else
                {
                    Console.WriteLine("b > a");
                }
            }
            Console.WriteLine("Invalid entry!");
        }
    }
}