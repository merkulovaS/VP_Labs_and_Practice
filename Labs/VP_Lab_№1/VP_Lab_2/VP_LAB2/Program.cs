using System;
using System.Text.RegularExpressions;

namespace UniversityApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите номер группы: ");
            string groupNumber = Console.ReadLine();
            Console.WriteLine();

            Group group = new Group(groupNumber);

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("1 - Добавить студента");
                Console.WriteLine("2 - Удалить студента");
                Console.WriteLine("3 - Найти студента");
                Console.WriteLine("4 - Показать список группы");
                Console.WriteLine("0 - Выход");
                Console.WriteLine();

                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(group);
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.Write("Введите номер зачетки: ");
                        string removeId = Console.ReadLine();
                        Console.WriteLine();

                        group.Remove(removeId);
                        Console.WriteLine($"Студент {removeId} удален");
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.Write("Введите номер зачетки: ");
                        string searchId = Console.ReadLine();
                        Console.WriteLine();

                        Student foundStudent = group[searchId];

                        if (foundStudent == null)
                            Console.WriteLine("Студент не найден.");
                        else
                            Console.WriteLine(foundStudent.GetInfo());

                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine(group.ToString());
                        Console.WriteLine();
                        break;

                    case "0":
                        Console.WriteLine("Выход из программы...");
                        Console.WriteLine();
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static void AddStudent(Group group)
        {
            Console.WriteLine("Добавление студента");

            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine();

            Console.Write("Имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Отчество (можно пустое): ");
            string middleName = Console.ReadLine();

            Console.Write("Дата рождения: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Адрес: ");
            string address = Console.ReadLine();

            Console.Write("Телефон: ");
            string phone = Console.ReadLine();

            Console.Write("Номер зачетки: ");
            string id = Console.ReadLine();

            Console.Write("Гражданство: ");
            string citizenship = Console.ReadLine();

            Console.Write("Форма обучения (0-Бюджет, 1-Коммерция, 2-Целевое): ");
            int formNumber = int.Parse(Console.ReadLine());
            StudyForm form = (StudyForm)formNumber;

            Student newStudent = new Student(
                lastName, firstName, middleName,
                birthDate, address, phone,
                id, citizenship, form);

            group.Add(newStudent);
            Console.WriteLine();
        }
    }
}
