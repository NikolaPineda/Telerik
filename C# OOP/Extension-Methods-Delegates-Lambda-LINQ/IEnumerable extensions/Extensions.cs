using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable_extensions
{
    public static class Extensions
    {
        public static T  SumX<T>(this IEnumerable<T> someValue) where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            var sum = default(T);
            foreach (var item in someValue)
            {
                sum += (dynamic)item;
            }
            return sum;
        }
        public static T ProductX<T>(this IEnumerable<T> someValue) where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            var product = (dynamic)1;
            foreach (var item in someValue)
            {
                product *= (dynamic)item;
            }
            return product;
        }
        public static T MinX<T>(this IEnumerable<T> someValue) where T : struct, IComparable<T>, IEquatable<T>, IComparable
        {
            var min = (dynamic)someValue.FirstOrDefault();
            foreach (var item in someValue)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T MaxX<T>(this IEnumerable<T> someValue) where T : struct, IComparable<T>, IEquatable<T>, IComparable
        {
            var max = (dynamic)someValue.FirstOrDefault();
            foreach (var item in someValue)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T AverageX<T>(this IEnumerable<T> someValue) where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            var sum = default(T);
            var count = (dynamic)0;
            foreach (var item in someValue)
            {
                sum += (dynamic)item;
                count++;
            }
            return sum / count;
        }
    }
}
