using System;
using Strategy.Implementation;

namespace Strategy.Entities
{
	public class Car
	{
		private readonly string _make;
		private readonly string _model;
		private readonly EngineType _engineType;

		public Car(string make, string model, EngineType engineType)
		{
			_make = make;
			_model = model;
			_engineType = engineType;
		}

		public void PrintInfo()
		{
			EngineStrategy engineStrategy = new EngineStrategy(_engineType);
			string info = engineStrategy.GetEngineFeatures();

			Console.WriteLine($"{_make} {_model} | {_engineType} engine features: {info}");
		}
	}
}
