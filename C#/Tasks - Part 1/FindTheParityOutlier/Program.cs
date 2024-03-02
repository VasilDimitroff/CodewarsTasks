namespace FindTheParityOutlier
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* You are given an array (which will have a length of at least 3, but could be very large) containing integers.
			The array is either entirely comprised of odd integers or entirely comprised of even integers 
			except for a single integer N. Write a method that takes the array as an argument and returns this "outlier"
			 
			Examples:
			[2, 4, 0, 100, 4, 11, 2602, 36] -->  11 (the only odd number)
			[160, 3, 1719, 19, 11, 13, -21] --> 160 (the only even number)  */

			Console.WriteLine(Find(new int[] { 160, 3, 1719, 19, 11, 13, -21}));
		}

		public static int Find(int[] integers)
		{
			var countOfOdds = integers.Where(x => x % 2 != 0).Count();
			var countOfEvens = integers.Where(x => x % 2 == 0).Count();

			if (countOfEvens > countOfOdds)
			{
				return integers.FirstOrDefault(x => x % 2 != 0);
			}

			return integers.FirstOrDefault(x => x % 2 == 0);
		}
	}
}
