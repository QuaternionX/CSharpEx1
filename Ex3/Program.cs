using System;

namespace Exercises.Ex3
{
	class Program
	{
		static void Main(string[] args)
		{
			var num1 = new RomanNumerals(13);
			var num2 = new RomanNumerals("XXX");

			Console.WriteLine(num1);//XIII
			Console.WriteLine(num2);//XXX
			Console.WriteLine(num1 + num2);//XLIII
			Console.WriteLine(num1 + 10);//XXIII
			Console.WriteLine(15 + num1);//XXVIII
			Console.WriteLine(num2 - num1);//XVII
			Console.WriteLine(num1 - num2);//-XVII
			Console.WriteLine(num1 - 10);//III
			Console.WriteLine(50 - num1);//XXXVII
			Console.WriteLine(num1 * num2);//CCCXC
			Console.WriteLine(num1 * 10);//CXXX
			Console.WriteLine(50 * num1);//DCL
			Console.WriteLine(num1 / num2);//
			Console.WriteLine(num1 / 10);//I
			Console.WriteLine(50 / num1);//III

			int val = (int)num1;
			num1 = 123;

			Console.WriteLine(val);//13
			Console.WriteLine(num1);//CXXIII

			Console.ReadKey();
		}
	}
}
