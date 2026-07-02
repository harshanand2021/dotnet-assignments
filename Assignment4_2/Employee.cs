using System;
namespace Assignment4_2
{
	public class Employee : Person
	{
		static Employee()
		{
			Console.WriteLine("Static Constructor of Employee class");
		}

		public Employee()
		{
			Console.WriteLine("Instance Constructor of Employee class");
		}
	}
}

