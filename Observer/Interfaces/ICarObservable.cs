using System;
using Observer.Implementation;

namespace Observer.Interfaces
{
	interface ICarObservable
	{
		void AddObserver(ICarObserver observer);
		void RemoveObserver(ICarObserver observer);
		void NotifyObservers(CurrentCarStats stats);
	}
}
