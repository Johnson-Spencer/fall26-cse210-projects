using System;

abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    private string _goalType;

    protected string Name => _name;
    protected string Description => _description;
    protected int Points => _points;
    protected bool IsComplete => _complete;
    protected string GoalType => _goalType;

    public BaseGoal(string name, string description, int points,
        bool complete, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }

    public BaseGoal(string goalType)
    {
        _goalType = goalType;

        Console.Write("Enter the name of your goal: ");
        _name = Console.ReadLine();

        Console.Write("Enter the description: ");
        _description = Console.ReadLine();

        Console.Write("Enter the points: ");
        _points = int.Parse(Console.ReadLine());

        _complete = false;
    }

    protected int CompleteGoal()
    {
        if (_complete)
        {
            return 0;
        }

        _complete = true;
        return _points;
    }

    protected int EarnPoints()
    {
        return _points;
    }

    public virtual string GetConsoleString()
    {
        string status = _complete ? "X" : " ";
        return $"[{status}] {_name} ({_description})";
    }

    public abstract int RecordEvent();

    public abstract string GetStringRepresentation();
}