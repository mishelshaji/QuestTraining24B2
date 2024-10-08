using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dy4_3.StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METHOD 1
            var res = "";
            res = string.Join(", ", "Hello", "World");
            Console.WriteLine(res);

            var arr = new string[] { "Hi", "World" };
            res = string.Join(", ", arr);
            Console.WriteLine(res);

            // METHOD 2
            res = string.Concat("1", "2", 3, 10.5, true);
            Console.WriteLine(res);

            var concatArray = new string[] { "Hello", "From", "C#" };
            res = string.Concat(concatArray);

            // METHOD 3
            res = string.Format("{0} {1} {2}", "Hello", "From", "C#");
            Console.WriteLine(res);

            res = string.Format("{0} {1} {2} and {2}", "Hello", "From", "C#", "C++");
            Console.WriteLine(res);

            var formatArr = new string[] { "Hello", "From", "C#" };
            res = string.Format("{0} {1} {2}", formatArr);
            Console.WriteLine(res);

            // METHOD 4
            res = "Hello " + "From " + "C#";
            Console.WriteLine(res);

            // METHOD 5
            var language = "C#";
            res = $"Hello from {language}";

            Console.WriteLine("---------------");
            // METHOD 6
            var largeArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sb = new StringBuilder();
            sb.AppendLine("Line 1");
            sb.AppendLine("Line 2");
            sb.Append("No New Line");
            sb.Append("No New Line");
            sb.AppendLine();
            sb.AppendFormat("My name is {0} {1}", "Mishel", "Shaji");
            sb.AppendLine();

            foreach(var item in largeArr)
            {
                sb.AppendFormat("{0}", item);
            }
            res = sb.ToString();

            Console.WriteLine(res);
        }
    }
}
