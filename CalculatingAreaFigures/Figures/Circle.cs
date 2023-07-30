using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaFigures.Figures
{
    public class Circle : AbstractFigure
    {
        private double _radius { get; set; }

        public override EnumListFigure.TypeFigure Type
        {
            get
            {
                return EnumListFigure.TypeFigure.Circle;
            }
        }

        private Circle() { }
        /// <summary>
        /// Класс круга по радиусу
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius) : this()
        {
            this._radius = radius;
        }
        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns>double AreaCircle</returns>
        public override double GetAreaFigure()
        {
            double area = 0;
            area = Math.PI * (Math.Pow(_radius, 2));
            return area;       
        }
    }
}
