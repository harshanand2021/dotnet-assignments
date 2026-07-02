namespace Assignment4_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating first Employee instance");

        Employee emp1 = new Employee();

        Console.WriteLine("\n---------------------------------------\n");

        Console.WriteLine("Creating second Employee instance");

        Employee emp2 = new Employee();

        //Nullable Integer
        int? age = null;

        if (age.HasValue)
            Console.WriteLine($"Age = {age}");

        else
            Console.WriteLine("Age is NULL");

        age = 33;
        Console.WriteLine($"Age = {age}");

        //Nullable Double
        double? salary = null;
        Console.WriteLine($"Salary = {salary}");

        salary = 55000.00;
        Console.WriteLine($"Salary = {salary}");

        //Nullable Boolean
        bool? isEmployee = null;
        Console.WriteLine($"Employee : {isEmployee ?? false}");

    }
}

