using System;

namespace Problem_10
{
    internal class Program
    {
        private static void Main()
        {
            /*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

            double number1;
            double number2;
            var r = 1.5;
            var X = 1;
            Console.WriteLine("Enter a number:");
            var isNumber1 = double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter a number:");
            var isNumber2 = double.TryParse(Console.ReadLine(), out number2);

            if (isNumber1 && isNumber2)
            {
                var pointInCircle = Math.Sqrt(Math.Pow(number1 - X, 2) + Math.Pow(number2 - X, 2));
                var pointOutRectangle = number1 > 1 || number1 < 6 && number2 > -1 || number2 < 2;
                bool check;
                if (pointInCircle <= r && pointOutRectangle)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                if (number1 == 0 || number2 == 0)
                {
                    Console.WriteLine("No");
                }
                else if (check && pointOutRectangle)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}