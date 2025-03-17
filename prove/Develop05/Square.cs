using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    internal class Square : Shape
    {
        private double squareSide;

        public Square(string color, double side) : base(color)
        {
            squareSide = side;
        }

        public override double GetArea()
        {
            return squareSide * squareSide;
        }
    }
}
