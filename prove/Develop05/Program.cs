using Develop05;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 4);
        shapes.Add(square);

        Rectangle rec = new Rectangle("yellow", 4, 2);
        shapes.Add(rec);

        Circle cir = new Circle("green", 3);
        shapes.Add(cir);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"Color: {color}, Area: {area}.");
        }
    }
}