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
			var rand = new Random();

			for(int i = 0;i<3959;i++)
			{
				switch (rand.Next(4))
				{
					case 0:
						yield return new DrawBlue();
						break;

					case 1:
						yield return new DrawGreen();
						break;

					case 2:
						yield return new DrawYellow();
						break;

					case 3:
						yield return new DrawRed();
						break;
				}
			}
		}
	}
}
