using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();

        int response = 0;

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.WriteLine("Create");
                    JournalEntry newEntry = new JournalEntry();
                    newEntry.CreateJournalEntry();
                    myJournal.AddEntry(newEntry);
                    break;
                case 2:
                    Console.WriteLine("Display");
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("Save");
                    Console.Write("Enter filename: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;
                case 4:
                    Console.WriteLine("Write");
                    Console.Write("Enter filename: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;
            }
        }
    }
}