using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("Please select an Activity that you would like to try!");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity(
                        "Breathing",
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                    );

                    breathing.RunActivity();
                    PauseBeforeMenu();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity(
                        "Reflection",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience."
                    );

                    reflection.RunActivity();
                    PauseBeforeMenu();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity(
                        "Listing",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can."
                    );

                    listing.RunActivity();
                    PauseBeforeMenu();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Thank you for using the Mindfulness Program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }

    static void PauseBeforeMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }
}