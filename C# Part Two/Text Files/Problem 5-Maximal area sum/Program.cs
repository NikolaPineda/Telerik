/*  Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.
 */

using System.IO;

namespace P05.MaximalAreaSum
{
    internal class MaximalAreaSum
    {
        private static void Main()
        {
            using (var reader = new StreamReader(@"..\..\input.txt"))
            {
                var size = int.Parse(reader.ReadLine());
                var matrix = new long[size, size];

                for (var row = 0; row < size; row++)
                {
                    var line = reader.ReadLine().Split(' ');

                    for (var col = 0; col < size; col++)
                    {
                        matrix[row, col] = long.Parse(line[col]);
                    }
                }

                WriteMaxSumToFile(FindMaxSum(matrix));
            }
        }

        private static void WriteMaxSumToFile(long sum)
        {
            using (var writer = new StreamWriter(@"..\..\output.txt"))
            {
                writer.WriteLine(sum);
            }
        }

        private static long FindMaxSum(long[,] matrix)
        {
            var maxSum = long.MinValue;

            for (var row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (var col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var temp = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (temp > maxSum)
                    {
                        maxSum = temp;
                    }
                }
            }

            return maxSum;
        }
    }
}