using System;
using FactoryMethod.Entities;

namespace FactoryMethod.Implementation
{
	public abstract class CarCreator
	{
		public abstract Car Create(string make, string model);
	}
}
