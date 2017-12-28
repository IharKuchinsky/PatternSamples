using System;

namespace FactoryMethod.Entities
{
	class ElectricEngineCar: Car
	{
		public ElectricEngineCar(string make, string model) : base(make, model)
		{
			Description = "Electric Engine";
		}
	}
}
