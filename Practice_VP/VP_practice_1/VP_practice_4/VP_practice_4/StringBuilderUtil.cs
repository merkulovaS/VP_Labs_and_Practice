using System;
using System.Text;


namespace Practice4
{
    public class StringBuilderUtil
    {
        // Вставка строки после заданного символа
        public static void InsertString()
        {
            // Ввод строки
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();

            // Ввод символа
            Console.Write("Введите символ: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Ввод строки
            Console.Write("Введите строку: ");
            string s0 = Console.ReadLine();

            // Создание объекта StringBuilder для работы со строкой
            StringBuilder strbuild = new StringBuilder();

            // Перебор символов строки
            foreach (char ch in s)
            {
                // Добавляем символ в новую строку
                strbuild.Append(ch);

                // Если символ совпадает с заданным
                if (ch == c)
                {
                    // Вставляем строку S0
                    strbuild.Append(s0);
                }
            }

            // Вывод результата
            Console.WriteLine("Результат: " + strbuild.ToString());
        }


        // Выравнивания длины двух строк
        public static void Equalization()
        {
            // Ввод первой строки
            Console.Write("Введите первую строку: ");
            string s1 = Console.ReadLine();

            // Ввод второй строки
            Console.Write("Введите вторую строку: ");
            string s2 = Console.ReadLine();

            // Создание StringBuilder для изменения строк
            StringBuilder strbuild1 = new StringBuilder(s1);
            StringBuilder strbuild2 = new StringBuilder(s2);

            // Если первая строка короче — добавляем пробелы
            while (strbuild1.Length < strbuild2.Length)
                strbuild1.Append(' ');

            // Если вторая строка короче — добавляем пробелы
            while (strbuild2.Length < strbuild1.Length)
                strbuild2.Append(' ');

            // Вывод строк одинаковой длины
            Console.WriteLine("Строка 1: \"" + strbuild1.ToString() + "\"");
            Console.WriteLine("Строка 2: \"" + strbuild2.ToString() + "\"");
        }


        // Перевод десятичного числа в двоичную систему
        public static void DecimalBinary()
        {
            // Ввод десятичного числа
            Console.Write("Введите десятичное число: ");
            int number = int.Parse(Console.ReadLine());

            // StringBuilder для формирования двоичной строки
            StringBuilder strbuild = new StringBuilder();

            // Пока число больше нуля
            while (number > 0)
            {
                // Добавляем остаток от деления на 2 в начало строки
                strbuild.Insert(0, number % 2);

                // Делим число на 2
                number /= 2;
            }

            // Вывод двоичной записи
            Console.WriteLine("Двоичная запись: " + strbuild.ToString());
        }
    }
}