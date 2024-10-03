using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine(numbers[0]); // 0

            int?[] nullableArray = new int?[10];
            Console.WriteLine(nullableArray[0]); // null

            int[] array1 = { 4, 5, 2, 8, 7 }; // Size = 5

            // Reading elements into an array.
            int[] data = new int[5];
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"Enter the number {i}: ");
                data[i] = int.Parse(Console.ReadLine());
            }

            // Displaying the values of the array.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"The number at index {i} is {data[i]}");
            }

            Console.WriteLine("-------------");
            Console.WriteLine(string.Join(", ", data));
            Console.WriteLine(string.Join("->", data));
        }
    }
}
