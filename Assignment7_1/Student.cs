using System;
using System.Collections.Generic;

namespace Assignment7_1
{
	public class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public int Marks { get; set; }
		public int Id { get; set; }

		public Student(int id, string name, string email, int age, int marks)
		{
			Id = id;
			Name = name;
			Email = email;
			Age = age;
			Marks = marks;
		}

		public void DisplayStudent()
		{
            Console.WriteLine($"{Id,-5} {Name,-15} {Email,-25} {Age,-5} {Marks}");
        }

    }
}

