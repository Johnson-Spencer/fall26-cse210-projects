class BaseActivity
{

    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;
    public BaseActivity(string name, string description) //: base (name, description)
    {
        _name = name;
        _description = description;
    }


    public void StartActivity()
{
    Console.WriteLine(_name);
    Console.WriteLine(_description);
    Console.Write("How many seconds would you like the activity to last? ");
    string input = Console.ReadLine();
    int.TryParse(input, out _duration);

     Console.WriteLine();
        Console.WriteLine("Get ready...");
        DisplaySpinnerMessage("", 3);
}

    public void DisplayEnding()
    {
         Console.WriteLine();
        Console.WriteLine("Good job!");
        DisplaySpinnerMessage("", 2);

        Console.WriteLine(
            $"You have completed the {_name} Activity for {_duration} seconds.");

        DisplaySpinnerMessage("", 3);
        Console.WriteLine();
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{message} {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.CursorVisible = true;
    }

    public void DisplaySpinnerMessage(string message, int seconds)
    {
          Console.CursorVisible = false;
        Console.Write(message);

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b");
            index = (index + 1) % spinner.Length;
        }

        Console.WriteLine();
        Console.CursorVisible = true;
    }

    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
         return DateTime.Now >= _endTime;
    }

    public void ObtainDuration()
    {
       while (true)
    {
        Console.Write("How many seconds would you like the activity to last? ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out _duration) && _duration > 0)
        {
            break;
        }

        Console.WriteLine("Please enter a positive whole number.");
    } 
    }

//   public string GetPromptString(List<FlaggedString> prompts)
// {
//     Random random = new Random();
//     int index = random.Next(prompts.Count);

//     return prompts[index].GetPrompt();
// }

}