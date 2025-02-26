using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class ReflectingActivity : Activity
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the Reflecting Activity");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            int sessionTime = SessionTime();
            Console.WriteLine("Get ready...");
            Animation();

            List<string> prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
            List<string> questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];

            Console.WriteLine("Consider the following prompt: ");
            Random rand = new Random();
            int promptIndex = rand.Next(0, prompts.Count);
            Console.WriteLine($"--- {prompts[promptIndex]} ---");
            Console.WriteLine("When you have something in mind press enter to continue.");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(5 - j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Clear();

            int questionCount = sessionTime / 5;
            for (int i = 0; i < questionCount; i++)
            {
                int questionIndex = rand.Next(0, questions.Count);
                Console.Write(questions[questionIndex]);
                Animation();
                Console.Write("\n");
            }

            ActivityCompleted(sessionTime, "Reflecting Activity");
        }
    }
}
