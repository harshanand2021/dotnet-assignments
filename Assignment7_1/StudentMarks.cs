using System;
namespace Assignment7_1
{
    public class StudentMarks : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            return s1.Marks.CompareTo(s2.Marks);
        }
    }
}

