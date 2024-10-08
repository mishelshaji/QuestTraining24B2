using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_1.Namespaces.Utilities
{
    internal static class StringUtilities
    {
        public static void ToUppeCase(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        public static void ToLowCase(string text)
        {
            Console.WriteLine(text.ToLower());
        }
    }
}
