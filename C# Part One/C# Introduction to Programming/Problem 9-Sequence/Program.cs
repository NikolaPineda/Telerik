using System;

namespace Problem_9_Sequence
{
    internal class Program
    {
        private static void Main()
        {
            for (var i = 2; i < 12; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}