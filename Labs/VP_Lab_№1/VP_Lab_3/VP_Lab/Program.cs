using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix(2, 2);
            Matrix b = new Matrix(2, 2);

            a[0, 0] = 1;
            a[0, 1] = 2;
            a[1, 0] = 3;
            a[1, 1] = 4;

            b[0, 0] = 5;
            b[0, 1] = 6;
            b[1, 0] = 7;
            b[1, 1] = 8;

            Console.WriteLine("Матрица A:");
            Console.WriteLine(a);

            Console.WriteLine("Матрица B:");
            Console.WriteLine(b);

            Matrix sum = a + b;
            Console.WriteLine("A + B:");
            Console.WriteLine(sum);

            Matrix diff = a - b;
            Console.WriteLine("A - B:");
            Console.WriteLine(diff);

            Matrix mult = a * b;
            Console.WriteLine("A * B:");
            Console.WriteLine(mult);

            Console.WriteLine("Первые 3 элемента матрицы A:");
            Console.WriteLine(a.ToString(3));

            // Проверка клонирования
            Matrix clone = (Matrix)a.Clone();
            clone[0, 0] = 100;

            Console.WriteLine("Оригинал после изменения клона:");
            Console.WriteLine(a);

            Console.WriteLine("Клон:");
            Console.WriteLine(clone);
        }
    }
}