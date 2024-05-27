using System;
namespace ClassesAndObjectss
{
	public class Features
	{
		public int maxSpeed;
		public string model;
        public int price;
        public string groundClearance;
		public void torque()
		{
			Console.WriteLine("Enter the Torque: ");
			int torque = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The model: " + model + " has the torque of: " + torque);

		}
	}
}

