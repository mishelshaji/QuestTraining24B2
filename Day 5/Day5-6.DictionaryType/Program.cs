using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_6.DictionaryType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> d = new Dictionary<string, string>();
            //var d = new Dictionary<string, string>
            //{
            //    // Adding values.
            //    { "First Name", "John" },
            //    { "Last Name", "Doe" }
            //};
            var d = new Dictionary<string, string>();

            // Adding values.
            d.Add("First Name", "John");
            d.Add("Last Name", "Doe");

            // Accessing a value.
            Console.WriteLine(d["First Name"]);

            // Updating value.
            d["First Name"] = "Jane";
            Console.WriteLine(d["First Name"]);

            // Remove a value.
            d.Remove("Last Name");

            d.Add("Age", "25");

            // Check if a key exists.
            if (d.ContainsKey("Age"))
            {
                Console.WriteLine("Age key exists.");
            }
            else
            {
                Console.WriteLine("Age does not exist.");
            }

            // Looping a dictionary.
            Console.WriteLine("-----------");
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
