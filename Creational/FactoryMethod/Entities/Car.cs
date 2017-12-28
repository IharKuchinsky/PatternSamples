using System;

namespace FactoryMethod.Entities
{
	public abstract class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public string Description { get; protected set; }

		protected Car(string make, string model)
		{
			Make = make;
			Model = model;
		}
		
		public virtual void PrintInfo()
		{
			Console.WriteLine($"{Make} {Model} - {Description}");
		}
	}
}
