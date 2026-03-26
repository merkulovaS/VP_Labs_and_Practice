using System;

namespace Delegates
{
    class Program
    {
        // Точка входа в программу
        static void Main()
        {
            // Демонстрация работы делегата Action
            Console.WriteLine(" Action Delegate");
            ActionExample.Example();

            Console.WriteLine(); // пустая строка для разделения вывода

            // Демонстрация работы делегата Func
            Console.WriteLine(" Func Delegate");
            FuncExample.Example();
        }
    }
}