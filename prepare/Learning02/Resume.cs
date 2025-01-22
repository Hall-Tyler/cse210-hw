using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning02
{
    internal class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();
        
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }
}
