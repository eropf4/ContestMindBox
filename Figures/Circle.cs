using ContestMindBox.Interfaces;
using System;

namespace ContestMindBox.Figures
{
    public class Circl : IFigure
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            private set
            {
                if (value == 0)
                    throw new Exception("Неверное значение радиуса круга!");
                else _radius = value;
            }
        }

        public Circl(double radius)
        {
            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
