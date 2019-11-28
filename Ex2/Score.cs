namespace Exercises.Ex2
{
	public class Score
	{
		public string Name { get; set; }
		public double Value { get; set; }

		public override string ToString()
		{
			return $"{Name} has {Value} points";
		}
	}
}