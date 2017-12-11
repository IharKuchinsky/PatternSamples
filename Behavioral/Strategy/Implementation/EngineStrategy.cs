using System;
using System.Collections.Generic;
using Strategy.Entities;
using Strategy.Interfaces;

namespace Strategy.Implementation
{
	public class EngineStrategy : IEngineStrategy
	{
		private readonly EngineType _engineType;
		private readonly Dictionary<EngineType, string> _strategy = new Dictionary<EngineType, string>
		{
			{ EngineType.Electric, "Silen, High-speed, Eco-friendly" },
			{ EngineType.Gasoline, "Middle-loud, High-speed" },
			{ EngineType.Diesel, "Loud, Powerful, Economic" }
		};

		public EngineStrategy(EngineType engineType)
		{
			_engineType = engineType;
		}

		public string GetEngineFeatures() => _strategy[_engineType];
	}
}
