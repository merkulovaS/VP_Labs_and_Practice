using System;

namespace UserLibrary
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            int[] originalArray = new int[size];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nИсходный массив: {Array.ToString(originalArray)}");

            var result = Array.SplitByParity(originalArray);

            Console.WriteLine($"Чётные числа (отсортированы): {Array.ToString(result.EvenNumbers)}");
            Console.WriteLine($"Нечётные числа (отсортированы): {Array.ToString(result.OddNumbers)}");

        }
    }
}