using System;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : Exception
    {
        internal InvalidRangeException(T start, T end, Exception innerExeption = null)
        {
            Start = start;
            End = end;
        }

        public T Start { get; protected set; }
        public T End { get; protected set; }
    }
}