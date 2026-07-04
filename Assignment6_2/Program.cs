namespace Assignment6_2;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee Age: ");
            int empAge = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee(empName, empAge);

            Console.WriteLine("\nEmployee saved sucessfully\n");

            employee.Display();

        }
        catch(InvalidAgeException invalidAge)
        {
            Console.WriteLine("Enter a valid age - " + invalidAge.Message);
        }
        catch(FormatException formatEx)
        {
            Console.WriteLine("Enter in right format - " + formatEx.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error - " + ex.Message);
        }

        finally
        {
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

