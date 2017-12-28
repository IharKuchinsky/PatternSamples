using System;
using Builder.Entities;
using Builder.Implementation;

namespace Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			CarBuilder carBuilder = new CarBuilder();

			var car = carBuilder
				.Make("Audi")
				.Model("RS7")
				.EnginePower(640)
				.GearBox(GearBoxType.Automatic)
				.DriveType(DriveType.AllWheelDrive).Build();

			Console.WriteLine(car);

			Console.Read();
		}
	}
}
