using System;
using System.Collections.Generic;

namespace Exercises.Ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			var elements = new List<int>();

			for (int i = 0; i < 1000; i += i * 2 + (++i))
			{
				elements.Add(i);
			}

			foreach(int element in elements)
			{
				Console.Write("{0},", element);
			}

			Console.WriteLine();

			var enumerator = elements.GetEnumerator();

			while (enumerator.MoveNext())
			{
				Console.Write("{0}\n", enumerator.Current % 7 == 0 ? enumerator.Current : -enumerator.Current % 3);
			}

			Console.ReadKey();
		}
	}
}
