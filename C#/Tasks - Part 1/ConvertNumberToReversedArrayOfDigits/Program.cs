namespace ConvertNumberToReversedArrayOfDigits
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Given a random non-negative number, you have to return the digits of this number within an array in reverse order.
			Example(Input => Output):

			35231 => [1,3,2,5,3]
			0 => [0]  */

			var result = Digitize(35231);
			Console.WriteLine(result[0]);
		}

		public static long[] Digitize(long number)
		{
			long[] toLongArray = number
									.ToString()
									.Select(i => long.Parse(i.ToString()))
									.ToArray();

			List<long> reversedList = new List<long>();

			for (var i = toLongArray.Length - 1; i >= 0; i--)
			{
				reversedList.Add(toLongArray[i]);
			}

			return reversedList.ToArray();
		}
	}
}
