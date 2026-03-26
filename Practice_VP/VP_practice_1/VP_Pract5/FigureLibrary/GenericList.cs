using System;
using System.Collections.Generic;

namespace FigureLibrary
{
    public class GenericList<T, K> where T : IComparable
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void CompareWith(K value)
        {
            foreach (var item in items)
            {
                if (item.ToString().Contains(value.ToString()))
                {
                    Console.WriteLine($"Найдено совпадение: {item}");
                }
            }
        }

        public void BubbleSort()
        {
            for (int i = 0; i < items.Count - 1; i++)
            {
                for (int j = 0; j < items.Count - i - 1; j++)
                {
                    if (items[j].CompareTo(items[j + 1]) > 0)
                    {
                        T temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }

        public void Print()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}