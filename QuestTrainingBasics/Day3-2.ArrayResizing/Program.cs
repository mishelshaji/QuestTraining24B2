using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_2.ArrayResizing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            //arr[3] = 4;

            Array.Resize(ref arr, arr.Length * 2);
            arr[3] = 4;
            arr[4] = 5;
            Console.WriteLine(arr.Length);
        }
    }
}
