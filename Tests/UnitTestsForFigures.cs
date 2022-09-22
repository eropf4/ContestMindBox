using ContestMindBox.Figures;
using ContestMindBox.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestsForFigures
{
    [TestFixture]
    public class UnitTestsForFigures
    {
        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 5, 6, 12)]
        [TestCase(5,12,13,30)]
        [TestCase(4, 13, 15, 24)]

        public void CheckTriangleSquare(double a, double b, double c, double expectedResult)
        {
            Assert.AreEqual(expectedResult, new Triangle(a, b, c).GetSquare());
        }

        [TestCase(7, 1, 4)]
        [TestCase(2, 5, 7)]
        [TestCase(0, 0, 0)]
        public void CheckNotTriangle(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => new Triangle(a, b, c));
        }

        [TestCase(3,4,5,true)]
        [TestCase(5,12,13, true)]
        public void CheckTriangleIsRectangular (double a, double b, double c, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, new Triangle(a, b, c).IsRectangular());
        }

        [TestCase(1, Math.PI)]
        [TestCase(3, Math.PI*9)]
        [TestCase(1/Math.PI, 1/Math.PI)]
        public void CheckCircleSquare(double radius, double expectedResult)
        {
            Assert.AreEqual(new Circl(radius).GetSquare(), expectedResult);
        }

        [TestCase(0)]
        public void CheckNullCircle(double radius)
        {
            Assert.Throws<Exception>(() => new Circl(radius));
        }

        [Test]
        public void CheckInterface ()
        {
            var figureArray = new List<IFigure>();

            figureArray.Add(new Circl(3));
            figureArray.Add(new Triangle(3, 4, 5));
            figureArray.Add(new Circl(1 / Math.PI));
            figureArray.Add(new Triangle(5, 12, 13));

            var figuresSquare = figureArray.Select(x => x.GetSquare()).ToArray();
            var expectedResult = new double[4] { Math.PI * 9, 6, 1 / Math.PI, 30 };

            Assert.AreEqual(figuresSquare, expectedResult);
        }
    }
}
