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
    public class TriangleTests
    {
        [TestMethod()]
        public void GetAreaFigure_RectangularTriangle_33And44and55_726returned()
        {
            double sideA = 33;
            double sideB = 44;
            double @base = 55;
            double expected = 726;

            Triangle triangle = new Triangle(sideA, sideB, @base);
            double actual = triangle.GetAreaFigure();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetAreaFigure_55And44and55_1108returned()
        {
            double sideA = 55;
            double sideB = 44;
            double @base = 55;
            double expected = 1108.98;

            Triangle triangle = new Triangle(sideA, sideB, @base);
            double actual = triangle.GetAreaFigure();
            actual = Math.Round(actual, 2);
            Assert.AreEqual(expected, actual);

        }
    }
}