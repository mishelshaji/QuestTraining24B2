using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_3.SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "THREE";
            switch (num)
            {
                case "ONE":
                    Console.WriteLine(1);
                    break;
                case "TWO":
                    Console.WriteLine(2);
                    break;
                case "THREE":
                    Console.WriteLine(3);
                    break;
                default:
                    Console.WriteLine("INVALID");
                    break;
            }
        }
    }
}
