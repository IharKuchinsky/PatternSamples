﻿using System;
using Visitor.Abstract;

namespace Visitor.Entities
{
	public class ElectricEngineCar: Car
	{
		public ElectricEngineCar(string make, string model, int batteryCapacity): base(make, model)
		{
			BatteryCapacity = batteryCapacity;
		}

		public int MaxBatteryCapacity { get; } = 100; // Kw/h
		public int BatteryCapacity { get; set; }
		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
