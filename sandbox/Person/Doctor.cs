using System.Reflection.Metadata.Ecma335;

class Doctor : Person
{
    private string _tools;

    public Doctor (string firstName, string lastName, int age, double weight, string tools)
    : base (firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    public string GetDoctorInformation()
    {
        return $"{GetPersonInformation()} Doctor Tools: {_tools}";
    }
}