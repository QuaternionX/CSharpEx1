using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises.Ex3
{
	class RomanNumerals
	{
		private int value;

		public RomanNumerals(int value)
		{
			this.value = value;
		}

		public RomanNumerals(string value) : this(RomanToDecimal(value))
		{
		}

		public override string ToString()
		{
			return DecimalToRoman(value);
		}

		private static string DecimalToRoman(int val)
		{
			var number = Math.Abs(val);
			var retVal = new StringBuilder(5);
			var valueMap = new SortedDictionary<int, string>
								{
									{ 1, "I" }, { 4, "IV" }, { 5, "V" }, { 9, "IX" },
									{ 10, "X" }, { 40, "XL" }, { 50, "L" }, { 90, "XC" },
									{ 100, "C" }, { 400, "CD" }, { 500, "D" }, { 900, "CM" },
									{ 1000, "M" },
								};

			foreach (var kvp in valueMap.Reverse())
			{
				while (number >= kvp.Key)
				{
					number -= kvp.Key;
					retVal.Append(kvp.Value);
				}
			}

			return (val < 0 ? "-" : String.Empty) + retVal.ToString();
		}

		private static int RomanToDecimal(string text)
		{
			var romanMap = new Dictionary<char, int>
			{
				{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
			};

			int totalValue = 0, subTotalValue = 0, prevValue = 0;

			foreach (var c in text)
			{
				if (!romanMap.ContainsKey(c))
				{
					return 0;
				}

				var crtValue = romanMap[c];

				if (prevValue == 0 || prevValue == crtValue)
				{
					subTotalValue += crtValue;
				}
				else if (prevValue > crtValue)
				{
					totalValue += subTotalValue;
					subTotalValue = crtValue;
				}
				else
				{
					totalValue += crtValue - subTotalValue;
					subTotalValue = 0;
				}

				prevValue = crtValue;
			}

			return totalValue + subTotalValue;
		}
	}
}
