using StringInfoLibrary;
using System.Text.RegularExpressions;
using UniversityApp;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Демонстрация методов расширения \n");

        // Демонстрация метода расширения для string
        DemonstrateStringExtensions();

        // Демонстрация метода расширения для Group
        DemonstrateGroupExtensions();

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static void DemonstrateStringExtensions()
    {
        Console.WriteLine(" Метод расширения для string");

        string test1 = "Hello, World! 123";
        string test2 = "2026 Year";
        string? test3 = null;

        Console.WriteLine($"Строка: \"{test1}\" -> {test1.GetStringInfo()}");
        Console.WriteLine($"Строка: \"{test2}\" -> {test2.GetStringInfo()}");

        // Проверка на null
        var infoForNull = test3.GetStringInfo();
        Console.WriteLine($"Строка: null -> {infoForNull}");

        Console.WriteLine();
    }

    static void DemonstrateGroupExtensions()
    {
        Console.WriteLine("Метод расширения для Group");

        // Создаем группу и добавляем студентов
        UniversityApp.Group group = new UniversityApp.Group("ПИН-242");

        // Создаем несколько студентов для примера
        Student student1 = new Student(
            lastName: "Иванов",
            firstName: "Иван",
            middleName: "Иванович",
            birthDate: new DateTime(2000, 1, 1),
            address: "ул. Ленина, д. 1",
            phone: "123-45-67",
            id: "001",
            citizenship: "РФ",
            form: StudyForm.Budget
        );

        Student student2 = new Student(
            lastName: "Петрова",
            firstName: "Анна",
            middleName: "", // Отчества нет
            birthDate: new DateTime(2001, 5, 10),
            address: "ул. Гагарина, д. 5",
            phone: "234-56-78",
            id: "002",
            citizenship: "РФ",
            form: StudyForm.Commercial
        );

        Student student3 = new Student(
            lastName: "Сидоров",
            firstName: "Петр",
            middleName: "Петрович",
            birthDate: new DateTime(1999, 12, 20),
            address: "ул. Победы, д. 10",
            phone: "345-67-89",
            id: "003",
            citizenship: "РФ",
            form: StudyForm.Budget
        );

        // Добавляем студентов в группу
        group.Add(student1);
        group.Add(student2);
        group.Add(student3);

        // Вызываем наш метод расширения!
        string statistics = group.GetStudentsStatistics();
        Console.WriteLine(statistics);
    }
}