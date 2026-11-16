using System.Runtime.CompilerServices;

class Program
{
    static void DisplayPersonInfo(Person person)
    {
        Console.Write($"Salary: {person.GetSalary()} ");
        Console.WriteLine(person.GetPersonInformation());
    }
    static void Main()
    {
        //Person myPerson = new Person("Bob", "Floyd", 56, 238);

        //Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Lance", "Bob", 34, 186, "Taser");

        Console.WriteLine(myPolice.GetPersonInformation());

        Doctor myDoctor = new Doctor("Billy", "Payne", 20, 150, "Knife");
        Console.WriteLine(myDoctor.GetPersonInformation());

        List<Person> myPeople = new List<Person>();

       // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
            Console.WriteLine(person.GetPersonInformation());
        }
    }
}