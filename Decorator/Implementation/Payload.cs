using System;
using Decorator.Interfaces;
namespace Decorator.Implementation
{
	class Payload : IPayload
	{
		public void UsefulWork(Action action)
		{
			Console.WriteLine($"Method {this.GetType().Name} is work...");

			action();
		}
	}
}
