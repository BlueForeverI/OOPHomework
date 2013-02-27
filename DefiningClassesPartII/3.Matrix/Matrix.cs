using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Matrix
{
    /// <summary>
    /// Represents a generic matrix of elements
    /// </summary>
    /// <typeparam name="T">The type of the elements</typeparam>
    class Matrix<T>
    {
        private T[,] matrix;
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[Rows, Cols];
        }

        /// <summary>
        /// Indexer for accessing elements at given index
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <returns>The element at the given index</returns>
        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int row = 0; row < this.Rows; row ++)
            {
                for(int col = 0; col < this.Cols; col ++)
                {
                    sb.Append(string.Format("{0},\t", this[row, col]));
                }

                sb.Append("\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Performs addition over two matrixes
        /// </summary>
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Cols != matrix2.Cols || matrix1.Rows != matrix2.Rows)
            {
                throw new ArgumentException("The matrices should have equal dimensions");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for(int row = 0; row < result.Rows; row ++)
            {
                for(int col = 0; col < result.Cols; col ++)
                {
                    result[row, col] = (dynamic)matrix1[row, col] + (dynamic)matrix2[row, col];
                }
            }

            return result;
        }

        /// <summary>
        /// Performs subtraction over two matrixes
        /// </summary>
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if(matrix1.Cols != matrix2.Cols || matrix1.Rows != matrix2.Rows)
            {
                throw new ArgumentException("The matrices should have equal dimensions");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)matrix1[row, col] - (dynamic)matrix2[row, col];
                }
            }

            return result;
        }

        /// <summary>
        /// Performs multiplication over two matrixes
        /// </summary>
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if(matrix1.Cols != matrix2.Rows)
            {
                throw new ArgumentException("The columns in the first matrix should be the same count as the rows in the second matrix");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)0;
                    for(int k = 0; k < matrix1.Cols; k ++)
                    {
                        result[row, col] += (dynamic)matrix1[row, k]*matrix2[k, col];
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Checks for non-zero elements
        /// </summary>
        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks for zero elements
        /// </summary>
        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
