using System;
using FactoryMethod.Entities;

namespace FactoryMethod.Implementation
{
	class ElectricEngineCarCreator: CarCreator
	{
		public override Car Create(string make, string model)
		{
			return new ElectricEngineCar(make, model);
		}
	}
}
