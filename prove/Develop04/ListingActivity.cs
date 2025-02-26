using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class ListingActivity : Activity
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the Listing Activity");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

            int sessionTime = SessionTime();
            Console.WriteLine("Get ready...");
            Animation();

            List<string> prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
            
            Console.WriteLine("List as many responses to the following prompt as you can: ");
            Random rand = new Random();
            int promptIndex = rand.Next(0, prompts.Count);
            Console.WriteLine($"--- {prompts[promptIndex]} ---");
            Console.Write("You may begin in: ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(5 - j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\n");

            List<string> responses = new List<string>();

            bool timeUp = false;
            Thread inputThread = new Thread(() =>
            {
                while (!timeUp)
                {
                    string input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input) && !timeUp)
                    {
                        responses.Add(input);
                    }
                }
            });

            inputThread.Start();
            Thread.Sleep(sessionTime * 1000);
            timeUp = true;

            Console.WriteLine($"You have listed {responses.Count} items!");

            ActivityCompleted(sessionTime, "Listing Activity");
        }
    }
}
