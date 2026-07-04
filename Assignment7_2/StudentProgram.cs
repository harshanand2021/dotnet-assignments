namespace Assignment7_2;

class Program
{
    static void Main(string[] args)
    {
        List<Student> g = new List<Student>()
        {
            new Student{ no = 123, name = "Arun", language = "C#", age = 23, city = "Pune" },
            new Student{ no = 124, name = "Akshay", language = "C#", age = 20, city = "Pune" },
            new Student{ no = 125, name = "Rama", language = "C#", age = 22, city = "Nashik" },
            new Student{ no = 126, name = "Riya", language = "C#", age = 25, city = "Nagar" },
            new Student{ no = 127, name = "Amar", language = "Java", age = 20, city = "Pune" },
            new Student{ no = 128, name = "Vidya", language = "VB", age = 22, city = "Nashik" },
            new Student{ no = 129, name = "Prajakta", language = "Java", age = 25, city = "Nagar" }
        };

        var result = from s in g
                     where s.city == "Pune"
                     select s;

        Console.WriteLine();

        var result1 = g.Where(s => s.city == "Pune");

        Display(result1);

        Console.WriteLine("\n-------------------------\n");

        var avgAge = (from s in g
                      select s.age).Average();
        Console.WriteLine(avgAge);

        var avgAge1 = g.Average(s => s.age);
        Console.WriteLine(avgAge1);

        Console.WriteLine("\n-------------------------\n");

        var result2 = from s in g
                     where s.name.Contains("y")
                     select s;

        Display(result2);

        Console.WriteLine("\n-------------------------\n");

        var first = (from s in g
                     select s).First();

        Console.WriteLine($"{first.no} {first.name} {first.language} {first.age} {first.city}");



        var first1 = g.First();

        Console.WriteLine($"{first.no} ,{first1.name}, {first.language} ,{first1.age}, {first1.city}");

        var groups = g.GroupBy(s => s.city);

        foreach(var group in groups)
        {
            Console.Write($"Key: {group.Key}");

            foreach(Student s in group)
            {
                Console.WriteLine($"{s.no}, {s.name}");
            }
        }

    }

    static void Display(IEnumerable<Student> students)
    {
        foreach (var s in students)
        {
            Console.WriteLine($"{s.no}  {s.name}  {s.language}  {s.age}  {s.city}");
        }
    }
}

