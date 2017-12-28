using System;
using Builder.Entities;

namespace Builder.Abstract
{
	public interface ICarBuilder
	{
		ICarBuilder Make(string make);
		ICarBuilder Model(string model);
		ICarBuilder EnginePower(int power);
		ICarBuilder DriveType(DriveType driveType);
		ICarBuilder GearBox(GearBoxType gearBoxType);
		ICar Build();
	}
}
