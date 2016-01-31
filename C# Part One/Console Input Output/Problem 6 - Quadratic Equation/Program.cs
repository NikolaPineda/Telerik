using System;

namespace Problem_6___Quadratic_Equation
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

            double a, b, c, x1, x2, d;
            Console.WriteLine("Enter number:");
            var isA = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter number:");
            var isB = double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Enter number:");
            var isC = double.TryParse(Console.ReadLine(), out c);
            if (isA && isB && isC)
            {
                d = b*b - 4*a*c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d))/(a*2);
                    x2 = (b - Math.Sqrt(d))/(a*2);
                    Console.WriteLine("The real roots are:");
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                }
                else if (d == 0)
                {
                    x1 = x2 = -b/2*a;
                    Console.WriteLine("The real roots are:");
                    Console.WriteLine("x1={0}", x1);
                    Console.WriteLine("x2={0}", x2);
                }
                else if (d < 0)
                {
                    Console.WriteLine("The equation has no real roots!");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}