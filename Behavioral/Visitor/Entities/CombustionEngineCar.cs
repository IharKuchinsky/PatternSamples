using System;
using Visitor.Abstract;

namespace Visitor.Entities
{
	public class CombustionEngineCar : Car
	{
		public int MaxTankCapacity { get; } = 80; // ltr.
		public int TankCapacity { get; set; }

		public CombustionEngineCar(string make, string model, int tankCapacity) : base(make, model)
		{
			TankCapacity = tankCapacity;
		}

		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}