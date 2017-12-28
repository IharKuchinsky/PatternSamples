using System;
using Builder.Abstract;
using Builder.Entities;

namespace Builder.Implementation
{
	public class CarBuilder : ICarBuilder
	{
		private ICar Car { get; set; }

		public CarBuilder()
		{
			Car = new Car();
		}

		public ICarBuilder Make(string make)
		{
			Car.Make = make;
			return this;
		}

		public ICarBuilder Model(string model)
		{
			Car.Model = model;
			return this;
		}

		public ICarBuilder EnginePower(int power)
		{
			Car.EnginePower = power;
			return this;
		}

		public ICarBuilder DriveType(DriveType driveType)
		{
			Car.DriveType = driveType;
			return this;
		}

		public ICarBuilder GearBox(GearBoxType gearBoxType)
		{
			Car.GearBoxType = gearBoxType;
			return this;
		}

		public ICar Build()
		{
			return Car;
		}
	}
}

