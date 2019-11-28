using System;

namespace Exercises.Ex2
{
	class Program
	{
		static void Main(string[] args)
		{
			var scoreBoard = new ScoreBoard();

			scoreBoard["Julia"] = new Score() { Name = "Julia", Value = 10.5 };
			scoreBoard["Ewa"] = new Score() { Name = "Ewa", Value = 6.0 };
			scoreBoard["Julia"] = new Score() { Name = "Julia", Value = 10.4 };
			scoreBoard["Marek"] = new Score() { Name = "Marek", Value = 0.50 };
			scoreBoard["Tomek"] = new Score() { Name = "Tomek", Value = 11.0405 };
			scoreBoard["Piotr"] = new Score() { Name = "Piotr", Value = 1.80 };

			var scores = new Score[5];
			scores[0] = scoreBoard["Julia"];
			scores[1] = scoreBoard["Ewa"];
			scores[2] = scoreBoard["Krzysiek"];
			scores[3] = scoreBoard["Marek"];
			scores[4] = scoreBoard["Tomek"];

			for (int i = 0; i < scores.Length; i++)
			{
				Console.WriteLine(scores[i] != null ? scores[i].ToString() : "Ni ma");// Wypisze <Imię> has <wartość> points jeżeli scores[i] nie jest nullem.
			}

			Console.WriteLine("---------------------------");

			foreach (Score score in scoreBoard)
			{
				Console.WriteLine(score.ToString());
			}

			Console.WriteLine("---------------------------");

			Score[] sortedScores = scoreBoard.GetSortedArray(); //Sortowanie od najmniejszej do największej wartości.

			foreach (var score in sortedScores)
			{
				Console.WriteLine(score.ToString());
			}

			Console.ReadKey();
		}
	}
}
