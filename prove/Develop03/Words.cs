using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop03
{
    internal class Words
    {
        private bool isHidden = false;
        private string wordText;

        public Words(string wordText)
        {
            this.wordText = wordText;
        }

        public string GetWord()
        {
            if (isHidden)
            {
                string hiddenString = "";

                foreach (var c in wordText)
                {
                    hiddenString += "_";
                }
                
                return hiddenString;
            } else
            {
                return wordText;
            }
        }

        public void Hide()
        {
            isHidden = true;
        }

        public bool IsHidden()
        {
            return isHidden;
        }
    }
}
