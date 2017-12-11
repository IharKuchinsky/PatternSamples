using System;
using TemplateMethod.Abstract;
using TemplateMethod.Implementation;

namespace TemplateMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Car audi = new Audi();
			Car tesla = new Tesla();

			audi.Move(500);
			Console.WriteLine();
			tesla.Move(500);

			Console.Read();
		}
	}
}
