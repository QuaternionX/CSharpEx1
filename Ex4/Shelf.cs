using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Exercises.Ex4.ShelfItems;

namespace Exercises.Ex4
{
	public class Shelf<T> : IEnumerable<T> where T : IShelfItem
	{
		private List<T> items = new List<T>();

		public T this[int index]
		{
			get { return this.items[index]; }
			set { this.items[index] = value; }
		}

		public IEnumerator<T> GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		public void Put(T item)
		{
			if (!this.items.Contains(item))
			{
				this.items.Add(item);
				item.UpdateState(true);
			}
		}

		public T Take(int index)
		{
			var item = this.items[index];

			if (item != null)
			{
				items.RemoveAt(index);
				item.UpdateState(false);
			}

			return item;
		}

		public T Take(T item)
		{
			if (items.Contains(item))
			{
				items.Remove(item);
				item.UpdateState(false);

				return item;
			}

			return default(T);
		}

		public T Take(Func<T, bool> itemSelector)
		{
			var item = this.items.FirstOrDefault(itemSelector);

			if (item != null)
			{
				items.Remove(item);
				item.UpdateState(false);
			}

			return item;
		}

		public int Count()
		{
			return this.items.Count;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
