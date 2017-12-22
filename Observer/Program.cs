using System;
using Observer.Implementation;
using Observer.Interfaces;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();
			ICarObserver speedometer = new Speedometer();

			car.AddObserver(speedometer);
			car.Move(70);

			car.RemoveObserver(speedometer);
			car.Move(200);

			Console.Read();
		}
	}
}
