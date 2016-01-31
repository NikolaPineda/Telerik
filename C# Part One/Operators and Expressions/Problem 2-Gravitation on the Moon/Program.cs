using System;

namespace Problem_2_Gravitation_on_the_Moon
{
    internal class Program
    {
        private static void Main()
        {
            /*The gravitational field of the Moon is approximately 17% of that on the Earth.
              Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/

            double weightOnEarth;
            var gravityOnMoon = 0.17;
            Console.WriteLine("Enter a weight:");
            var isWeightOnEarth = double.TryParse(Console.ReadLine(), out weightOnEarth);

            if (isWeightOnEarth)
            {
                var weightOnMoon = gravityOnMoon*weightOnEarth;
                Console.WriteLine("The weight on moon is:{0}", weightOnMoon);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}