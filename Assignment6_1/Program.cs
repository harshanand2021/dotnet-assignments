namespace Assignment6_1;

class Program
{
    static void Main(string[] args)
    {
        //Circle
        Circle circle = new Circle(5);
        circle.DrawShape();
        Console.WriteLine("Area of circle = " + circle.CalculateArea());
        Console.WriteLine("Perimeter of circle = " + circle.CalculatePerimeter());

        Console.ReadLine();
    }
}

