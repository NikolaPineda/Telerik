using System;

namespace RangeExceptions
{
    internal class ExceptionTest
    {
        /*
        Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
            */

        private static void Main()
        {
            {
                try
                {
                    const int startTest = 100;
                    const int endTest = 200;
                    const int testEx = 250;
                    if (!(startTest < testEx && endTest > testEx))
                    {
                        throw new InvalidRangeException<int>(startTest, endTest);
                    }
                }
                catch (InvalidRangeException<int> erorX)
                {
                    Console.WriteLine(erorX.Message);
                    Console.WriteLine("Start: {0}, end: {1}", erorX.Start, erorX.End);
                }
            }
            Console.WriteLine("DateTime check");
            {
                try
                {
                    var start = new DateTime(2, 3, 2012);
                    var end = new DateTime(01, 01, 2015);
                    var test = DateTime.MinValue;
                    if (!(start < test && end > test))
                    {
                        throw new InvalidRangeException<DateTime>(start, end);
                    }
                }
                catch (InvalidRangeException<DateTime> someting)
                {
                    Console.WriteLine(someting.Message);
                    Console.WriteLine("Start: {0} and End; {1}", someting.Start, someting.End);
                }
            }
        }
    }
}