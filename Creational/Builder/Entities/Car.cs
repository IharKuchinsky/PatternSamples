using System;
using Builder.Abstract;

namespace Builder.Entities
{
	public class Car: ICar
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int EnginePower { get; set; }
		public DriveType DriveType { get; set; }
		public GearBoxType GearBoxType { get; set; }

		public override string ToString()
		{
			return $"{Make} {Model}: {EnginePower} hp., {DriveType}, {GearBoxType}";
		}
	}
}
