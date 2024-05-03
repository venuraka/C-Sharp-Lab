using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker track = new TemperatureTracker(); // Instantiate TemperatureTracker

            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int i = 0; i < daysOfTheWeek.Length; i++)
            {
                Console.Write("Enter temperature for " + daysOfTheWeek[i] + ":- ");
                double temp = double.Parse(Console.ReadLine()); // Read temperature as double
                track.SetTemperature(i, temp); // Store temperature for the current day
            }

            // Display the weekly report
            track.DisplayWeeklyReport();

            Console.ReadLine();
        }
    }
}
