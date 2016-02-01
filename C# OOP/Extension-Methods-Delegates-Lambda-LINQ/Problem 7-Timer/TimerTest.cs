using System;
using System.Threading;

namespace Problem_7_Timer
{
    internal class Timer
    {
        public delegate void DelegateMethood(int number, string input);

        private static void Main()
        {
            DelegateMethood myDelegate = DoCalculation;
            myDelegate(5, "Ivan");
        }

        public static void DoCalculation(int number, string input)
        {
            var someNumber = 2;
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine(input + (number + someNumber));
                someNumber++;
            }
        }
    }
}