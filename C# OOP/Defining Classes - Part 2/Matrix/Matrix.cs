using System;
using System.Text;

namespace Matrix
{
    public class Matrix<T>
    {
        private readonly T[,] matrix;

        public Matrix(int rows, int cols)
        {
            matrix = new T[rows, cols];
        }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Colums
        {
            get { return matrix.GetLength(1); }
        }

        public T this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            ChekMatrix(first, second);
            var result = new Matrix<T>(first.Rows, first.Rows);
            for (var i = 0; i < first.Rows; i++)
            {
                for (var j = 0; j < first.Colums; j++)
                {
                    result = (dynamic) first[i, j] + second[i, j];
                }
            }
            return result;
        }

        private static void ChekMatrix(Matrix<T> first, Matrix<T> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException();
            }
            if (second == null)
            {
                throw new ArgumentNullException();
            }
            if (first.Rows != second.Rows)
            {
                throw new InvalidOperationException();
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            ChekMatrix(first, second);
            var result = new Matrix<T>(first.Rows, first.Rows);
            for (var row = 0; row < first.Rows; row++)
            {
                for (var col = 0; col < first.Colums; col++)
                {
                    result[row, col] = (dynamic) first[row, col]*second[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            ChekMatrix(first, second);
            var result = new Matrix<T>(first.Rows, first.Rows);
            for (var row = 0; row < first.Rows; row++)
            {
                for (var col = 0; col < first.Colums; col++)
                {
                    result = (dynamic) first[row, col] - second[row, col];
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> matrixX)
        {
            foreach (var item in matrixX.matrix)
            {
                if (item.Equals(default(T)))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return true;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var row = 0; row < Rows; row++)
            {
                for (var col = 0; col < Colums; col++)
                {
                    sb.Append(matrix[row, col] + " ");
                }
            }
            return sb.ToString();
        }
    }
}