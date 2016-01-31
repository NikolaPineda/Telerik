using System;

namespace Problem_10_Odd_and_Even_Product
{
    internal class Program
    {
        private static void Main()
        {
            /*You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

            var numbers = Console.ReadLine();
            if (numbers != null)
            {
                var array = numbers.Split(' ');
                var oddProduct = 1;
                var evenProduct = 1;
                for (var i = 0; i < array.Length; i++)
                {
                    var number = int.Parse(array[i]);
                    if (i%2 == 0)
                    {
                        oddProduct *= number;
                    }
                    else
                    {
                        evenProduct *= number;
                    }
                }
                if (oddProduct == evenProduct)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Product = {0}", oddProduct);
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine("Even product = {0}", evenProduct);
                    Console.WriteLine("Odd product = {0}", oddProduct);
                }
            }
        }
    }
}