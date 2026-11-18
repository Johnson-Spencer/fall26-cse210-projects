using System.ComponentModel.DataAnnotations.Schema;

abstract class BaseGoal
{
    
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    private string _goalType;

    public BaseGoal(string name, string description, int points, bool complete, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }


    public BaseGoal(string goalType)
    {
        SetGoalName();
        SetGoalDescription();
        SetGoalPoints();
        _complete = false;
        _goalType = goalType;
    }

    private void SetGoalName()
    {
        Console.Write("Please enter the name of your goal: ");
        _name = Console.ReadLine();
    }

    private void SetGoalDescription()
    {
        Console.Write("Please enter the description of your goal: ");
        _description = Console.ReadLine();
    }

    private void SetGoalPoints()
    {
        Console.Write("Please enter the Points of your goal: ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual string GetConsoleString()
    {
        string completeString = " ";
        if(_complete)
            completeString = "X";
        return $"[{completeString} ] Goal name: {_name}, Description: {_description}, Points: {_points}";
    }

    public int MarkComplete()
    {
        _complete = true;
        return _points;
    }

    public abstract int RecordEvent();
}