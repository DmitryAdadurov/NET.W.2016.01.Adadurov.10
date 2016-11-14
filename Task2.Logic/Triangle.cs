using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Logic
{
    public class Triangle : IFigure
    {
        private double[] _sides;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException();

            _sides = new double[] { a, b, c};
        }

        public double[] Sides
        {
            get
            {
                return _sides;
            }
        }

        public double Perimeter()
        {
            return _sides[0] + _sides[1] + _sides[2];
        }

        public double Area()
        {
            double p = Perimeter();
            return Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
        }
    }
}
