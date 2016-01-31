using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10___Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int fibonacciNumber1 = 0;
            int fibonacciNumber2 = 1;
            int sum = 0;
            Console.WriteLine("Enter number:{0}");
            bool isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                for (int i = 0; i < number -2; i++)
                {
                    sum = fibonacciNumber1 + fibonacciNumber2;
                    Console.WriteLine(sum);
                    fibonacciNumber1 = fibonacciNumber2;
                    fibonacciNumber2 = sum;                   
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}
