using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_1.StringAndNullableArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"a", "b", "c"};
            Console.WriteLine(names[0].ToUpper());

            string[] nullNames = new string[3];
            //Console.WriteLine(nullNames[0].ToUpper());
            Console.WriteLine(nullNames[0]?.ToUpper());

            string[] nullNames1 = {null, null, null};
            Console.WriteLine(nullNames1[0]?.ToUpper());

            // The code is:
            var value = nullNames[0];
            if(value != null)
            {
                Console.WriteLine(value.ToUpper());
            }
        }
    }
}
