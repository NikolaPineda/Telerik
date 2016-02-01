using System;

namespace BitArray64Test
{
    internal class BitArray64Test
    {
        /*
        Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements". It is not necessary to keep the tree balanced.
Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() and the operators for comparison == and !=.
Add and implement the ICloneable interface for deep copy of the tree.
        */

        private static void Main()
        {
            var bits = new BitArray64(4611703610613764096, true);
            var bits2 = new BitArray64(4611703610613764096);
            var testBits = new BitArray64(111);
            Console.WriteLine(bits);
            Console.WriteLine(bits2);
            Console.WriteLine(bits.Equals(bits2));
            Console.WriteLine(testBits);
            testBits[0] = 1;
            Console.WriteLine(testBits);
            testBits[2] = 0;
            Console.WriteLine(testBits);
        }
    }
}