using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace WhoLikesIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items.We want to create the text that should be displayed next to such an item.

            //Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:

            //[]-- > "no one likes this"
            //["Peter"]-- > "Peter likes this"
            //["Jacob", "Alex"]-- > "Jacob and Alex like this"
            //["Max", "John", "Mark"]-- > "Max, John and Mark like this"
            //["Alex", "Jacob", "Mark", "Max"]-- > "Alex, Jacob and 2 others like this"
            //Note: For 4 or more names, the number in "and 2 others" simply increases.

            Console.WriteLine(Likes(["Alex", "Jacob", "Mark", "Max"]));
        }

        public static string Likes(string[] name)
        {
            var returnString = string.Empty;

            if (name.Length == 0)
            {
                returnString = "no one likes this";
            }
            else if (name.Length == 1)
            {
                returnString = $"{name[0]} likes this";
            }
            else if (name.Length == 2)
            {
                returnString = $"{name[0]} and {name[1]} like this";
            }
            else if (name.Length == 3)
            {
                returnString = $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else
            {
                returnString = $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }

            return returnString;
        }
    }
}
