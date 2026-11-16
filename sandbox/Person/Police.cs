using System.Reflection.Metadata.Ecma335;

class Police : Person
{
    private string _weapons;

    public Police (string firstName, string lastName, int age, double weight, string weapons)
    : base (firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public override string GetPersonInformation()
    {
        return $"Weapons: {_weapons} {GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        return 60000.00;
    }
}