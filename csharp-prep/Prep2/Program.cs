using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        if (percentage >= 90)
        {
            Console.WriteLine("Congrats you have an A");
        }

        else if (percentage >= 80)
        {
            Console.WriteLine("Great work you have a B");
        }

        


    
    }
}