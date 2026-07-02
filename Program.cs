namespace Assignment3_1;

class Program
{
    static void DisplayDetails(Person p)
    {
        Console.WriteLine("First Name = " + p.FirstName);
        Console.WriteLine("Last Name = " + p.LastName);
        Console.WriteLine("Age = " + p.Age);
    }

    static void Main(string[] args)
    {
        Person person;

        Console.Write("Enter first name: ");
        string FirstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string LastName = Console.ReadLine();

        Console.Write("Enter age: ");
        int Age = Console.Read();

        person = new Person(FirstName, LastName, Age);

        string FullName = person.GetFullName(person);
        Console.WriteLine("Full Name = " + FullName);

        Console.WriteLine("Details of person - ");

        DisplayDetails(person);

    }
}

