class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _timestamp;

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        string[] prompts =
        {
            "How was your day?",
            "What was the best part of your day?",
            "What did you learn today?",
            "Who did you talk to today?",
            "What are you grateful for?"
        };

        int index = _random.Next(prompts.Length);

        return prompts[index];
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Entry time: {_timestamp}");
        Console.WriteLine($"{_prompt}, ");
        Console.WriteLine($"{_response}, ");
    }

    public void CreateJournalEntry()
    {
        _prompt = GetRandomPrompt();

        Console.WriteLine($"{_prompt}");
        _response = Console.ReadLine();

        _timestamp = DateTime.Now.ToString("MMMM d, yyyy h:mm tt");
    }

public string ToFileString()
    {
        return $"{_timestamp}|{_prompt}|{_response}";
    }

    public void LoadFromString(string line)
    {
        string[] parts = line.Split('|', 3);

        _timestamp = parts[0];
        _prompt = parts[1];
        _response = parts[2];
    }

}