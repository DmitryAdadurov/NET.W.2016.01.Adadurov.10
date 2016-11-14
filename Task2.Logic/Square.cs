using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Logic
{
    public class Square : Rectangle
    {
        public Square(int side):base(side, side)
        {
        }

        public override double Perimeter()
        {
            return base.Sides[0] * 4;
        }

        public override double Area()
        {
            return base.Sides[0] * 2;
        }
    }
}
