using System;

namespace Visitor.Abstract
{
	public abstract class Car
	{
		protected Car(string make, string model)
		{
			Make = make;
			Model = model;
		}

		public string Make { get; set; }
		public string Model { get; set; }
		public abstract void Accept(IVisitor visitor);
	}
}
