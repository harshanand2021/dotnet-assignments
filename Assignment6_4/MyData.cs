using System;
namespace Assignment6_4
{
	public class MyData<T>
	{
        public T Data { get; set; }

		public MyData(T data)
		{
			Data = data;
		}

		public void DisplayData()
		{
			Console.WriteLine("Data: " + Data);
		}
	}
}

