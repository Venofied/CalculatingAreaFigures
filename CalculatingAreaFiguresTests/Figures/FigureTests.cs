using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatingAreaFigures.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaFigures.Figures.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void GetAreaFigure_Circle_0565_1003returned()
        {
            double radius = 0.565;
            double expected = 1.003;


            List<double> values = new List<double>();
            values.Add(radius);
            Figure figure = new Figure();
            Circle circle = figure.UnknownFigure(values);
            double actual = circle.GetAreaFigure();
            actual = Math.Round(actual, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaFigure_Triangle_RectangularTriangle_33And44and55_726returned()
        {
            double sideA = 33;
            double sideB = 44;
            double @base = 55;
            double expected = 726;

            List<double> values = new List<double>();
            values.Add(sideA);
            values.Add(sideB);
            values.Add(@base);
            Figure figure = new Figure();
            Triangle triangle = figure.UnknownFigure(values);
            double actual = triangle.GetAreaFigure();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetAreaFigure_Triangle_55And44and55_1108returned()
        {
            double sideA = 55;
            double sideB = 44;
            double @base = 55;
            double expected = 1108.98;

            List<double> values = new List<double>();
            values.Add(sideA);
            values.Add(sideB);
            values.Add(@base);
            Figure figure = new Figure();
            Triangle triangle = figure.UnknownFigure(values);
            double actual = triangle.GetAreaFigure();
            actual = Math.Round(actual, 2);
            Assert.AreEqual(expected, actual);

        }
    }
}