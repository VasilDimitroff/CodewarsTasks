using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SumOfDigits_Digital_Root
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Digital root is the recursive sum of all the digits in a number.

			Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.

			Examples:
			16  -->  1 + 6 = 7
			942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
			132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
			493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2    */

			Console.WriteLine(DigitalRoot(493193));
		}

		public static int DigitalRoot(long number)
		{
			int sum = number
				.ToString()
				.Select(x => int.Parse(x.ToString()))
				.ToArray()
				.Sum();

			int digitsCount = 0;
			int sumTemp = sum;

			while (sum > 0)
			{
				sum = sum / 10;
				digitsCount++;
			}

			if (digitsCount > 1)
			{
				return DigitalRoot(sumTemp);
			}

			return sumTemp;
		}
	}
}
