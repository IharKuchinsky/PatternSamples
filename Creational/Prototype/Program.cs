using System;
using Prototype.Entities;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			Car audi = new Car("Audi", "RS7", 4, 540);

			var tunnedAudi = audi.Clone();
			tunnedAudi.Engine.Power = 780;

			Console.WriteLine(audi.ToString());
			Console.WriteLine(tunnedAudi.ToString());

			Console.Read();
		}
	}
}
