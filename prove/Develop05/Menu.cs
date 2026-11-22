using System;

class Menu
{
    public int DisplayMenu()
    {
        int response = 0;

        while (response < 1 || response > 6)
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");

            response = int.Parse(Console.ReadLine());

            if (response < 1 || response > 6)
            {
                Console.WriteLine("Please enter a number from 1 to 6.");
            }
        }

        return response;
    }

    public int DisplayCreateGoalMenu()
    {
        int response = 0;

        while (response < 1 || response > 4)
        {
            Console.WriteLine("\nCreate Goal Menu");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Return to Main Menu");
            Console.Write("Select a choice: ");

            response = int.Parse(Console.ReadLine());

            if (response < 1 || response > 4)
            {
                Console.WriteLine("Please enter a number from 1 to 4.");
            }
        }

        return response;
    }
}