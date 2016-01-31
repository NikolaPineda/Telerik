using System;

namespace Problem_12_Null_Values_Arithmetic
{
    internal class Program
    {
        private static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a + 2);
            Console.WriteLine(b + 2);
            Console.WriteLine(a + null);
            Console.WriteLine(b + null);
        }
    }
}