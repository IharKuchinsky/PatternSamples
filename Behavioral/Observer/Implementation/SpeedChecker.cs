using System;
using Observer.Interfaces;

namespace Observer.Implementation
{
	public class SpeedChecker: ICarObserver
	{
		private readonly int _speedLimit = 0;

		public SpeedChecker(int speedLimit)
		{
			_speedLimit = speedLimit;
		}

		public void Update(CurrentCarStats stats)
		{
			int overSpeed = stats.Speed - _speedLimit;

			if (overSpeed > 0) WarnOfOverSpeed(overSpeed);
		}

		private void WarnOfOverSpeed(int overSpeed) => Console.WriteLine($"Speed is exceeded by {overSpeed} km/h");
	}
}
