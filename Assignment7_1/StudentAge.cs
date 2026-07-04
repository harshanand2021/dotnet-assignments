using System;
namespace Assignment7_1
{
	public class StudentAge : IComparer<Student>
	{
		public int Compare(Student stu1, Student stu2)
		{
			return stu1.Age.CompareTo(stu2.Age);
		}
	}
}

