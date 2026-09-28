using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Program
{
    static double AddNumbers(double x, int y)
    {
        return x + y;
    }
    static void Main(string[] args)
    {
    //    int x = 10;
    //    int y = 20;
    //    int z = 30;

    //    if (x == 10 || y == 20 && z == 30)
    //    {
    //     Console.WriteLine("X is 10");
    //     Console.WriteLine("Y is fun");
    //    }
    //     else if  (x == 20)
    //     {
    //         Console.WriteLine("Were are in the else if.");
    //     }
    //    else
    //     {
    //         Console.WriteLine("Z is not mch fun!");
    //     }
    

    // bool done = false;

    // while (! done)
    //     {
    //         Console.Write("Are we done (y/n): ");
    //         done = Console.ReadLine().ToLower() == "y";
    //     }

    // bool done;

    // do
    //     {
    //         Console.Write("Are we done (y/n): ");
    //         done = Console.ReadLine().ToLower() == "y";
    //     } while(!done);

    // for(int i = 100; i > -1; i-=25)
    //     {
    //         Console.WriteLine(i);
    //     }

    List<string> myFriends = ["bob", "betty", "Bubba"];

    foreach(string name in myFriends)
        {
            Console.WriteLine(name);
        }

    }
}