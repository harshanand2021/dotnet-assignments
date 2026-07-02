using System;
namespace Assignment4_1
{
	public class Citizen
	{
		public int CitizenId;
		public string CitizenName;

		public AadharCard Aadhar { get; set; }

		public Citizen(int id, string name, AadharCard aadharCard = null)
		{
			CitizenId = id;
			CitizenName = name;
			Aadhar = aadharCard;
		}

		public void DisplayCitizen()
		{
			Console.WriteLine($"Citizen ID = {CitizenId}");
			Console.WriteLine($"Citizen Name = {CitizenName}");

			if (Aadhar != null)
				Aadhar.DisplayAadhar();
			else
			{
				Console.WriteLine("Aadhar info not available");
			}
		}

	}
}

