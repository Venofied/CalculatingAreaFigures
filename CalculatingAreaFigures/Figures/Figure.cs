using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaFigures.Figures
{
    public class Figure : AbstractFactoryFigure.AbstractFactoryFigure
    {
        /// <summary>
        /// Объявление класса круга
        /// </summary>
        /// <param name="radius">радиус круга</param>
        /// <returns>Class Circle</returns>
        public override Circle FigureCircle(double radius)
        {
            return new Circle(radius);
        }
        /// <summary>
        /// Объявление класса треугольника
        /// </summary>
        /// <param name="sideA"> Сторона А </param>
        /// <param name="sideB"> Сторона Б </param>
        /// <param name="base"> Основание </param>
        /// <returns>Class Triangle</returns>
        public override Triangle FigureTriangle(double sideA, double sideB, double @base)
        {
            return new Triangle(sideA, sideB, @base);
        }
        /// <summary>
        /// Возвращает класс взависимости от количество сторон в фигуре
        /// Мало входящих данных чтобы отличать фигуры (ромб и трапеция)
        /// </summary>
        /// <param name="values">количество сторон в фигуре</param>
        /// <returns></returns>
        public override dynamic UnknownFigure(List<double> values)
        {
            
            if (values.Count == 1)
            {
                return FigureCircle(values.FirstOrDefault());
            }
            else if(values.Count == 3)
            {
                return FigureTriangle(values[0], values[1], values[2]);
            }
            else
            {
                return null;
            }
        }

    }
}
