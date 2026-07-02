using System;
namespace Assignment3_1
{
	public class Person
	{
		public string FirstName { get; set;  }
		public string LastName { get; set; }
		public int Age { get; set; }

		//Default Constructor with default values
		public Person(){
			FirstName = "\0";
			LastName = "\0";
			Age = 0;
		}


		//Initialized Constructor with passed values
		public Person(string first_name, string last_name, int age)
		{
			FirstName = first_name;
			LastName = last_name;
			Age = age;
		}

		public string GetFullName(Person p)
		{
			return p.FirstName + " " + p.LastName;
		}

		public bool IsAdult(Person p)
		{
			if (p.Age >= 18)
				return true;
			else
				return false;
		}
	}
}

