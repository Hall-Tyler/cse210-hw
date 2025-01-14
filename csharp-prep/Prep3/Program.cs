using System;

class Program
{
    static void Main(string[] args)
    {
        bool guessed = false;
        Console.Write("What is the magic number: ");
        string magicNumber = Console.ReadLine();

        while (!guessed)
        {
            Console.Write("What is your guess: ");
            string guessNumber = Console.ReadLine();

            if (int.Parse(guessNumber) > int.Parse(magicNumber))
            {
                Console.WriteLine("Lower");
            }
            else if (int.Parse(guessNumber) < int.Parse(magicNumber))
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                guessed = true;
            }
        }
    }
}