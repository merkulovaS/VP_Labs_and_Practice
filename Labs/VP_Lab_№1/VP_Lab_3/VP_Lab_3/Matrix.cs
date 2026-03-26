using System;
using System.Text;

namespace Lab3
{
    public class Matrix : ICloneable
    {
        public uint Rows { get; }
        public uint Columns { get; }

        private double[,] elements;

        // Конструктор с размерностью
        public Matrix(uint rows, uint columns)
        {
            Rows = rows;
            Columns = columns;
            elements = new double[rows, columns];
        }

        // Копирующий конструктор
        public Matrix(Matrix matrix)
        {
            Rows = matrix.Rows;
            Columns = matrix.Columns;
            elements = new double[Rows, Columns];

            for (uint i = 0; i < Rows; i++)
                for (uint j = 0; j < Columns; j++)
                    elements[i, j] = matrix[i, j];
        }

        // Индексатор
        public double this[uint row, uint column]
        {
            get
            {
                if (row >= Rows || column >= Columns)
                    throw new IndexOutOfRangeException();
                return elements[row, column];
            }
            set
            {
                if (row >= Rows || column >= Columns)
                    throw new IndexOutOfRangeException();
                elements[row, column] = value;
            }
        }

        // Переопределение ToString()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Matrix {Rows}x{Columns}:");

            for (uint i = 0; i < Rows; i++)
            {
                for (uint j = 0; j < Columns; j++)
                    sb.Append(elements[i, j] + "\t");
                sb.AppendLine();
            }

            return sb.ToString();
        }

        // Перегрузка ToString(int n)
        public string ToString(int n)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;

            for (uint i = 0; i < Rows; i++)
            {
                for (uint j = 0; j < Columns; j++)
                {
                    if (count >= n)
                        return sb.ToString();

                    sb.Append(elements[i, j] + " ");
                    count++;
                }
            }

            return sb.ToString();
        }

        // Приватный метод для + и -
        private static Matrix AddOrSubtract(Matrix left, Matrix right, bool isAddition)
        {
            if (left.Rows != right.Rows || left.Columns != right.Columns)
                throw new ArgumentException("Матрицы должны быть одинакового размера");

            Matrix result = new Matrix(left.Rows, left.Columns);

            for (uint i = 0; i < left.Rows; i++)
                for (uint j = 0; j < left.Columns; j++)
                {
                    result[i, j] = isAddition
                        ? left[i, j] + right[i, j]
                        : left[i, j] - right[i, j];
                }

            return result;
        }

        // Оператор +
        public static Matrix operator +(Matrix left, Matrix right)
        {
            return AddOrSubtract(left, right, true);
        }

        // Оператор -
        public static Matrix operator -(Matrix left, Matrix right)
        {
            return AddOrSubtract(left, right, false);
        }

        // Умножение матрицы на матрицу
        public static Matrix operator *(Matrix left, Matrix right)
        {
            if (left.Columns != right.Rows)
                throw new ArgumentException(
                    "Количество столбцов первой матрицы должно быть равно количеству строк второй");

            Matrix result = new Matrix(left.Rows, right.Columns);

            for (uint i = 0; i < left.Rows; i++)
            {
                for (uint j = 0; j < right.Columns; j++)
                {
                    double sum = 0;

                    for (uint k = 0; k < left.Columns; k++)
                        sum += left[i, k] * right[k, j];

                    result[i, j] = sum;
                }
            }

            return result;
        }

        // Умножение матрицы на число
        public static Matrix operator *(Matrix matrix, double number)
        {
            Matrix result = new Matrix(matrix.Rows, matrix.Columns);

            for (uint i = 0; i < matrix.Rows; i++)
                for (uint j = 0; j < matrix.Columns; j++)
                    result[i, j] = matrix[i, j] * number;

            return result;
        }

        // Умножение числа на матрицу
        public static Matrix operator *(double number, Matrix matrix)
        {
            return matrix * number;
        }

        // Реализация Clone()
        public object Clone()
        {
            return new Matrix(this);
        }
    }
}