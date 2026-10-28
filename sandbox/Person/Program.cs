class Program
{
    static void Main()
    {
        Person myPerson = new Person("Bob", "Floyd", 56, 238);

        myPerson.DisplayPersonInformation();

        Police myPloice = new Police("Lance", "Bob", 34, 186, "Taser");

        myPloice.DisplayPersonInformation();
    }
}