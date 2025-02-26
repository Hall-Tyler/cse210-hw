using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class BreathingActivity : Activity
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the Breathing Activity");
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

            int sessionTime = SessionTime();
            Console.WriteLine("Get ready...");
            Animation();

            for (int i = 0; i < sessionTime; i += 10)
            {
                Console.Write("\n");

                Console.Write("Breath in...");
                for (int j = 0; j < 6; j++) {
                    Console.Write(6 - j);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

                Console.Write("\n");

                Console.Write("Breath out...");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(4 - j);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            }

            ActivityCompleted(sessionTime, "Breathing Activity");
        }
    }
}
