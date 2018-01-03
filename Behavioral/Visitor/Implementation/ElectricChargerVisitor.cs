using System;
using Visitor.Abstract;
using Visitor.Entities;

namespace Visitor.Implementation
{
	class ElectricChargerVisitor: IVisitor
	{
		public void Visit(Car car)
		{
			if ( (!(car is ElectricEngineCar electricEngineCar)) || (electricEngineCar.BatteryCapacity == electricEngineCar.MaxBatteryCapacity) ) return;

			PrintBatteryInfo(electricEngineCar);

			Console.WriteLine("Charge the electric car...");
			electricEngineCar.BatteryCapacity = electricEngineCar.MaxBatteryCapacity;

			PrintBatteryInfo(electricEngineCar);
		}

		private static void PrintBatteryInfo(ElectricEngineCar car)
		{
			Console.WriteLine($"{car.Make} {car.Model} Battry capacity {car.BatteryCapacity} Kw/h");
		}
	}
}
