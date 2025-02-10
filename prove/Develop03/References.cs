using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop03
{
    internal class References
    {
        private List<Scripture> scriptures = new List<Scripture>();
        public void SetReference(string book, string chapter, string verse)
        {
            Scripture scripture = new Scripture(book, chapter, verse);
            scriptures.Add(scripture);
        }

        public int GetRandomScripture()
        {
            Random random = new Random();
            int scriptureIndex = random.Next(0, scriptures.Count);
            return scriptureIndex;
        }
        public void DisplayScripture(int scriptureIndex, bool hide)
        {
            Scripture scripture = scriptures[scriptureIndex];
            string scriptureText = scriptures[scriptureIndex].GetScripture(hide);
            if (scriptureText == "")
            {
                System.Environment.Exit(1);
            }

            Console.WriteLine(scriptureText);
        }
    }
}
