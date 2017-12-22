using System;
using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer.Implementation
{
	public class Car : ICarObservable
	{
		private readonly List<ICarObserver> _observers;
		
		public Car()
		{
			_observers = new List<ICarObserver>();
		}

		public void AddObserver(ICarObserver observer) => _observers.Add(observer);

		public void RemoveObserver(ICarObserver observer) => _observers.Remove(observer);

		public void NotifyObservers(CurrentCarStats stats)
		{
			_observers.ForEach(observer =>
			{
				observer.Update(stats);
			});
		}

		public void Move(int targetSpeed)
		{
			CurrentCarStats currentCarStats = new CurrentCarStats();

			for (int speed = 0; speed < targetSpeed; speed++)
			{
				currentCarStats.Speed = speed;

				NotifyObservers(currentCarStats);
			}
		}
	}
}
