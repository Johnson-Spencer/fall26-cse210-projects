class Menu
{

    public int DisplayMenu()
    {
        int response = 0;

        while (response < 1 || response > 6)
        {
            Console.WriteLine("Welcome to the Goals Project Program.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a Choice from the menu: ");

            response = int.Parse(Console.ReadLine());
        }

        return response;
    }

    public int DisplayCreateGoalMenu()
    {
         int response = 0;

        while (response < 1 || response > 6)
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Return to Main Menu");

        response = int.Parse(Console.ReadLine());
        }

        return response;
    }


}