using System;

namespace Problem_11_Adding_polynomials
{
    internal class Program
    {
        private static int[] SumOfPolynom(int[] firstPolynom, int[] secondPolynom)
        {
            var sum = new int[firstPolynom.Length];
            for (var i = 0; i < firstPolynom.Length; i++)
            {
                sum[i] = firstPolynom[i] + secondPolynom[i];
            }
            return sum;
        }

        private static void PrintPolynomail(int[] print)
        {
            for (var i = print.Length - 1; i >= 0; i--)
            {
                if ((print[i] != 0) && (i != 0))
                {
                    Console.Write(print[i - 1] >= 0 ? " {1}x^{0} +" : "{1}x^{0} ", i, print[i]);
                }
                else if (i == 0)
                {
                    Console.Write(" {0}", print[i]);
                }
            }
            Console.WriteLine();
        }

        private static void Main()
        {
            /*
            Write a method that adds two polynomials.
            Represent them as arrays of their coefficients.
            */

            int[] firstPolynom = {1, 5, 6, 7};
            int[] secondPolynom = {6, 8, 4, 3};
            Console.WriteLine("Fist polynomail");
            PrintPolynomail(firstPolynom);
            Console.WriteLine("Second polynomail");
            PrintPolynomail(secondPolynom);
            Console.WriteLine("Sum of the polynomail");
            PrintPolynomail(SumOfPolynom(firstPolynom, secondPolynom));
        }
    }
}