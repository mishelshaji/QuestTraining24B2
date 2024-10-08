using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_3.ObjectType
{
    internal class Program
    {
        static void DoThis(object a, object b)
        {
            //Type t1 = a.GetType();
            //Type t2 = typeof(string);
            if (a.GetType() == typeof(string))
            {
                string s1 = (string)a;
                string s2 = (string)b;
                Console.WriteLine(s1 + " " + s2);
            }
            else if (a.GetType() == typeof(int))
            {
                int i1 = (int)a;
                int i2 = (int)b;
                Console.WriteLine(i1 + i2);
            }
        }

        static void Main(string[] args)
        {
            DoThis(1, 2);
            DoThis("Hello", "World");
            //string s = "Hello";
            //Type t = s.GetType();
            //Console.WriteLine((t.Name));
        }
    }
}
