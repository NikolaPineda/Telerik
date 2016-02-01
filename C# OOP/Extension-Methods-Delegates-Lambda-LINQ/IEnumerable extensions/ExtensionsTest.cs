using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_extensions
{
    public class IEnumberableProgram
    {
        internal static void Main()
        {
            var array = new double[10];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = i + 1.5;
            }
            Console.WriteLine("The sum is: {0}",array.SumX());
            Console.WriteLine("The product is: {0:0.00}", array.ProductX());
            Console.WriteLine("Min value is: {0}", array.MinX());
            Console.WriteLine("Max value is: {0}", array.MaxX());
            Console.WriteLine("Average is: {0}", array.AverageX());
        }
    }
}
