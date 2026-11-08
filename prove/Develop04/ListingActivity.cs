class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts = new List<FlaggedString>
    {
        new FlaggedString("Who are people that you appreciate?"),
        new FlaggedString("What are personal strengths of yours?"),
        new FlaggedString("Who are people that you have helped this week?"),
        new FlaggedString("When have you felt the Holy Ghost this month?"),
        new FlaggedString("Who are some of your personal heroes?")
    };

    public ListingActivity(string name, string description)
        : base(name, description)
    {
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetPromptString(_prompts)} ---");
        Console.WriteLine();

        DisplaySpinnerMessage("Think about it ", 5);

        Console.WriteLine();
        Console.WriteLine("Start listing items:");

        StartTime();

        int itemCount = 0;

        while (!HasTimerExpired())
        {
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items.");

        DisplayEnding();
    }
}