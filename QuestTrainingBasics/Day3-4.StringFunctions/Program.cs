using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_4.StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "    Hello World    ";
            Console.WriteLine(text.ToUpper()); // HELLO WORLD
            Console.WriteLine(text.ToLower()); // hello world

            Console.WriteLine(text.Trim()); // Hello World
            Console.WriteLine(text.TrimStart()); // Hello World
            Console.WriteLine(text.TrimEnd()); //     Hello World

            Console.WriteLine(text.Replace(" ", "-")); //----Hello-World----
            Console.WriteLine(text.Remove(0, 7)); // lo World

            Console.WriteLine(text.Length); // 20
            Console.WriteLine(text.Trim().Length); // 11

            Console.WriteLine(text.Contains("Hello")); // true

            Console.WriteLine(text.StartsWith("    Hello")); // true
            Console.WriteLine(text.StartsWith("    hello", StringComparison.OrdinalIgnoreCase)); // true
            Console.WriteLine(text.EndsWith("    ")); // true

            char[] chars = text.ToCharArray();
            Console.WriteLine(string.Join(", ", chars)); // H, e, l, l, o,  , W, o, r, l, d

            string[] words = text.Split(' ');
            Console.WriteLine(string.Join(", ", words)); // , , , , Hello,  World, , , , 

            string[] splits = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries); // Hello, World
        }
    }
}
