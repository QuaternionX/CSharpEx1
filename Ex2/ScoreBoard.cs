using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercises.Ex2
{
	public class ScoreBoard : IEnumerable<Score>
	{
		private Dictionary<string, Score> scores = new Dictionary<string, Score>();

		public Score this[string name]
		{
			get
			{
				if (this.scores.ContainsKey(name))
				{
					return this.scores[name];
				}

				return null;
			}
			set
			{
				if (this.scores.ContainsKey(name))
				{
					this.scores[name] = value;
				}
				else
				{
					this.scores.Add(name, value);
				}
			}
		}

		public IEnumerator<Score> GetEnumerator()
		{
			return this.scores.Values.GetEnumerator();
		}

		public Score[] GetSortedArray()
		{
			return this.scores.Values.OrderBy(s => s.Value).ToArray();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
