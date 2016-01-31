using System;

namespace Problem_3_Sequence_in_the_matrix
{
    internal class Program
    {
        private static void CreateMatrix(int a, int b, string[,] matrix)
        {
            for (var row = 0; row < a; row++)
            {
                for (var col = 0; col < b; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }
            for (var row = 0; row < a; row++)
            {
                for (var col = 0; col < b; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Main()
        {
            /*
            We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
            Write a program that finds the longest sequence of equal strings in the matrix.
            */

            Console.WriteLine("Enter height:");
            int height;
            var isHeight = int.TryParse(Console.ReadLine(), out height);
            Console.WriteLine("Enter width:");
            int width;
            var isWidth = int.TryParse(Console.ReadLine(), out width);
            if (isHeight && isWidth)
            {
                var matrix = new string[height, width];
                var count = 1;
                var maxCount = 0;
                string element = null;
                CreateMatrix(height, width, matrix);
                for (var col = 0; col < width; col++)
                {
                    for (var row = 1; row < height; row++)
                    {
                        if (matrix[row, col] == matrix[row - 1, col])
                        {
                            count++;
                            if (maxCount < count)
                            {
                                maxCount = count;
                                element = matrix[row - 1, col];
                            }
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                    count = 1;
                }

                for (var row = 0; row < height; row++)
                {
                    for (var col = 1; col < width; col++)
                    {
                        if (matrix[row, col] == matrix[row, col - 1])
                        {
                            count++;
                            if (maxCount < count)
                            {
                                maxCount = count;
                                element = matrix[row, col - 1];
                            }
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                    count = 1;
                }
                for (var i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (var j = 0; j < matrix.GetLength(1) - 1; j++)
                    {
                        for (int row = i, col = j;
                            row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1;
                            col++, row++)
                        {
                            if (matrix[row, col] == matrix[row + 1, col + 1])
                            {
                                count++;
                                if (maxCount < count)
                                {
                                    maxCount = count;
                                    element = matrix[row, col];
                                }
                            }
                            else
                            {
                                count = 1;
                            }
                        }
                        count = 1;
                    }
                }
                for (var i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (var j = 0; j < matrix.GetLength(1); j++)
                    {
                        for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col > 0; col--, row++)
                        {
                            if (matrix[row, col] == matrix[row + 1, col - 1])
                            {
                                count++;
                                if (maxCount < count)
                                {
                                    maxCount = count;
                                    element = matrix[row, col];
                                }
                            }
                            else
                            {
                                count = 1;
                            }
                        }
                        count = 1;
                    }
                }
                for (var i = 0; i < maxCount; i++)
                {
                    if (i == maxCount - 1)
                    {
                        Console.Write(element);
                    }
                    else
                    {
                        Console.Write(element + ",");
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect entry!");
            }
        }
    }
}