using System;

namespace Delegate 
{
    public class DynamicArray<T>
    {
        private T[] data; 
        private int count; 

        // Конструктор
        public DynamicArray(int size)
        {
            data = new T[size]; 
            count = 0;
        }

        // Добавление элемента в массив
        public void Add(T item)
        {
            // Если массив заполнен
            if (count >= data.Length)
            {
                // создаём новый массив в 2 раза больше
                T[] newData = new T[data.Length * 2];

                // копируем старые элементы в новый массив
                Array.Copy(data, newData, data.Length);

                // заменяем старый массив новым
                data = newData;
            }
            // добавляем элемент и увеличиваем счётчик
            data[count++] = item;
        }

        // Вывод элементов на экран
        public void Print()
        {
            for (int i = 0; i < count; i++)
                Console.Write(data[i] + " ");

            Console.WriteLine();
        }

        // Фильтрация массива
        public void Filter(Func<T, bool> operation)
        {
            T[] newData = new T[data.Length];

            int newCount = 0;

            for (int i = 0; i < count; i++)
            {
                if (operation(data[i]))
                {
                    newData[newCount++] = data[i];
                }
            }
            data = newData;
            count = newCount;
        }

        // Сортировка массива
        public void Sort(Func<T, T, int> operation)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (operation(data[i], data[j]) > 0)
                    {
                        T temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
        public bool Any(Func<T, bool> operation)
        {
            for (int i = 0; i < count; i++)
            {
                if (operation(data[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool All(Func<T, bool> operation)
        {
            for (int i = 0; i < count; i++)
            {
                if (!operation(data[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}