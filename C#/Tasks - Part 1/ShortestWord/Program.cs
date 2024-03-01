using System.Linq;

namespace ShortestWord
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Simple, given a string of words, return the length of the shortest word(s).
			String will never be empty and you do not need to account for different data types. */

			var result = FindShort("bitcoin take over the world maybe who knows perhaps");
			Console.WriteLine(result);
		}

		public static int FindShort(string s)
		{
			return s.Split(' ').Min(x => x.Length);
		}
	}
}
