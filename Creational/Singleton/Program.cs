using System;
using Singleton.Entities;
using Singleton.Implementation;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			SetInstancePropirties();

			Console.WriteLine($"{LazySingleton<Car>.Instance.Make} {LazySingleton<Car>.Instance.Model} {LazySingleton<Car>.Instance.Year}");
			Console.WriteLine($"{DubleCheckSingleton<Car>.Instance.Make} {DubleCheckSingleton<Car>.Instance.Model} {DubleCheckSingleton<Car>.Instance.Year}");

			Console.Read();
		}

		public static void SetInstancePropirties()
		{
			var firstLazyInstance = LazySingleton<Car>.Instance;
			var secondLazyInstance = LazySingleton<Car>.Instance;
			LazySingleton<Car>.Instance.Year = 2017;
			firstLazyInstance.Make = "Audi";
			secondLazyInstance.Model = "RS7";

			var firstDoubleCheckInstance = DubleCheckSingleton<Car>.Instance;
			var secondDoubleCheckInstance = DubleCheckSingleton<Car>.Instance;
			DubleCheckSingleton<Car>.Instance.Year = 2016;
			firstDoubleCheckInstance.Make = "BMW";
			secondDoubleCheckInstance.Model = "X6m";
		}
	}
}
