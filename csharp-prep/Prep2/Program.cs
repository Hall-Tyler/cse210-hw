using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentageGrade = Console.ReadLine();
        string letterGrade;

        if (int.Parse(percentageGrade) >= 90)
        {
            letterGrade = "A";
        }
        else if (int.Parse(percentageGrade) >= 80)
        {
            letterGrade = "B";
        }
        else if (int.Parse(percentageGrade) >= 70)
        {
            letterGrade = "C";
        }
        else if (int.Parse(percentageGrade) >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine(letterGrade);

        if (int.Parse(percentageGrade) >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
    }
}