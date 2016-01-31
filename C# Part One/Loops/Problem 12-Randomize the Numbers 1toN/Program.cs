using System;

namespace Problem_12_Randomize_the_Numbers_1toN
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/

            Console.WriteLine("Enter number");
            var num = int.Parse(Console.ReadLine());
            var array = new int[num];
            for (var index = 0; index < num; index++)
            {
                array[index] = index + 1;
            }

            var random = new Random();
            foreach (var index in array)
            {
                var randNum = random.Next(0, num);
                var temp = array[randNum];
                array[randNum] = array[0];
                array[0] = temp;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}