using System;

namespace Problem_16_Long_Sequence
{
    internal class Program
    {
        private static void Main()
        {
            for (var i = 2; i < 1002; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write("{0},", i);
                }
                else
                {
                    Console.Write("{0},", -i);
                }
            }
        }
    }
}