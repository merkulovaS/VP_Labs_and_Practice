using System;

namespace Delegates
{
    public class ActionExample
    {
        // Метод для Func<double>
        // ничего не принимает, возвращает число
        static double GetFive()
        {
            return 5;
        }

        // второй метод для примера
        static double GetNumber()
        {
            return 15.73;
        }

        // Метод с делегатом Action<Func<double>, double, double>
        static void ActionMethod(Func<double> func, double a, double b)
        {
            // вызываем переданный метод
            double value = func();

            Console.WriteLine($"Значение из Func: {value}");
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Сумма: {value + a + b}");
        }

        public static void Example()
        {
            // передаем обычный метод
            ActionMethod(GetFive, 2.4, 3.6);

            Console.WriteLine();

            // передаем другой метод
            ActionMethod(GetNumber, 1.2, 4.4);
        }
    }
}