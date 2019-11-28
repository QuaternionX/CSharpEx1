using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Ex5.Drawable
{
	class DrawGreen : IDrawable
	{
		public void Draw()
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.Write(" ");
			Console.ResetColor();
		}
	}
}
