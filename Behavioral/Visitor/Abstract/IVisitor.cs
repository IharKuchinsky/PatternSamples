using System;
using Visitor.Entities;

namespace Visitor.Abstract
{
	public interface IVisitor
	{
		void Visit(ElectricEngineCar car);
		void Visit(CombustionEngineCar car);
	}
}
