using System;
namespace Assignment4_2
{
	public class Person
	{
		static Person()
		{
			Console.WriteLine("Static Constructor of Person class");
		}

		public Person()
		{
			Console.WriteLine("Instance Constructor of Person class");
		}
	}
}

