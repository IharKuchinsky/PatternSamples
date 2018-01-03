using System;
using Visitor.Abstract;
using Visitor.Entities;

namespace Visitor.Implementation
{
	class FuelFillerVisitor: IVisitor
	{
		public void Visit(Car car)
		{
			if ( (!(car is CombustionEngineCar combustionEngineCar)) || (combustionEngineCar.TankCapacity == combustionEngineCar.MaxTankCapacity) ) return;

			PrintBatteryInfo(combustionEngineCar);

			Console.WriteLine("Charge the electric car...");
			combustionEngineCar.TankCapacity = combustionEngineCar.MaxTankCapacity;

			PrintBatteryInfo(combustionEngineCar);
		}

		private static void PrintBatteryInfo(CombustionEngineCar car)
		{
			Console.WriteLine($"{car.Make} {car.Model} Battry capacity {car.TankCapacity} ltr.");
		}
	}
}
