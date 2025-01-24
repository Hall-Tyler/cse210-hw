using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop02
{
    internal class JournalInterface
    {
        private string saveLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/journals";

        public void RunJournalApp()
        {
            CreateFileDirectory();
            JournalEntry journalEntry = new JournalEntry();

            Console.WriteLine("Welcome to the journal app!");

            while (true)
            {
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do(1-5): ");

                string selectionInput = Console.ReadLine();
                int selection = int.Parse(selectionInput);

                switch (selection)
                {
                    case 1:
                        journalEntry.CreateJournalEntry();
                        break;
                    case 2:
                        journalEntry.DisplayJournalEntrys();
                        break;
                    case 3:
                        journalEntry.SaveJournalEntrys(saveLocation);
                        break;
                    case 4:
                        journalEntry.LoadJournalEntrys(saveLocation);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("That is not a valid selection!");
                        break;
                }
            }
        }
        private void CreateFileDirectory()
        {
            System.IO.Directory.CreateDirectory(saveLocation);
        }
    }
}
