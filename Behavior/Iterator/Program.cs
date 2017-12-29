using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Iterator.Implementation;

namespace Iterator
{
	class Program
	{
		static void Main(string[] args)
		{
			RandomAccesList<int> randomAccesListGeneric = new RandomAccesList<int>{1, 2, 3, 4, 5};
			randomAccesListGeneric.Add(6);

			IEnumerable randomAccesList = randomAccesListGeneric;

			foreach (var item in randomAccesListGeneric) Console.WriteLine(item);
			Console.WriteLine();
			foreach (var item in randomAccesList) Console.WriteLine(item);

			Console.Read();
		}
	}
}
