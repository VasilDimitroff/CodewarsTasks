namespace ConvertNumberТоString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * We need a function that can transform a number (integer) into a string.
               What ways of achieving this do you know?

            123  --> "123"
            999  --> "999"
            -100 --> "-100"
             */
            ConvertNumberToString(123);
        }

        static string ConvertNumberToString(int number) => number.ToString();
    }
}
