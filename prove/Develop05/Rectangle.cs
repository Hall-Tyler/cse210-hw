using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    internal class Rectangle : Shape
    {
        private double recLen;
        private double recWid;

        public Rectangle(string color, double length, double width) : base(color)
        {
            recLen = length;
            recWid = width;
        }

        public override double GetArea()
        {
            return recLen * recWid;
        }
    }
}
