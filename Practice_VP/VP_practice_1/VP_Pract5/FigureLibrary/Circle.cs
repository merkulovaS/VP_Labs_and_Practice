using System;

namespace FigureLibrary
{
    /// <summary>
    /// Класс, представляющий круг.
    /// </summary>
    public class Circle : Figure
    {
        private double _radius;

        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Радиус должен быть больше нуля.", nameof(value));
                _radius = value;
            }
        }

        /// <summary>
        /// Конструктор класса Circle.
        /// </summary>
        /// <param name="color">Цвет круга.</param>
        /// <param name="radius">Радиус круга.</param>
        public Circle(string color, double radius) : base("Круг", color)
        {
            Radius = radius;
        }

        /// <summary>
        /// Вычисляет периметр (длину окружности) круга.
        /// </summary>
        public override double Perimeter => 2 * Math.PI * Radius;

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        public override double Area => Math.PI * Radius * Radius;
    }
}