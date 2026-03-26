using System;

namespace Delegate
{
    class Program
    {
        static void Main()
        {
            // первый массив
            DynamicArray<int> array = new DynamicArray<int>(10);

            array.Add(3);
            array.Add(1);
            array.Add(4);
            array.Add(1);
            array.Add(2);
            array.Add(6);
            array.Add(8);
            array.Add(7);

            Console.WriteLine("Исходный массив:");
            array.Print();

            // фильтр
            array.Filter(x => x % 2 == 0);

            Console.WriteLine("После фильтрации :");
            array.Print();

            // условие - есть ли четные ?
            bool hasEven = array.Any(x => x % 2 == 0);
            Console.WriteLine($"Есть ли четные числа? {hasEven}");

            // условие - есть ли > 10 ?  
            bool hasGreaterThan10 = array.Any(x => x > 10);
            Console.WriteLine($"Есть ли числа больше 10? {hasGreaterThan10}");


            Console.WriteLine();
            // второй массив
            DynamicArray<string> array2 = new DynamicArray<string>(10);

            array2.Add("oyc");
            array2.Add("swo");
            array2.Add("erb");
            array2.Add("adf");
            array2.Add("cjd");
            array2.Add("cjhd");
            array2.Add("cjhd");
            array2.Add("cjhd");

            Console.WriteLine("До сортировки:");
            array2.Print();

            // сортировка по возрастанию
            array2.Sort((a, b) => a.CompareTo(b));

            Console.WriteLine("После сортировки:");
            array2.Print();
           
            // условие - все слова длиной не меньше 2 символов 
            bool allKolSimvol = array2.All(s => s.Length >= 2);
            Console.WriteLine($"Все слова длиной не менее 2 символов {allKolSimvol}");

            bool allSoglas = array2.All(s => !"aeiou".Contains(s[0]));
            Console.WriteLine($"Все слова начинаются с согласной? {allSoglas}");

        }
    }
}