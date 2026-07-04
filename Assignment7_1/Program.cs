namespace Assignment7_1;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student(101, "Arun", "arun_kumar@outlook.com", 25, 88),
            new Student(102, "Akbar", "akbar2003@outlook.com", 23, 67),
            new Student(103, "Aman", "aman1999@outlook.com", 27, 89),
            new Student(104, "Ghanshyam", "ghanshyam_singh@outlook.com", 27, 92),
            new Student(105, "Ramu", "ramu_kumar@outlook.com", 24, 90)
        };

        Console.WriteLine("Initial List");
        Display(students);

        // Sort by Name
        students.Sort(new StudentName());

        Console.WriteLine("\nSorted By Name");
        Display(students);

        // Sort by Age
        students.Sort(new StudentAge());

        Console.WriteLine("\nSorted By Age");
        Display(students);

        // Sort by Marks
        students.Sort(new StudentMarks());

        Console.WriteLine("\nSorted By Marks");
        Display(students);
    }

    static void Display(List<Student> student)
    {
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("Roll  Name            Email                     Age   Marks");
        Console.WriteLine("---------------------------------------------------------------");


        foreach (Student stu in student)
        {
            stu.DisplayStudent();
        }
    }
}

