using System;

class Program
{
    static void Main(string[] args)
    {
        Word myword = new Word("Bubba");
        myword.Display();
        myword.Hide();
        Console.WriteLine();
        myword.Display();
    }
}