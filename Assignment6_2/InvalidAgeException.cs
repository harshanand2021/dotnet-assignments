using System;
namespace Assignment6_2
{
	public class InvalidAgeException : Exception
	{
		public InvalidAgeException(string message) : base(message)
		{
		}
	}
}

