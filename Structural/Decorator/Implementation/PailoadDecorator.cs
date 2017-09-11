using System;
using Decorator.Interfaces;

namespace Decorator.Implementation
{
	public abstract class PayloadDecorator : IPayload
	{
		protected readonly IPayload Payload;

		protected PayloadDecorator(IPayload payload)
		{
			Payload = payload;
		}

		public abstract void UsefulWork(Action action);
	}
}
