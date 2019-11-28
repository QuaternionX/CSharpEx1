using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises.Ex5.Drawable;

namespace Exercises.Ex5
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = GetDrawableItems().ToList();

			list.Draw();
			Console.ReadKey();
		}

		private static IEnumerable<IDrawable> GetDrawableItems()
		{
			throw NotImplementedException();
		}
	}
}
