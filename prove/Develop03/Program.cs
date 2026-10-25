
using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Random random = new Random();

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Scripture Memorizer ===");
            Console.WriteLine("1. Moses 1:39");
            Console.WriteLine("2. Ether 12:27");
            Console.WriteLine("3. Proverbs 3:5-6");
            Console.WriteLine("4. Choose a random scripture");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";

            if (choice.ToLower() == "quit" || choice == "5")
            {
                running = false;
            }
            else
            {
                
                int selection;

                if (choice == "4")
                {
                    selection = random.Next(1, 4);
                }
                else if (int.TryParse(choice, out selection)
                         && selection >= 1 && selection <= 3)
                {
                    
                }
                else
                {
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    continue;
                }

                Scripture scripture = CreateScripture(selection);

                bool returnToMenu = false;

                while (!scripture.AllWordsHidden() && !returnToMenu)
                {
                    Console.Clear();
                    scripture.ShowScripture();

                    Console.WriteLine();
                    Console.WriteLine("Press Enter to hide a word.");
                    Console.WriteLine("Type 'menu' to return to the menu.");
                    Console.WriteLine("Type 'quit' to exit the program.");
                    Console.Write("Your choice: ");

                    string input = Console.ReadLine() ?? "";

                    if (input.ToLower() == "quit")
                    {
                        running = false;
                        returnToMenu = true;
                    }
                    else if (input.ToLower() == "menu")
                    {
                        returnToMenu = true;
                    }
                    else
                    {
                        scripture.HideSomeWords();
                    }
                }

                if (scripture.AllWordsHidden())
                {
                    Console.Clear();
                    scripture.ShowScripture();
                    Console.WriteLine();
                    Console.WriteLine("You hid every word! Great job memorizing.");
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                }
            }
        }

        Console.WriteLine("Thanks for practicing!");
    }

    
    static Scripture CreateScripture(int selection)
    {
        switch (selection)
        {
            case 1:
                return new Scripture(
                    "Moses", 1, 39,
                    "For behold this is my work and my glory to bring to pass the immortality and eternal life of man"
                );

            case 2:
                return new Scripture(
                    "Ether", 12, 27,
                    "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."
                );

            case 3:
                return new Scripture(
                    "Proverbs", 3, 5, 6,
                    "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths"
                );

            default:
                return new Scripture(
                    "Moses", 1, 39,
                    "For behold this is my work and my glory to bring to pass the immortality and eternal life of man"
                );
        }
    }
}
