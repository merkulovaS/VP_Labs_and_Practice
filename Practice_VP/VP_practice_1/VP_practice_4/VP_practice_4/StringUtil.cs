using System;

namespace Practice4
{
    public class StringUtil
    {
        // Удаление всех вхождений подстроки
        public static void RemoveSubstring()
        {
            // Ввод исходной строки
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            // Ввод подстроки для удаления
            Console.Write("Введите подстроку для удаления: ");
            string sub = Console.ReadLine();

            // Метод Replace заменяет все вхождения подстроки на пустую строку
            string result = text.Replace(sub, "");

            // Вывод результата
            Console.WriteLine("Результат: " + result);
        }


        // Удаление лишних пробелов между словами
        public static void RemovingSpaces()
        {
            // Ввод строки
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            // Разделение строки на слова
            // RemoveEmptyEntries удаляет пустые элементы (лишние пробелы)
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Соединяем слова обратно через один пробел
            string result = string.Join(" ", words);

            // Вывод результата
            Console.WriteLine("Результат: " + result);
        }

        // Сортировка слов по алфавиту
        public static void SortWord()
        {
            // Ввод строки
            Console.Write("Введите строку (слова заглавными): ");
            string input = Console.ReadLine();

            // Разделяем строку на слова
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Сортировка массива слов по алфавиту
            Array.Sort(words);

            // Объединяем слова обратно в строку
            string result = string.Join(" ", words);

            // Вывод результата
            Console.WriteLine("Отсортированная строка: " + result);
        }
    }
}