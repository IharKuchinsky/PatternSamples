using System;
using FactoryMethod.Implementation;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			CarCreator electricEngineCarCreator = new ElectricEngineCarCreator();
			var electricEngineCar = electricEngineCarCreator.Create("Tesla", "P90");

			CarCreator combustionEngineCarCreator = new ElectricEngineCarCreator();
			var combustionEngineCar = combustionEngineCarCreator.Create("Audi", "RS7");

			electricEngineCar.PrintInfo();
			combustionEngineCar.PrintInfo();
			
			Console.Read();
		}
	}
}
