using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Abstract;

namespace TemplateMethod.Implementation
{
	class Tesla : Car
	{
		protected override void SetConsumption()
		{
			TankCapacity = 500;
		}

		protected override void SetGear()
		{
			Console.WriteLine("Push the button");
		}

		protected override void Moving(int distance)
		{
			while (distance > 0 || TankCapacity < 0)
			{
				Console.WriteLine($"Distance to finish: {distance} km. | Battery remains: {TankCapacity} wt.");

				distance -= 100;
				TankCapacity -= 100;
			}
		}
	}
}
