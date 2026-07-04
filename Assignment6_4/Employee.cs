using System;
namespace Assignment6_4
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Employee(int id, string name)
		{
			Name = name;
			Id = id;
		}

        public override string ToString()
        {
            return $"Employee Details = [ID = {Id}, Name = {Name}]";
        }
    }
}

