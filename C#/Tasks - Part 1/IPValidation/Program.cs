namespace IPValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. 
            IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.

            Valid inputs examples:
            1.2.3.4
            123.45.67.89

            Invalid input examples:
            1.2.3
            1.2.3.4.5
            123.456.78.90
            123.045.067.089

            Notes:
            Leading zeros (e.g. 01.02.03.04) are considered invalid
            Inputs are guaranteed to be a single string
            */

            Console.WriteLine(IsValidIp("1.2.3"));
            Console.WriteLine(IsValidIp("1.2.3.4.5"));
            Console.WriteLine(IsValidIp("123.456.78.90"));
            Console.WriteLine(IsValidIp("123.045.067.089"));
            Console.WriteLine(IsValidIp("01.02.03.04"));
            Console.WriteLine(IsValidIp("1.2.3.4"));
            Console.WriteLine(IsValidIp("123.45.67.89"));
            Console.WriteLine(IsValidIp("12.34.56 .1"));
        }
        public static bool IsValidIp(string ipAddress)
        {
            List<string> ipPartsList = ipAddress.Split('.').ToList();

            if (ipPartsList.Count != 4)
            {
                return false;
            }

            if(!IsNumericCollection(ipPartsList))
            {
                return false;
            }

            if (ipPartsList.Any(el => el[0] == '0' && el.Length > 1))
            {
                return false;
            }

            if (ipPartsList.Any(el => el.Contains(' ')))
            {
                return false;
            }

            if (ipPartsList.Any(el => int.Parse(el) < 0 || int.Parse(el) > 255))
            {
                return false;
            }

            return true;
        }

        public static bool IsNumericCollection(List<string> list)
        {
            foreach (string el in list)
            {
                bool success = int.TryParse(el, out int result);

                if (!success)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
