using System;

namespace Problem_9_Exchange_Variable_Values
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            Console.WriteLine("A is equal to:{0} and B is equal to:{1}", a, b);
            var c = a;
            a = b;
            b = c;
            Console.WriteLine("A is equal to:{0} and B is equal to:{1}", a, b);
        }
    }
}