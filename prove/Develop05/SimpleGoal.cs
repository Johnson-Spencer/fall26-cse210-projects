class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool status, string goalType)
    : base(name, description, points, status, goalType)
    {
        
    }
    public SimpleGoal() : base("Simple Goal")
    {
    }

    public override int RecordEvent()
    {
        
        return MarkComplete();
    }




}