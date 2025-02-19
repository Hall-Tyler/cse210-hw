using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class MathAssignment : Assignment
    {
        private string _textBookSection;
        private string _problems;

        public MathAssignment(string studentName, string topic, string textBookSection, string problems) 
            : base(studentName, topic)
        {
            
            _textBookSection = textBookSection;
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return "Section " + _textBookSection + " Problems " + _problems;
        }
    }
}
