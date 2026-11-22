using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity and exceeding requirements:
        // This program includes a level system based on the user's score.
        // The user gains one level for every 1,000 points earned.
        // It also includes a return-to-main-menu option and pauses after actions.

        Goals goals = new Goals();
        Menu menu = new Menu();

        int choice = 0;

        while (choice != 6)
        {
            choice = menu.DisplayMenu();

            if (choice == 1)
            {
                int goalType = menu.DisplayCreateGoalMenu();

                if (goalType == 1)
                {
                    goals.AddGoal(new SimpleGoal());
                    Console.WriteLine("\nSimple goal created.");
                    Pause();
                }
                else if (goalType == 2)
                {
                    goals.AddGoal(new EternalGoal());
                    Console.WriteLine("\nEternal goal created.");
                    Pause();
                }
                else if (goalType == 3)
                {
                    goals.AddGoal(new ChecklistGoal());
                    Console.WriteLine("\nChecklist goal created.");
                    Pause();
                }
                else if (goalType == 4)
                {
                    Console.WriteLine("\nReturning to the main menu...");
                }
            }
            else if (choice == 2)
            {
                goals.DisplayGoals();
                Pause();
            }
            else if (choice == 3)
            {
                goals.SaveGoals();
                Pause();
            }
            else if (choice == 4)
            {
                goals.LoadGoals();
                Pause();
            }
            else if (choice == 5)
            {
                goals.RecordEvent();
                Pause();
            }
            else if (choice == 6)
            {
                Console.WriteLine("\nThank you for using Eternal Quest!");
            }
        }
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to return to the main menu.");
        Console.ReadLine();
    }
}