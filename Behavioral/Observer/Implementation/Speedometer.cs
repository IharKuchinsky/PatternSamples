using System;
using Observer.Interfaces;

namespace Observer.Implementation
{
	public class Speedometer: ICarObserver
	{
		public void Update(CurrentCarStats stats)
		{
			int speedLimit = 60;
			int overSpeed = stats.Speed - speedLimit;

			if (overSpeed > 0) WarnOfOverSpeed(overSpeed);
		}

		private void WarnOfOverSpeed(int overSpeed) => Console.WriteLine($"Speed is exceeded by {overSpeed} km/h");
	}
}
