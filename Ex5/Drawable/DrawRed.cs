using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Ex5.Drawable
{
	class DrawRed : IDrawable
	{
		public void Draw()
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.Write(" ");
			Console.ResetColor();
		}
	}
}
