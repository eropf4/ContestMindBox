using ContestMindBox.Interfaces;
using System;
using System.Linq;

namespace ContestMindBox.Figures
{
    public class Triangle : IFigure
    {
        private double[] _sidesLength;

        public double[] SidesLength
        {
            get { return _sidesLength; }
            private set
            {
                value = value.OrderBy(x => x).ToArray();
                if (value[2] >= (value[1] + value[0]))
                    throw new Exception("Такого треугольника не существует!");
                else _sidesLength = value;
            }
        }

        public Triangle(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            SidesLength = new double[3] { firstSideLength, secondSideLength, thirdSideLength };
        }

        public double GetSquare()
        {
            var semiPerimeter = GetPerimeter() / 2;
            return  Math.Sqrt(semiPerimeter 
                * (semiPerimeter - SidesLength[2])
                * (semiPerimeter - SidesLength[1])
                * (semiPerimeter - SidesLength[0]));
        }

        private double GetPerimeter()
        {
            return SidesLength.Sum();
        }

        public bool IsRectangular()
        {
            return Math.Pow(SidesLength[2], 2) == (Math.Pow(SidesLength[1], 2) + Math.Pow(SidesLength[0], 2));
        }
    }
}
