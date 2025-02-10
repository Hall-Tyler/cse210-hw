using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Develop03
{
    internal class Scripture
    {
        private string book;
        private string chapter;
        private List<Words> verseWords = new List<Words>();

        public Scripture(string book, string chapter, string verse)
        {
            this.book = book;
            this.chapter = chapter;

            foreach (var word in verse.Split())
            {
                Words wordObj = new Words(word);
                verseWords.Add(wordObj);
            }
        }

        public string GetScripture(bool hide)
        {
            if (IsVerseHidden())
            {
                return "";
            }

            string scripture = book + " " + chapter + " ";

            foreach (var word in verseWords)
            {
                if (hide)
                {
                    Random random = new Random();
                    if (random.Next(0, 5) == 0)
                    {
                        word.Hide();
                    }
                }

                scripture += word.GetWord() + " ";
            }
            return scripture;
        }

        private bool IsVerseHidden()
        {
            foreach (var word in verseWords)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
