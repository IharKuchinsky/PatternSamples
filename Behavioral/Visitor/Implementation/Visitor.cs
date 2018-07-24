using System;
using Visitor.Abstract;
using Visitor.Entities;

namespace Visitor.Implementation
{
	class Visitor: IVisitor
	{
		public void Visit(ElectricEngineCar car)
		{
			if (car.BatteryCapacity == car.MaxBatteryCapacity) return;

			PrintBatteryInfo(car);

			Console.WriteLine("Charge the electric car...");
			car.BatteryCapacity = car.MaxBatteryCapacity;

			PrintBatteryInfo(car);
		}

		public void Visit(CombustionEngineCar car)
		{
			if (car.TankCapacity == car.MaxTankCapacity) return;

			PrintTankInfo(car);

			Console.WriteLine("Fill the combustion engine car tank...");
			car.TankCapacity = car.MaxTankCapacity;

			PrintTankInfo(car);
		}

		private static void PrintBatteryInfo(ElectricEngineCar car)
		{
			Console.WriteLine($"{car.Make} {car.Model} Battry capacity {car.BatteryCapacity} Kw/h");
		}

		private static void PrintTankInfo(CombustionEngineCar car)
		{
			Console.WriteLine($"{car.Make} {car.Model} Tank capacity {car.TankCapacity} ltr.");
		}
	}
}
