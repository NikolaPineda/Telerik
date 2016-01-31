using System;

namespace Problem_6___Sum_of_Ks
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Write a program that reads two integer numbers N and K and an array of N elements from the console.
            Find in the array those K elements that have maximal sum.
            */

            var N = int.Parse(Console.ReadLine());
            var K = int.Parse(Console.ReadLine());
            var sum = 0;
            var tempSum = 0;
            var firstNUmber = 0;
            var array = new int[N];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < array.Length - K + 1; i++)
            {
                for (var j = i; j < i + K; j++)
                {
                    tempSum += array[j];
                }
                if (sum < tempSum)
                {
                    sum = tempSum;
                    firstNUmber = i;
                }
                tempSum = 0;
            }
            if (K == 1)
            {
                Console.WriteLine("{" + sum + "}");
            }
            else
            {
                for (var i = firstNUmber; i < firstNUmber + K; i++)
                {
                    if (i == firstNUmber)
                    {
                        Console.Write("{" + array[firstNUmber]);
                    }
                    else if (i == firstNUmber + K - 1)
                    {
                        Console.Write("," + array[firstNUmber + K - 1] + "}");
                    }
                    else
                    {
                        Console.Write("," + array[i]);
                    }
                }
            }
        }
    }
}