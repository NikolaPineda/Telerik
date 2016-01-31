using System;

namespace Problem_16_Bit_Exchange__Advanced_
{
    internal class Program
    {
        private static long CheckBit(long number, int position)
        {
            return (number & (1 << position)) >> position;
        }

        private static void Main()
        {
            /*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.*/

            Console.WriteLine("Enter n:");
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter p:");
            var p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter q:");
            var q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k:");
            var k = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            if (p > 32 || q > 32 || p + k > 32 || q + k > 32)
            {
                Console.WriteLine("Out of range!");
            }
            else if (p < q && (p + q < k))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (var i = 0; i < 2; i++)
                {
                    var mask1 = CheckBit(n, p);
                    var mask2 = CheckBit(n, q);

                    if (mask1 == 0 && mask2 == 1)
                    {
                        n = n | (1 << p);
                        n = n & ~(1 << q);
                    }
                    else if (mask1 == 1 && mask2 == 0)
                    {
                        n = n & ~(1 << p);
                        n = n | (1 << q);
                    }

                    p++;
                    q++;
                }

                var mask3 = CheckBit(n, p + k);
                var mask4 = CheckBit(n, p - k);

                if (mask3 == 0 && mask4 == 1)
                {
                    n = n | (1 << p);
                    n = n & ~(1 << q);
                }
                else if (mask3 == 1 && mask4 == 0)
                {
                    n = n & ~(1 << p);
                    n = n | (1 << q);
                }

                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine("The new number is:{0}", n);
            }
        }
    }
}