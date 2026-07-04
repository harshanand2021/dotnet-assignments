using System;
namespace Assignment6_4
{
	public class Student
	{
		public int RollNo { get; set; }
		public string Name { get; set; }

		public Student(int roll, string name)
		{
			RollNo = roll;
			Name = name;
		}

        public override string ToString()
        {
            return  $"Student Details => [Name = {Name}, RollNo = {RollNo}]";
        }
    }
}

