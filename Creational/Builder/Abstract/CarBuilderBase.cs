using System;
using Builder.Entities;

namespace Builder.Abstract
{
	public abstract class CarBuilderBase
	{
		protected ICar Car;

		protected CarBuilderBase()
		{
			Car = new Car();
		}

		public abstract CarBuilderBase Make(string make);
		public abstract CarBuilderBase Model(string model);
		public abstract CarBuilderBase EnginePower(int power);
		public abstract CarBuilderBase DriveType(DriveType driveType);
		public abstract CarBuilderBase GearBox(GearBoxType gearBoxType);
		public abstract ICar Build();
	}
}
