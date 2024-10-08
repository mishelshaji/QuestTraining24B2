using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_4.ListDatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            //var lst = new List<int>();


            // Create a list with values.
            var lst2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Adds a single emement.
            lst.Add(10); 

            // Adding multiple values.
            var valuesToAdd = new int[] { 20, 30, 40, 50, 50 };
            lst.AddRange(valuesToAdd);

            // Updating the element.
            lst[0] = 100;

            // Deleting the element.
            // The remove the first occurance of 50.
            lst.Remove(50);

            // Remove form a specfic index.
            lst.RemoveAt(1);

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + ", ");
            }

            Console.WriteLine();
            foreach (var item in lst)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
