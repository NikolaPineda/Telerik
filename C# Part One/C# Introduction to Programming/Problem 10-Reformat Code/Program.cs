﻿using System;

namespace Problem_10_Reformat_Code
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hi, I am horribly formatted program");
            Console.WriteLine("Numbers and squares:");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " --> " + i*i);
            }
        }
    }
}