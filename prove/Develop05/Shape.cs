using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    internal abstract class Shape
    {
        private string shapeColor;

        public string GetColor()
        {
            return shapeColor;
        }

        public void SetColor(string color)
        {
            shapeColor = color;
        }

        public Shape(string color) 
        { 
            shapeColor = color;
        }

        public abstract double GetArea();
    }
}
