using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_1.Functions
{
    internal class Program
    {
        static void Greet()
        {
            Console.WriteLine("Hello");
        }

        static void GreetByName(string firstName)
        {
            Console.WriteLine("Hello " + firstName);
        }

        static void GreetByName(string firstName, string lastName)
        {
            Console.WriteLine("Hello " + firstName + " " + lastName);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(short a, int b)
        {
            return a + b;
        }

        static void SingleLineAdd(int a, int b) => Console.WriteLine(a + b);

        static int SignleLineAddWithReturn(int a, int b) => a + b;

        static void Main(string[] args)
        {
            Greet();
            GreetByName("John");
            GreetByName("John", "Doe");
            int result = Add(1, 2);
            Console.WriteLine(result);

            SingleLineAdd(1, 2);
            Console.WriteLine(SignleLineAddWithReturn(1, 2));
        }
    }
}
