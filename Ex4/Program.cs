using System;
using Exercises.Ex4.ShelfItems;

namespace Exercises.Ex4
{
	class Program
	{
		static void Main(string[] args)
		{
			var boxShelf = new Shelf<Box>();
			var carShelf = new Shelf<CarModel>();
			var cupShelf = new Shelf<Cup>();
			var box = new Box();
			var box1 = new Box();
			var box2 = new Box() { Name = "Specjal" };
			var car = new CarModel();
			var car1 = new CarModel();
			var car2 = new CarModel();
			var cup = new Cup();
			var cup1 = new Cup();
			var cup2 = new Cup();

			boxShelf.Put(box);
			boxShelf.Put(box1);
			boxShelf.Put(box2);
			carShelf.Put(car);
			carShelf.Put(car1);
			carShelf.Put(car2);
			cupShelf.Put(cup);
			cupShelf.Put(cup1);
			cupShelf.Put(cup2);
			WriteState(boxShelf);
			WriteState(carShelf);
			WriteState(cupShelf);
			//Leży
			//Leży
			//Leży
			//Value: <jakaś_losowa_wartość>
			//Value: <jakaś_losowa_wartość>
			//Value: <jakaś_losowa_wartość>
			//Podnoszone:0, kładzione:1
			//Podnoszone:0, kładzione:1
			//Podnoszone:0, kładzione:1

			boxShelf.Put(box);
			boxShelf.Put(box1);
			boxShelf.Put(box2);
			carShelf.Put(car);
			carShelf.Put(car1);
			carShelf.Put(car2);
			cupShelf.Put(cup);
			cupShelf.Put(cup1);
			cupShelf.Put(cup2);
			WriteState(boxShelf);
			WriteState(carShelf);
			WriteState(cupShelf);
			//Leży
			//Leży
			//Leży
			//Value: <jakaś_losowa_wartość_jak_wcześniej>
			//Value: <jakaś_losowa_wartość_jak_wcześniej>
			//Value: <jakaś_losowa_wartość_jak_wcześniej>
			//Podnoszone:0, kładzione:1
			//Podnoszone:0, kładzione:1
			//Podnoszone:0, kładzione:1

			var temp = boxShelf.Take(0);
			temp = boxShelf.Take(box1);
			temp = boxShelf.Take(b => b.Name == "Specjal");
			WriteState(boxShelf);//

			Console.WriteLine(box.GetState());//Nie leży
			Console.WriteLine(box1.GetState());//Nie leży
			Console.WriteLine(box2.GetState());//Nie leży

			carShelf.Take(car);
			carShelf.Take(1);
			Console.WriteLine(car.GetState());//Value: <wartość_mniejsza_o_10>
			Console.WriteLine(car1.GetState());//Value: <jakaś_losowa_wartość_jak_wcześniej>
			Console.WriteLine(car2.GetState());//Value: <wartość_mniejsza_o_10>
			
			var x= carShelf.Take(car);
			Console.WriteLine(x == null ? "jest null" : $"{x.GetState()}");//jest null
			Console.WriteLine($"{carShelf.Count()}");//1

			Console.ReadKey();
		}

		private static void WriteState<T>(Shelf<T> shelf) where T : IShelfItem
		{
			foreach (var item in shelf)
			{
				Console.WriteLine(item.GetState());
			}
		}
	}
}
