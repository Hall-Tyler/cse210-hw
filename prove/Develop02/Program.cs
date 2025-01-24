using Develop02;
using System;
using System.IO;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        JournalInterface journalInterface = new JournalInterface();
        journalInterface.RunJournalApp();
    }
}