using System;
using System.Threading;
using Decorator.Implementation;
using Decorator.Interfaces;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			IPayload payload = new TraceDecorator(new LogDecorator(new Payload()));

			payload.UsefulWork(() => Thread.Sleep(2000));

			Console.Read();
		}
	}
}
