class ReflectionActivity : BaseActivity
{

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();
    public ReflectionActivity(String name, string description) : base(name, description)
    {

    }

    public void RunActivity()
    {
StartActivity();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomItem(_prompts)} ---");
        Console.WriteLine();

        DisplaySpinnerMessage("Think about it ", 5);

        StartTime();

        while (!HasTimerExpired())
        {
            Console.WriteLine();
            Console.WriteLine(GetRandomItem(_questions));

            DisplaySpinnerMessage("", 5);
        }

        DisplayEnding();
    }

    private string GetRandomItem(List<string> items)
{
    int index = _random.Next(items.Count);
    return items[index];
}

    private void SetPromptsAndQuestions()
    {

    }

    private void ResetPromptsUsage()
    {

    }


}