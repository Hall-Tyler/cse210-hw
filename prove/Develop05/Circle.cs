using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    internal class Circle : Shape
    {
        private double cirRadius;

        public Circle(string color, double radius) : base(color)
        {
            cirRadius = radius;
        }

        public override double GetArea()
        {
            return cirRadius * cirRadius * Math.PI;
        }
    }
}
