using System;
using Strategy.Entities;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			Car audi = new Car("Audi", "A7", EngineType.Diesel);
			Car bmw = new Car("BMW", "X6", EngineType.Gasoline);
			Car tesla = new Car("Tesla", "P90", EngineType.Electric);

			audi.PrintInfo();
			bmw.PrintInfo();
			tesla.PrintInfo();

			Console.Read();
		}
	}
}
