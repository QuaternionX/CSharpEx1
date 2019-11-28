using System;

namespace Exercises.Ex4.ShelfItems
{
	class CarModel : IShelfItem
	{
		static Random rand = new Random();
		int value = rand.Next(1000);

		public string GetState()
		{
			return $"Value: {this.value}";
		}

		public void UpdateState(bool isOnShelf)
		{
			if (!isOnShelf)
			{
				this.value -= 10;
			}
		}
	}
}
