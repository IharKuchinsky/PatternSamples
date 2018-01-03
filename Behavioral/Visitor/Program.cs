using System;
using Visitor.Entities;
using Visitor.Implementation;

namespace Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			var tesla = new ElectricEngineCar("Tesla", "Model X", 20);
			var audi = new CombustionEngineCar("Audi", "Q 7", 50);

			ElectricChargerVisitor electricCharger = new ElectricChargerVisitor();
			FuelFillerVisitor fuelFiller = new FuelFillerVisitor();

			var showRoom = new CarShowroom();
			showRoom.Add(audi);
			showRoom.Add(tesla);
			
			showRoom.Accept(electricCharger);
			Console.WriteLine();
			showRoom.Accept(fuelFiller);

			Console.Read();
		}
	}
}
