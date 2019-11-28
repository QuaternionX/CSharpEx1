using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises.Ex5.Drawable;

namespace Exercises.Ex5
{
	static class Extension
	{
		public static void Draw(this List<IDrawable> list)
		{
			list.ForEach(i => i.Draw());
		}
	}
}
