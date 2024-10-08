using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_1.Namespaces.Utilities
{
    internal static class MathUtilities
    {
        public static void Add(int a, int b) => Console.WriteLine(a + b);

        public static void Sub(int a, int b) => Console.WriteLine(a - b);

        public static void Mul(int a, int b) => Console.WriteLine(a * b);

        public static void Div(int a, int b) => Console.WriteLine(a / b);
    }
}
