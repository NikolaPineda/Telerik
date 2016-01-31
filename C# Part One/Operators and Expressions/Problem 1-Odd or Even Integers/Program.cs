using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even!");
            }
            else
            {
                Console.WriteLine("The number is odd!");
            }
        }
    }
}
