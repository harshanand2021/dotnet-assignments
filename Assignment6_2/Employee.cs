using System;
namespace Assignment6_2
{
	public class Employee
	{
		public string EmpName { get; set; }
		public int EmpAge { get; set; }

		public Employee(string name, int age)
		{

            if (age < 18 || age > 60)
			{
                throw new InvalidAgeException("Employee age must be between 18 and 60");
            }

            EmpAge = age;
            EmpName = name;
        }

		public void Display()
		{
			Console.WriteLine($"Employee Name = {EmpName}");
			Console.WriteLine($"Employee Age = {EmpAge}");
		}

	}
}

