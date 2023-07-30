using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaFigures.Figures
{
    public class Triangle : AbstractFigure
    {
        private double _sideA { get; set; }
        private double _sideB { get; set; }
        private double _base { get; set; }

        public override EnumListFigure.TypeFigure Type
        {
            get
            {
                return EnumListFigure.TypeFigure.Triangle;
            }
        }

        private Triangle() { }
        /// <summary>
        /// Класс треугольника по 3 сторонам
        /// </summary>
        /// <param name="sideA"> Сторона А </param>
        /// <param name="sideB"> Сторона Б </param>
        /// <param name="base"> Основание </param>
        public Triangle(double sideA, double sideB, double @base) : this()
        {
            _sideA = sideA;
            _sideB = sideB;
            _base = @base;
        }
        /// <summary>
        /// Площадь треульника
        /// </summary>
        /// <returns>double AreaTriangle</returns>
        public override double GetAreaFigure()
        {
            double area = 0;
            RectangularTriangle rectangularTriangle = GetAngleTriangle();
            if (rectangularTriangle.Rectangular)
            {
                area = rectangularTriangle.CathetA * rectangularTriangle.CathetB / 2;
                return area;
            }
            else
            {
                double p = (_base + _sideA + _sideB) / 2;
                area = Math.Sqrt(p * (p - _base) * (p - _sideA) * (p - _sideB));
                return area;
            }
        }
        /// <summary>
        /// Поиск прямоугольного треульника
        /// </summary>
        /// <returns>class RectangularTriangle</returns>
        private RectangularTriangle GetAngleTriangle()
        {
            double cosA = (Math.Sqrt(_sideA) + Math.Sqrt(_base) - Math.Sqrt(_sideB)) / (2 * _sideA * _base);
            if(cosA == 90)
            {
                return new RectangularTriangle(true, _sideA, _base);
            }
            double cosB = (Math.Sqrt(_sideA) + Math.Sqrt(_sideB) - Math.Sqrt(_base)) / (2 * _sideA * _sideB);

            if(cosB == 90)
            {
                return new RectangularTriangle(true, _sideA, _sideB);
            }

            double cosY = (Math.Sqrt(_sideB) + Math.Sqrt(_base) - Math.Sqrt(_sideA)) / (2 * _base * _sideB);
            if(cosY == 90)
            {
                return new RectangularTriangle(true, _sideB, _base);
            }

            return new RectangularTriangle(false);

        }
    }
    public class RectangularTriangle
    {
        public bool Rectangular { get; set; }
        public double CathetA { get; set; }
        public double CathetB { get; set; }

        public RectangularTriangle(bool rectangular, double cathetA = 0, double cathetB = 0)
        {
            Rectangular = rectangular;
            if(Rectangular)
            {
                CathetA = cathetA;
                CathetB = cathetB;
            }

        }
    }
}
