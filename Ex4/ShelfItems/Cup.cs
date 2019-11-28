namespace Exercises.Ex4.ShelfItems
{
	class Cup : IShelfItem
	{
		bool isOnShelf;
		int putCounter;
		int takeCounter;

		public string GetState()
		{
			return $"Podnoszone:{this.takeCounter}, kładzione:{this.putCounter}";
		}

		public void UpdateState(bool isOnShelf)
		{
			this.isOnShelf = isOnShelf;

			if (this.isOnShelf)
			{
				this.putCounter++;
			}
			else
			{
				this.takeCounter++;
			}
		}
	}
}
