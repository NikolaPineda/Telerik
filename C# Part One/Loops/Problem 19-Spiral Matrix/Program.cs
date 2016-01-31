using System;

namespace Problem_19_Spiral_Matrix
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
            */

            int number;
            Console.WriteLine("Enter number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            var array = new int[number, number];
            var curentRow = 0;
            var curentCol = 0;
            var direction = "right";
            if (isNumber && number > 1 && number <= 20)
            {
                for (var i = 1; i <= number*number; i++)
                {
                    if (direction == "right" && (curentCol >= number || array[curentRow, curentCol] != 0))
                    {
                        curentCol--;
                        curentRow++;
                        direction = "down";
                    }
                    else if (direction == "down" && (curentRow >= number || array[curentRow, curentCol] != 0))
                    {
                        curentCol--;
                        curentRow--;
                        direction = "left";
                    }
                    else if (direction == "left" && (curentCol < 0 || array[curentRow, curentCol] != 0))
                    {
                        curentCol++;
                        curentRow--;
                        direction = "up";
                    }
                    else if (direction == "up" && (curentRow < 0 || array[curentRow, curentCol] != 0))
                    {
                        curentRow++;
                        curentCol++;
                        direction = "right";
                    }

                    array[curentRow, curentCol] = i;
                    if (direction == "right")
                    {
                        curentCol++;
                    }
                    else if (direction == "down")
                    {
                        curentRow++;
                    }
                    else if (direction == "left")
                    {
                        curentCol--;
                    }
                    else if (direction == "up")
                    {
                        curentRow--;
                    }
                }
                for (var i = 0; i < number; i++)
                {
                    for (var j = 0; j < number; j++)
                    {
                        //Console.SetCursorPosition(j * 5, i * 2);
                        Console.Write(array[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}