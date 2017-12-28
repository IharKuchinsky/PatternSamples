using System;
using Builder.Abstract;
using Builder.Entities;

namespace Builder.Implementation
{
	public class CarBuilder : CarBuilderBase
	{
		public override CarBuilderBase Make(string make)
		{
			Car.Make = make;
			return this;
		}

		public override CarBuilderBase Model(string model)
		{
			Car.Model = model;
			return this;
		}

		public override CarBuilderBase EnginePower(int power)
		{
			Car.EnginePower = power;
			return this;
		}

		public override CarBuilderBase DriveType(DriveType driveType)
		{
			Car.DriveType = driveType;
			return this;
		}

		public override CarBuilderBase GearBox(GearBoxType gearBoxType)
		{
			Car.GearBoxType = gearBoxType;
			return this;
		}

		public override ICar Build()
		{
			return Car;
		}
	}
}

