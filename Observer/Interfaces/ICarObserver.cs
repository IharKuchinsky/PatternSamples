using System;
using Observer.Implementation;

namespace Observer.Interfaces
{
	public interface ICarObserver
	{
		void Update(CurrentCarStats stats);
	}
}
