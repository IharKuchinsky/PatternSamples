using System;
using Decorator.Interfaces;

namespace Decorator.Implementation
{
	public class LogDecorator : PayloadDecorator
	{
		public LogDecorator(IPayload payload) : base(payload)
		{
		}

		public override void UsefulWork(Action action)
		{
			Console.WriteLine("Starting work method:");

			Payload.UsefulWork(action);

			Console.WriteLine("End work of method");
		}
	}
}
