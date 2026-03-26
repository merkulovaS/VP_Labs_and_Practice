//using FigureLibrary;
//using System;
//using System.Collections.Generic;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        private static List<Figure> _figures = new List<Figure>();

//        static void Main(string[] args)
//        {
//            Console.WriteLine("=== Программа для работы с геометрическими фигурами ===");

//            bool exit = false;
//            while (!exit)
//            {
//                ShowMainMenu();
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        CreateFigure();
//                        break;
//                    case "2":
//                        ShowAllFigures();
//                        break;
//                    case "3":
//                        exit = true;
//                        Console.WriteLine("Программа завершена. До свидания!");
//                        break;
//                    default:
//                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите пункт меню 1-3.");
//                        break;
//                }

//                if (!exit)
//                {
//                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
//                    Console.ReadKey();
//                    Console.Clear();
//                }
//            }
//        }

//        static void ShowMainMenu()
//        {
//            Console.WriteLine("\nГлавное меню:");
//            Console.WriteLine("1. Создать новую фигуру");
//            Console.WriteLine("2. Показать все созданные фигуры");
//            Console.WriteLine("3. Выход");
//            Console.Write("Ваш выбор: ");
//        }

//        static void ShowFigureTypeMenu()
//        {
//            Console.WriteLine("\nВыберите тип фигуры:");
//            Console.WriteLine("1. Круг");
//            Console.WriteLine("2. Кольцо");
//            Console.WriteLine("3. Прямоугольник (CustomRectangle)");
//            Console.WriteLine("4. Ромб");
//            Console.WriteLine("5. Квадрат");
//            Console.WriteLine("6. Правильный треугольник");
//            Console.WriteLine("0. Отмена");
//            Console.Write("Ваш выбор: ");
//        }

//        static void CreateFigure()
//        {
//            ShowFigureTypeMenu();
//            string choice = Console.ReadLine();

//            try
//            {
//                Console.Write("Введите цвет фигуры: ");
//                string color = Console.ReadLine();

//                if (string.IsNullOrWhiteSpace(color))
//                {
//                    Console.WriteLine("Ошибка: Цвет не может быть пустым!");
//                    return;
//                }

//                Figure figure = null;

//                switch (choice)
//                {
//                    case "1":
//                        figure = CreateCircle(color);
//                        break;
//                    case "2":
//                        figure = CreateRing(color);
//                        break;
//                    case "3":
//                        figure = CreateCustomRectangle(color);
//                        break;
//                    case "4":
//                        figure = CreateRhombus(color);
//                        break;
//                    case "5":
//                        figure = CreateSquare(color);
//                        break;
//                    case "6":
//                        figure = CreateTriangle(color);
//                        break;
//                    case "0":
//                        Console.WriteLine("Создание фигуры отменено.");
//                        return;
//                    default:
//                        Console.WriteLine("Ошибка: Неверный выбор типа фигуры.");
//                        return;
//                }

//                if (figure != null)
//                {
//                    _figures.Add(figure);
//                    Console.WriteLine("\nФигура успешно создана!");
//                    Console.WriteLine(figure.ToString());
//                }
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine($"Ошибка при создании фигуры: {ex.Message}");
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Ошибка: Введено некорректное число. Используйте десятичный разделитель ',' (запятая).");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
//            }
//        }

//        static Circle CreateCircle(string color)
//        {
//            Console.Write("Введите радиус круга: ");
//            double radius = double.Parse(Console.ReadLine());
//            return new Circle(color, radius);
//        }

//        static Ring CreateRing(string color)
//        {
//            Console.Write("Введите внешний радиус кольца: ");
//            double outerRadius = double.Parse(Console.ReadLine());

//            Console.Write("Введите внутренний радиус кольца: ");
//            double innerRadius = double.Parse(Console.ReadLine());

//            return new Ring(color, outerRadius, innerRadius);
//        }

//        static CustomRectangle CreateCustomRectangle(string color)
//        {
//            Console.Write("Введите длину первой стороны: ");
//            double sideA = double.Parse(Console.ReadLine());

//            Console.Write("Введите длину второй стороны: ");
//            double sideB = double.Parse(Console.ReadLine());

//            return new CustomRectangle(color, sideA, sideB);
//        }

//        static Rhombus CreateRhombus(string color)
//        {
//            Console.Write("Введите длину стороны ромба: ");
//            double side = double.Parse(Console.ReadLine());

//            Console.Write("Введите угол между сторонами (в градусах): ");
//            double angle = double.Parse(Console.ReadLine());

//            return new Rhombus(color, side, angle);
//        }

//        static Square CreateSquare(string color)
//        {
//            Console.Write("Введите длину стороны квадрата: ");
//            double side = double.Parse(Console.ReadLine());

//            return new Square(color, side);
//        }

//        static Triangle CreateTriangle(string color)
//        {
//            Console.Write("Введите длину стороны правильного треугольника: ");
//            double side = double.Parse(Console.ReadLine());

//            return new Triangle(color, side);
//        }

//        static void ShowAllFigures()
//        {
//            if (_figures.Count == 0)
//            {
//                Console.WriteLine("\nСписок фигур пуст. Создайте хотя бы одну фигуру.");
//                return;
//            }

//            Console.WriteLine($"\n{'№',-4} {"Тип",-15} {"Цвет",-10} {"Периметр",-12} {"Площадь",-12} {"Доп. параметры",-30}");
//            Console.WriteLine(new string('-', 85));

//            for (int i = 0; i < _figures.Count; i++)
//            {
//                Figure figure = _figures[i];
//                string figureType = figure.GetType().Name;
//                string additionalParams = GetAdditionalParams(figure);

//                Console.WriteLine($"{i + 1,-4} {figureType,-15} {figure.Color,-10} {figure.Perimeter:F2,-12} {figure.Area:F2,-12} {additionalParams,-30}");
//            }

//            // Детальная информация
//            Console.WriteLine("\nДетальная информация:");
//            for (int i = 0; i < _figures.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}. {_figures[i].ToString()}");
//            }
//        }

//        static string GetAdditionalParams(Figure figure)
//        {
//            switch (figure)
//            {
//                case Ring ring:
//                    return $"R={ring.Radius:F2}, r={ring.InnerRadius:F2}";
//                case Circle circle:
//                    return $"R={circle.Radius:F2}";
//                case CustomRectangle rect:
//                    return $"a={rect.SideA:F2}, b={rect.SideB:F2}";
//                case Rhombus rhombus:
//                    return $"a={rhombus.SideA:F2}, α={rhombus.Angle:F2}°";
//                case Square square:
//                    return $"a={square.SideLength:F2}";
//                case Triangle triangle:
//                    return $"a={triangle.SideLength:F2}";
//                default:
//                    return string.Empty;
//            }
//        }
//    }
//}