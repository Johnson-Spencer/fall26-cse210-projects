class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _prompts = new List<FlaggedString>
    {
        new FlaggedString("Think of a time when you stood up for someone else."),
        new FlaggedString("Think of a time when you did something really difficult."),
        new FlaggedString("Think of a time when you helped someone in need."),
        new FlaggedString("Think of a time when you did something truly selfless.")
    };

    private List<FlaggedString> _questions = new List<FlaggedString>
    {
        new FlaggedString("Why was this experience meaningful to you?"),
        new FlaggedString("Have you ever done anything like this before?"),
        new FlaggedString("How did you get started?"),
        new FlaggedString("How did you feel when it was complete?"),
        new FlaggedString("What made this time different than other times when you were not as successful?"),
        new FlaggedString("What is your favorite thing about this experience?"),
        new FlaggedString("What could you learn from this experience that applies to other situations?"),
        new FlaggedString("What did you learn about yourself through this experience?"),
        new FlaggedString("How can you keep this experience in mind in the future?")
    };

    public ReflectionActivity(string name, string description)
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

        StartTime();

        while (!HasTimerExpired())
        {
            Console.WriteLine();
            Console.WriteLine(GetPromptString(_questions));

            DisplaySpinnerMessage("", 5);
        }

        DisplayEnding();
    }
}