using Exception;
using System;
using System.Collections;

namespace Exception
{
    class Program
    {
        static void Main()
        {
            Shop shop = new Shop();

            Item item1 = new Item(001, "Телефон", "Черный", 500);
            Item item2 = new Item(002, "Ноутбук", "Серый", 1200);
            Item item3 = new Item(001, "Планшет", "Белый", 300);
            Item item4 = new Item(003, "Монитор", "Черный", 800);
            Item item5 = new Item(004, "Клавиатура", "Белый", 150);
            Item item6 = new Item(002, "Ноутбук", "Серый", 70);
            Item item7 = new Item(024, "Планшет", "Черный", 340);
            Item item8 = new Item(010, "Монитор", "Белый", 1580);

            Item[] items = { item1, item2, item3, item4, item5, item6, item7, item8 };

            foreach (Item item in items)
            {
                try
                {
                    shop.AddItem(item);
                }
                catch (ExistingItemCodeException ex)
                {
                    Console.WriteLine("Ошибка: товар с таким артикулом уже существует!");

                    Console.WriteLine("Данные товара:");
                    foreach (DictionaryEntry d in ex.Data)
                    {
                        Console.WriteLine($"{d.Key}: {d.Value}");
                    }
                }
            }


            Console.WriteLine("\nСписок товаров:");
            shop.ShowItems();

            Console.WriteLine("\nСравнение throw ");

            try
            {
                try
                {
                    throw new ExistingItemCodeException(item1);
                }
                catch (ExistingItemCodeException ex)
                {
                    throw ex;
                }
            }
            catch (ExistingItemCodeException ex)
            {
                Console.WriteLine("CASE 1 (throw ex):");
                Console.WriteLine(ex.StackTrace);
            }

                   try
            {
                try
                {
                    throw new ExistingItemCodeException(item2);
                }
                catch (ExistingItemCodeException)
                {
                    throw;
                }
            }
            catch (ExistingItemCodeException ex)
            {
                Console.WriteLine("\nCASE 2 (throw):");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}