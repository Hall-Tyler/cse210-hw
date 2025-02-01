using Learning03;
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(10);
        Fraction fraction3 = new Fraction(50, 5);

        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBottom());

        fraction2.SetTop(100);
        fraction2.SetBottom(20);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}