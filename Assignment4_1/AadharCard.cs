using System;
namespace Assignment4_1
{
	public class AadharCard
	{
		public string AadharId { get; set; }
		public string Address { get; set; }

		public AadharCard(string id, string address)
		{
			AadharId = id;
			Address = address;
		}

		public void DisplayAadhar()
		{
			Console.WriteLine($"Aadhar Number : {AadharId}");
			Console.WriteLine($"Address : {Address}");
		}
	}
}

