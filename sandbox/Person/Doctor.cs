using System.Reflection.Metadata.Ecma335;

class Doctor : Person
{
    private string _tools;

    public Doctor (string firstName, string lastName, int age, double weight, string tools)
    : base (firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    public override string GetPersonInformation()
    {
        return $"{GetPersonInformation()} Doctor Tools: {_tools}";
    }

    public override double GetSalary()
    {
        return 98000.00;
    }
}
