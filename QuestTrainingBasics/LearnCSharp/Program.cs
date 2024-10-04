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
            // 1
            // 2 3
            // 4 5 6
            // 7 8 8 10
            int rows = 6;
            int count = 1;
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j <=i; j++)
                {
                    //Console.Write("{0, 3}", count++);
                    Console.Write($"{count++, -3}");
                }
                Console.WriteLine();
            }
        }
    }
}
