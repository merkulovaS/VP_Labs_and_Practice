using System;

namespace Practice4
{
    class Program
    {
        // Точка входа в программу
        static void Main()
        {
            // Бесконечный цикл для работы меню
            while (true)
            {
                // Вывод меню
                Console.WriteLine("\nВыберите задание:");
                Console.WriteLine("1 - RemoveAll (удалить подстроку)");
                Console.WriteLine("2 - Убрать лишние пробелы");
                Console.WriteLine("3 - Сортировка слов по алфавиту");
                Console.WriteLine("4 - Вставка строки после символа");
                Console.WriteLine("5 - Выравнивание длины строк");
                Console.WriteLine("6 - Десятичное число -> двоичное");
                Console.WriteLine("0 - Выход");

                // Чтение выбора пользователя
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                // Выбор задания через оператор switch
                switch (choice)
                {
                    case "1":
                        StringUtil.RemoveSubstring();
                        break;

                    case "2":
                        StringUtil.RemovingSpaces();
                        break;

                    case "3":
                        StringUtil.SortWord();
                        break;

                    case "4":
                        StringBuilderUtil.InsertString();
                        break;

                    case "5":
                        StringBuilderUtil.Equalization();
                        break;

                    case "6":
                        StringBuilderUtil.DecimalBinary();
                        break;

                    // Завершение программы
                    case "0":
                        return;

                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
    }
}