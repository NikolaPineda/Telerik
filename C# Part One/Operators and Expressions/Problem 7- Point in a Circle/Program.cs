using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            int r = 2;
            int X = 0;
            bool check = true;
            Console.WriteLine("Enter a number:");
            bool isNumber1 = double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter a number:");
            bool isNumber2 = double.TryParse(Console.ReadLine(), out number2);
            if (isNumber1 && isNumber2)
            {
                double pointIn = Math.Sqrt(Math.Pow((number1 - X), 2) + Math.Pow((number2 - X), 2));
                if (pointIn <= r)
                {
                    Console.WriteLine("The point is inside of the circle:{0}", check);
                }
                else
                {
                    check = false;
                    Console.WriteLine("The point is inside of the circle:{0}", check);
                }
            }
            Console.WriteLine("Invalid entry!");
        }
    }
}