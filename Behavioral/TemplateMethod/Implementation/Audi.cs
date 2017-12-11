using System;
using TemplateMethod.Abstract;

namespace TemplateMethod.Implementation
{
	class Audi : Car
	{
		protected override void SetConsumption() => TankCapacity = 100;
		
		protected override void SetGear() => Console.WriteLine("Set a gear");
		
		protected override void Moving(int distance)
		{
			while (distance > 0 && TankCapacity > 0)
			{
				Console.WriteLine($"Distance to finish: {distance} km. | Tank remains: {TankCapacity} ltr.");

				distance -= 100;
				TankCapacity -= 10;
			}
		}
	}
}
