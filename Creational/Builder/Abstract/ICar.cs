using System;
using Builder.Entities;

namespace Builder.Abstract
{
	public interface ICar
	{
		string Make { get; set; }
		string Model { get; set; }
		int EnginePower { get; set; }
		DriveType DriveType { get; set; }
		GearBoxType GearBoxType { get; set; }
	}
}
