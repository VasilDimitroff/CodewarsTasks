namespace Square_n_Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Complete the square sum function so that it squares each number passed into it and then sums the results together.

			For example, for [1, 2, 2] it should return 9 because Square of 1 + Square of 2 + Square of 2 = 9 */

			var result = SquareSum(new int[] { 5, 3, 4 });
			Console.WriteLine(result);
		}
		public static int SquareSum(int[] numbers) => numbers.Select(x => x * x).Sum();	
	}
}
