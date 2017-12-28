using System;

namespace FactoryMethod.Entities
{
	class CombustionEngineCar: Car
	{
		public CombustionEngineCar(string make, string model) : base(make, model)
		{
			Description = "Combustion Engine";
		}
	}
}
