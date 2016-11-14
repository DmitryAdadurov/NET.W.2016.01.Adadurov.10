using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Logic
{
    public class Rectangle : IFigure
    {
        private double[] _sides;

        public Rectangle(double a, double b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentOutOfRangeException();

            _sides = new double[] { a, b };
        }

        public double[] Sides
        {
            get
            {
                return _sides;
            }
        }

        public virtual double Perimeter()
        {
            return (_sides[0] + _sides[1]) * 2;
        }

        public virtual double Area()
        {
            return _sides[0] * _sides[1];
        }
    }
}
