using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello World";
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
