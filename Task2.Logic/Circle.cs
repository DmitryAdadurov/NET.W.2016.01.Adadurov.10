using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Logic
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                    _radius = value;
            }
        }

        public double Diameter
        {
            get
            {
                return _radius * 2;
            }
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
