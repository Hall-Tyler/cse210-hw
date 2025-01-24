using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Entry
{
    public string date;
    public string prompt;
    public string response;
}

namespace Develop02
{
    internal class JournalEntry
    {
        private List<Entry> entrys = new List<Entry>();

        public void CreateJournalEntry()
        {
            string[] prompts = {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
            };

            Random random = new Random();
            int selectedPrompt = random.Next(prompts.Length);

            Console.Write(prompts[selectedPrompt]);
            string entryText = Console.ReadLine();

            DateTime currentDate = DateTime.Today;
            Entry entery = new Entry();

            entery.date = currentDate.ToString("MM/dd/yyyy");
            entery.prompt = prompts[selectedPrompt];
            entery.response = entryText;

            entrys.Add(entery);
        }

        public void DisplayJournalEntrys()
        {
            foreach (Entry entry in entrys)
            {
                Console.WriteLine($"{entry.date} {entry.prompt} {entry.response}\n");
            }
        }

        public void SaveJournalEntrys(string saveLocation)
        {
            Console.Write("Where would you like to save to(file name): ");
            string writeFileName = Console.ReadLine();

            try
            {
                string writeFileLocation = saveLocation + "/" + writeFileName;
                StreamWriter streamWriter = new StreamWriter(writeFileLocation);
                foreach (Entry entry in entrys)
                {
                    streamWriter.WriteLine($"{entry.date}; {entry.prompt}; {entry.response};");
                }
                streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void LoadJournalEntrys(string saveLocation)
        {
            Console.Write("What file would you like to load: ");
            string readFileName = Console.ReadLine();

            try
            {
                string readFileLocation = saveLocation + "/" + readFileName;
                StreamReader streamReader = new StreamReader(readFileLocation);

                string line = streamReader.ReadLine();
                while (line != null)
                {
                    string[] lineContents = line.Split(";");

                    Entry entryCopy = new Entry();
                    entryCopy.date = lineContents[0];
                    entryCopy.prompt = lineContents[1];
                    entryCopy.response = lineContents[2];
                    entrys.Add(entryCopy);

                    line = streamReader.ReadLine();
                }

                streamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
