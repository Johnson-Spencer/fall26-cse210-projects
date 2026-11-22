class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base("Simple")
    {
    }

    public SimpleGoal(string name, string description, int points, bool complete)
        : base(name, description, points, complete, "Simple")
    {
    }

    public override int RecordEvent()
    {
        return CompleteGoal();
    }

    public override string GetStringRepresentation()
    {
        return $"Simple|{Name}|{Description}|{Points}|{IsComplete}";
    }
}