using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class TemperatureTracker
    {
        private double[] temperatures = new double[7]; // Array to store temperatures for each day of the week

        public void SetTemperature(int dayIndex, double temperature)
        {
            if (dayIndex >= 0 && dayIndex < temperatures.Length)
            {
                temperatures[dayIndex] = temperature;
            }
            else
            {
                Console.WriteLine("Invalid day index!");
            }
        }

        public void DisplayWeeklyReport()
        {
            Console.WriteLine("Weekly Temperature Report:");
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
            }
        }
    }
}
  
