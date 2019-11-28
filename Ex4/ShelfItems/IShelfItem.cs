namespace Exercises.Ex4.ShelfItems
{
	public interface IShelfItem
	{
		void UpdateState(bool isOnShelf);
		string GetState();
	}
}