using System;
using System.Linq;

namespace Divisible_by_7_and_3
{
    public class DevisibleTest
    {
        private static void Main()
        {
            var numbers = new int[10] {1, 3, 21, 42, 98, 6, 63, 8, 9, 10};
            //Use the built-in extension methods
            Console.WriteLine("Use the built-in extension methods");
            var devisableNumbers = numbers.Where(n => n%7 == 0 && n%3 == 0);
            foreach (var item in devisableNumbers)
            {
                Console.WriteLine(item);
            }
            // Use Linq
            Console.WriteLine();
            Console.WriteLine("Use Linq");

            var newNumbers = from num in numbers
                where num%7 == 0 && num%3 == 0
                select num;
            foreach (var item in newNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}