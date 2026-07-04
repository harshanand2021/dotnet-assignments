using System;
namespace Assignment7_1
{
    public class StudentEmail : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            return s1.Email.CompareTo(s2.Email);
        }
    }
}

