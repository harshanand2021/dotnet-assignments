using System;
namespace Assignment7_1
{
	public class StudentName : IComparer<Student>
	{
		public StudentName() { }

		public int Compare(Student stu1, Student stu2)
		{
			return stu1.Name.CompareTo(stu2.Name);
		}
    }
}

