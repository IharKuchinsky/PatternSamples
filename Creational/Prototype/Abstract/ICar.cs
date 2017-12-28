using System;
using Prototype.Entities;

namespace Prototype.Abstract
{
	public interface ICar
	{
		string Make { get; }
		string Model { get; }
		CarEngine Engine { get; }

		Car Clone();
	}
}
