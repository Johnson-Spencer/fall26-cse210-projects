class ChecklistGoal : BaseGoal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal() : base("Checklist")
    {
        Console.Write("How many times must this goal be completed? ");
        _target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus? ");
        _bonus = int.Parse(Console.ReadLine());

        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points,
        int amountCompleted, int target, int bonus, bool complete)
        : base(name, description, points, complete, "Checklist")
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted >= _target)
        {
            return 0;
        }

        _amountCompleted++;
        int earned = EarnPoints();

        if (_amountCompleted == _target)
        {
            earned += _bonus;
        }

        return earned;
    }

    public override string GetConsoleString()
    {
        string status = IsComplete ? "X" : " ";
        return $"[{status}] {Name} ({Description}) " +
               $"Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist|{Name}|{Description}|{Points}|" +
               $"{_amountCompleted}|{_target}|{_bonus}|{IsComplete}";
    }
}