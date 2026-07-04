using System;
namespace Assignment6_1
{
	public class Circle:Drawable
	{
		public float Radius { get; set; }
		public Circle(float radius)
		{
			Radius = radius;
		}

		public void DrawShape()
		{
			Console.WriteLine("Darwing Circle");
		}

		public double CalculateArea()
		{
			double area = Drawable.PI * Radius * Radius;
			return area;
		}

		public double CalculatePerimeter()
		{
			double perimeter = 2 * Drawable.PI * Radius;
			return perimeter;
		}
	}
}

