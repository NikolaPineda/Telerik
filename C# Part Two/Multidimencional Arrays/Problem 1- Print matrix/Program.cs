using System;

namespace Homework_1_Multidimencional_Arrays
{
    internal class Program
    {
        private static void PrintMatrix(int lenght, int[,] array)
        {
            for (var row = 0; row < lenght; row++)
            {
                for (var col = 0; col < lenght; col++)
                {
                    if (array[row, col] < 10)
                    {
                        Console.Write(+array[row, col] + "  ");
                    }
                    else
                    {
                        Console.Write(array[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Main()
        {
            //Write a program that fills and prints a matrix of size (n, n) as shown below:

            var count = 1;
            Console.WriteLine("Enter a lenght:");
            var lenght = int.Parse(Console.ReadLine());
            var matrix = new int[lenght, lenght];
            Console.WriteLine("Variant A:");
            for (var col = 0; col < lenght; col++)
            {
                for (var row = 0; row < lenght; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            PrintMatrix(lenght, matrix);
            count = 0;
            Console.WriteLine();
            Console.WriteLine("Variant B:");
            for (var col = 0; col < lenght; col++)
            {
                if (col%2 == 0)
                {
                    for (var row = 0; row < lenght; row++)
                    {
                        count++;
                        matrix[row, col] = count;
                    }
                }
                if (col%2 != 0)
                {
                    for (var row = lenght - 1; row >= 0; row--)
                    {
                        count++;
                        matrix[row, col] = count;
                    }
                }
            }
            PrintMatrix(lenght, matrix);
            Console.WriteLine("Variant C:");
            var digit = 1;
            var r = lenght - 1;
            var c = 0;
            var startRow = lenght - 1;
            var startCol = 0;
            matrix[r, c] = digit;
            while (digit < lenght*lenght)
            {
                if (r == lenght - 1 && c < lenght - 1)
                {
                    digit++;
                    startCol = 0;
                    startRow--;
                    r = startRow;
                    c = startCol;
                    matrix[r, c] = digit;
                    while (r < lenght - 1 && c < lenght - 1)
                    {
                        r++;
                        c++;
                        digit++;
                        matrix[r, c] = digit;
                    }
                }
                if (r <= lenght - 1 && c == lenght - 1)
                {
                    startRow = 0;
                    startCol++;
                    r = startRow;
                    c = startCol;
                    digit++;
                    matrix[r, c] = digit;
                    while (c < lenght - 1)
                    {
                        r++;
                        c++;
                        digit++;
                        matrix[r, c] = digit;
                    }
                }
            }
            PrintMatrix(lenght, matrix);
            digit = 1;
            var sides = 0;
            Console.WriteLine("Variant D:");
            while (digit <= lenght*lenght)
            {
                //down
                for (r = sides; r < lenght - sides; r++)
                {
                    c = sides;
                    matrix[r, c] = digit;
                    digit++;
                }
                //right
                for (c = 1 + sides; c < lenght - sides; c++)
                {
                    r = lenght - 1 - sides;
                    matrix[r, c] = digit;
                    digit++;
                }
                //up
                for (r = lenght - 2 - sides; r >= sides; r--)
                {
                    c = lenght - sides - 1;
                    matrix[r, c] = digit;
                    digit++;
                }
                for (c = lenght - 2 - sides; c >= 1 + sides; c--)
                {
                    r = sides;
                    matrix[r, c] = digit;
                    digit++;
                }
                sides++;
            }
            Console.WriteLine();
            PrintMatrix(lenght, matrix);
        }
    }
}