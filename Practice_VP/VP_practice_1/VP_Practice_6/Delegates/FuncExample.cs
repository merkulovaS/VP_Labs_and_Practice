using System;

namespace Delegates
{
    public class FuncExample
    {
        // Метод для Action<float>
        static void ShowNumber(float x)
        {
            Console.WriteLine($"Число: {x}");
        }

        // второй метод для наглядности
        static void ShowDoubleNumber(float x)
        {
            Console.WriteLine($"Число умноженное на 2: {x * 2}");
        }

        // Метод с делегатом Func<Action<float>, int, float, bool>
        static bool FuncMethod(Action<float> operation, int number, float value)
        {
            Console.WriteLine($"number = {number}");

            // вызываем переданный метод
            operation(value);

            // простая проверка
            if (number > 5)
                return true;
            else
                return false;
        }

        public static void Example()
        {
            // передаем обычный метод
            bool result = FuncMethod(ShowNumber, 15, 3.5f);
            Console.WriteLine($"Результат: {result}");

            Console.WriteLine();
            // передаем другой метод
            result = FuncMethod(ShowDoubleNumber, 2, 8.1f);
            Console.WriteLine($"Результат: {result}");

            Console.WriteLine();
            // передаем другой метод
            bool result2 = FuncMethod(ShowDoubleNumber, 1, 7.0f);
            Console.WriteLine($"Результат: {result}");
        }
    }
}