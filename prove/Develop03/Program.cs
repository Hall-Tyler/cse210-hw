using Develop03;
using Microsoft.VisualBasic;
using System;

class Program
{
    static void Main(string[] args)
    {
        References references = new References();

        references.SetReference("John", "3:16", "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have eternal life");
        references.SetReference("John", "16:33", "I have told you these things, so that in me you may have peace.In this world you will have trouble.But take heart! I have overcome the world.");

        int scriptureIndex = references.GetRandomScripture();

        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            references.DisplayScripture(scriptureIndex, false);

            Console.WriteLine("Press the enter key to start, or type quit to exit!");
            string input = Console.ReadLine();
            var userInput = Console.ReadKey();

            if (userInput.Key == ConsoleKey.Enter)
            {
                references.DisplayScripture(scriptureIndex, true);
            }

            if (input == "quit")
            {
                isRunning = false;
                System.Environment.Exit(1);
            }
        }
    }
}