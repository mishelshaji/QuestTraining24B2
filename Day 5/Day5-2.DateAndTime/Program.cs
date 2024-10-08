using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_2.DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Local date and time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // UTC Time
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);

            Console.WriteLine($"Day: {dt.Day}");
            Console.WriteLine($"Month: {dt.Month}");
            Console.WriteLine($"Year: {dt.Year}");

            Console.WriteLine($"Hour: {dt.Hour}");
            Console.WriteLine($"Minute: {dt.Minute}");
            Console.WriteLine($"Second: {dt.Second}");
            Console.WriteLine($"Millisecond: {dt.Millisecond}");

            // Date Time Operations
            var tenDaysFromNow = dt.AddDays(10);
            Console.WriteLine(tenDaysFromNow);

            var tenDaysAndTwentyHoursFromNow = dt.AddHours(20).AddDays(10);
            Console.WriteLine(tenDaysAndTwentyHoursFromNow);

            // Formatting the output
            Console.WriteLine("---------------");
            Console.WriteLine($"Standard Output: {dt}");
            Console.WriteLine(dt.ToString("dd-MM-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyyy"));
            Console.WriteLine(dt.ToString("hh:mm:ss"));

            // Constructing Date Time
            var myDt = new DateTime(2024, 10, 7, 12, 50, 59);
            Console.WriteLine($"My Date and time: {myDt}");
        }
    }
}
