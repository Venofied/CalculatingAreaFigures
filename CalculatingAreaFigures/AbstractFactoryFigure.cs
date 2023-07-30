using CalculatingAreaFigures.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryFigure
{
    public abstract class AbstractFactoryFigure
    {
        public abstract Triangle FigureTriangle(double sideA, double sideB, double @base);
        public abstract Circle FigureCircle(double radius = 0);
        public abstract dynamic UnknownFigure(List<double> values);

    }
}
