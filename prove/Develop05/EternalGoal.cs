class EternalGoal : BaseGoal
{
    public EternalGoal() : base("Eternal")
    {
    }

    public EternalGoal(string name, string description, int points)
        : base(name, description, points, false, "Eternal")
    {
    }

    public override int RecordEvent()
    {
        return EarnPoints();
    }

    public override string GetConsoleString()
    {
        return $"[ ] {Name} ({Description})";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal|{Name}|{Description}|{Points}|false";
    }
}