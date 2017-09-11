using System;
using System.Diagnostics;
using Decorator.Interfaces;

namespace Decorator.Implementation
{
	public class TraceDecorator : PayloadDecorator
	{
		public TraceDecorator(IPayload payload) : base(payload)
		{
		}

		public override void UsefulWork(Action action)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			Payload.UsefulWork(action);

			stopwatch.Stop();
			Console.WriteLine($"Time: {stopwatch.Elapsed}");
		}
	}
}