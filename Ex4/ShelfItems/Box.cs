namespace Exercises.Ex4.ShelfItems
{
	class Box : IShelfItem
	{
		bool isOnShelf;
		public string Name { get; set; }

		public string GetState()
		{
			return this.isOnShelf ? "Leży" : "Nie leży";
		}

		public void UpdateState(bool isOnShelf)
		{
			this.isOnShelf = isOnShelf;
		}
	}
}
