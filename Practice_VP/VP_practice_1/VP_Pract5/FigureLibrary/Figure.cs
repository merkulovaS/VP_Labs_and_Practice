using System;

namespace FigureLibrary
{
    public abstract class Figure: IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj is Figure other)
            {
                return Area.CompareTo(other.Area);
            }

            throw new ArgumentException("Объект не является фигурой");
        }


        private string _name;
        private string _color;

        // Название фигуры.
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название фигуры не может быть пустым.", nameof(value));
                _name = value;
            }
        }

        /// <summary>
        /// Цвет фигуры.
        /// </summary>
        public string Color
        {
            get => _color;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Цвет фигуры не может быть пустым.", nameof(value));
                _color = value;
            }
        }

        /// <summary>
        /// Конструктор базового класса Figure.
        /// </summary>
        /// <param name="name">Название фигуры.</param>
        /// <param name="color">Цвет фигуры.</param>
        protected Figure(string name, string color)
        {
            Name = name;
            Color = color;
        }

        /// <summary>
        /// Абстрактное свойство для вычисления периметра фигуры.
        /// </summary>
        public abstract double Perimeter { get; }

        /// <summary>
        /// Абстрактное свойство для вычисления площади фигуры.
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        /// Переопределенный метод ToString для вывода информации о фигуре.
        /// </summary>
        /// <returns>Строка с информацией о фигуре.</returns>
        public override string ToString()
        {
            return $"Фигура: {Name}. Цвет: {Color}. Периметр: {Perimeter:F2}. Площадь: {Area:F2}.";
        }
    }
}