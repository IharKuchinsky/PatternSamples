using System;

namespace TemplateMethod.Abstract
{
	public abstract class Car
	{
		protected int TankCapacity;

		public void Move(int distance)
		{
			SetConsumption();
			TurnOnignition();
			SetGear();
			Start();
			Moving(distance);
			Stop();
		}

		protected abstract void SetConsumption();

		protected virtual void TurnOnignition() => Console.WriteLine("Turn On Ignition");

		protected abstract void SetGear();

		protected virtual void Start() => Console.WriteLine("Start a move...");

		protected abstract void Moving(int distance);

		protected virtual void Stop() => Console.WriteLine("Stopping...");
	}
}
