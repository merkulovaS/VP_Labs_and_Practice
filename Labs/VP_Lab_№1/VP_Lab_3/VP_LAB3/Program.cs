using Lab3;
using System;

namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = null;
            Matrix matrix2 = null;

            while (true)
            {
                Console.WriteLine("1. Ввести первую матрицу");
                Console.WriteLine("2. Ввести вторую матрицу");
                Console.WriteLine("3. Сложить матрицы");
                Console.WriteLine("4. Вычесть матрицы");
                Console.WriteLine("5. Умножить матрицы");
                Console.WriteLine("6. Клонировать первую матрицу");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        matrix1 = CreateMatrix();
                        Console.WriteLine("Первая матрица:");
                        Console.WriteLine(matrix1);
                        break;

                    case "2":
                        matrix2 = CreateMatrix();
                        Console.WriteLine("Вторая матрица:");
                        Console.WriteLine(matrix2);
                        break;

                    case "3":
                        if (CheckMatrices(matrix1, matrix2))
                            Console.WriteLine(matrix1 + matrix2);
                        break;

                    case "4":
                        if (CheckMatrices(matrix1, matrix2))
                            Console.WriteLine(matrix1 - matrix2);
                        break;

                    case "5":
                        if (CheckMatrices(matrix1, matrix2))
                            Console.WriteLine(matrix1 * matrix2);
                        break;

                    case "6":
                        if (matrix1 == null)
                        {
                            Console.WriteLine("Сначала создайте первую матрицу!");
                            break;
                        }

                        Matrix clone = (Matrix)matrix1.Clone();
                        Console.WriteLine("Клон матрицы:");
                        Console.WriteLine(clone);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Неверный пункт меню!");
                        break;
                }
            }
        }

        static Matrix CreateMatrix()
        {
            Console.Write("Введите количество строк: ");
            uint rows = uint.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            uint columns = uint.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(rows, columns);

            Console.WriteLine("Введите элементы матрицы:");

            for (uint i = 0; i < rows; i++)
                for (uint j = 0; j < columns; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }

            return matrix;
        }

        static bool CheckMatrices(Matrix m1, Matrix m2)
        {
            if (m1 == null || m2 == null)
            {
                Console.WriteLine("Сначала создайте обе матрицы!");
                return false;
            }
            return true;
        }
    }
}