using System;

namespace Problem_12_Subtracting_polynomials
{
    internal class Program
    {
        private static int[] Substraction(int[] fistPoly, int[] secondPoly)
        {
            var resultOfSub = new int[fistPoly.Length];
            var clone = (int[]) secondPoly.Clone();
            for (var i = 0; i < clone.Length; i++)
            {
                clone[i] *= -1;
            }
            for (var i = 0; i < resultOfSub.Length; i++)
            {
                resultOfSub[i] = fistPoly[i] + secondPoly[i];
            }
            return resultOfSub;
        }

        private static int[] Multiplication(int[] firstPolynom, int[] secondPolynom)
        {
            var multiplicationOfPoly = new int[firstPolynom.Length];
            for (var i = firstPolynom.Length - 1; i > 0; i--)
            {
                if (firstPolynom[i] == 0)
                {
                    firstPolynom[i] = 1;
                }
                if (secondPolynom[i] == 0)
                {
                    secondPolynom[i] = 1;
                }
                multiplicationOfPoly[i] = firstPolynom[i]*secondPolynom[i];
            }
            return multiplicationOfPoly;
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
            //Extend the previous program to support also subtraction and multiplication of polynomials.

            int[] firstPolynom = {1, 5, 6, 7};
            int[] secondPolynom = {6, 8, 4, 3};
            Console.WriteLine("Fist polynomail:");
            PrintPolynomail(firstPolynom);
            Console.WriteLine("Second polynomail:");
            PrintPolynomail(secondPolynom);
            Console.WriteLine("Multiplication of polynomails:");
            PrintPolynomail(Multiplication(firstPolynom, secondPolynom));
            Console.WriteLine("Substraction of polynomails:");
            PrintPolynomail(Substraction(firstPolynom, secondPolynom));
        }
    }
}