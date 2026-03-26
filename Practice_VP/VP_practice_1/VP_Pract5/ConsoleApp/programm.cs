using System;
using FigureLibrary;

class Programm
{
    static void Main()
    {
        Console.WriteLine("Строки до сортировки:");

        GenericList<string, string> words = new GenericList<string, string>();
     
        words.Add("Груша ");
        words.Add("Яблоко ");
        words.Add("Апельсин ");
        words.Add("Банан ");
        words.CompareWith("Яблоко");

        words.Print();

        words.BubbleSort();

        Console.WriteLine("Строки после сортировки:");
        words.Print();

        Console.WriteLine("Фигуры до сортировки:");


        GenericList<Figure, string> figures = new GenericList<Figure, string>();

        figures.Add(new Square("Красный", 4));
        figures.Add(new Square("Синий", 2));
        figures.Add(new Square("Зеленый", 6));

        figures.CompareWith("Синий");

        figures.Print();

        figures.BubbleSort();

        Console.WriteLine("Фигуры после сортировки по площади:");
        figures.Print();
    }
}