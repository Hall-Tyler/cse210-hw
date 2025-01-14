using System;

class Program
{
    void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        return int.Parse(number);
    }

    int SquareNumber(int number)
    {
        return number * number;
    }

    void DisplayResult(string usersName, int squaredNumber)
    {
        Console.WriteLine($"{usersName}, the square of your number is {squaredNumber}");
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        program.DisplayWelcome();
        string usersName = program.PromptUserName();
        int usersNumber = program.PromptUserNumber();
        int squaredNumber = program.SquareNumber(usersNumber);
        program.DisplayResult(usersName, squaredNumber);
    }
}