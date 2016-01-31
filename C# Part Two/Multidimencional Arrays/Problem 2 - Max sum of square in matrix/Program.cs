using System;

namespace Problem_2___Max_sum_of_square_in_matrix
{
    internal class Program
    {
        private static void PrintMatrix(int[,] matrix, int startRow, int startCol)
        {
            for (var row = startRow; row < startRow + 3; row++)
            {
                for (var i = startCol; i < startCol + 3; i++)
                {
                    Console.Write(matrix[row, i] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Main()
        {
            /*
            Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
            */

            Console.WriteLine("Enter number bigger than one:");
            int numberOne;
            var isNumberOne = int.TryParse(Console.ReadLine(), out numberOne);
            Console.WriteLine("Enter number bigger than one:");
            int numberTwo;
            var isNUmberTwo = int.TryParse(Console.ReadLine(), out numberTwo);
            if (isNumberOne && isNUmberTwo)
            {
                var matrix = new int[numberOne, numberTwo];
                Console.WriteLine("Enter numbers for the matrix:");
                for (var row = 0; row < numberOne; row++)
                {
                    for (var col = 0; col < numberTwo; col++)
                    {
                        matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                }
                var sum = 0;
                var startRow = 0;
                var startCol = 0;
                var maxSum = 0;
                for (var row = 1; row < numberOne - 1; row++)
                {
                    for (var col = 1; col < numberTwo - 1; col++)
                    {
                        for (var i = row - 1; i < row + 2; i++)
                        {
                            for (var j = col - 1; j < col + 2; j++)
                            {
                                sum = sum + matrix[i, j];
                            }
                        }
                        if (maxSum < sum)
                        {
                            maxSum = sum;
                            startRow = row - 1;
                            startCol = col - 1;
                        }
                        sum = 0;
                    }
                }
                PrintMatrix(matrix, startRow, startCol);
                Console.WriteLine(maxSum);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}