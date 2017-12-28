using System;
using FactoryMethod.Entities;

namespace FactoryMethod.Implementation
{
	class CombustionEngineCarCreator: CarCreator
	{
		public override Car Create(string make, string model)
		{
			return new CombustionEngineCar(make, model);
		}
	}
}
