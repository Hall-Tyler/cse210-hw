using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class Activity
    {
        private int breathingActivitysCompleted = 0;
        private int reflectingActivitysCompleted = 0;
        private int listingActivitysCompleted = 0;

        public void RunActivityManager()
        {
            int response;
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            response = Int32.Parse(Console.ReadLine());

            switch (response)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    breathingActivitysCompleted++;
                    break;
                case 2:
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    reflectingActivitysCompleted++;
                    break;
                case 3:
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    listingActivitysCompleted++;
                    break;
                case 4:
                    Console.WriteLine($"You completed {breathingActivitysCompleted} breathing activites, {reflectingActivitysCompleted} reflecting activites, and {listingActivitysCompleted} listing activities.");
                    return;
                default:
                    Console.WriteLine("That is not a valid choice");
                    break;
            }
        }

        public int SessionTime()
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string sessionTime = Console.ReadLine();
            return int.Parse(sessionTime);
        }

        public void Animation()
        {
            List<string> frames = ["-", "\\", "|", "/"];

            for (int i = 0; i < 5; i++)
            {
                foreach (string frame in frames)
                {
                    Console.Write(frame);
                    Thread.Sleep(350);
                    Console.Write("\b \b");
                }
            }
        }

        public void ActivityCompleted(int time, string activity)
        {
            Console.Write("\n");

            Console.WriteLine("Well Done!");
            Animation();

            Console.WriteLine($"You have completed another {time} seconds of the {activity}");
            Animation();

            RunActivityManager();
        }
    }
}
