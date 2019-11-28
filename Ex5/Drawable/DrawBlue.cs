using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Ex5.Drawable
{
	class DrawBlue : IDrawable
	{
		public void Draw()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Write(" ");
			Console.ResetColor();
		}
	}
}
