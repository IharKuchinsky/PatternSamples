using System;
using System.Collections.Generic;
using Visitor.Abstract;

namespace Visitor.Entities
{
	public class CarShowroom
	{
		private readonly List<Car> _carList;

		public CarShowroom()
		{
			_carList = new List<Car>();
		}

		public void Add(Car car) => _carList.Add(car);
		public void Remove(Car car) => _carList.Remove(car);

		public void Accept(IVisitor visitor)
		{
			foreach (var car in _carList) car.Accept(visitor);
		}
	}
}
