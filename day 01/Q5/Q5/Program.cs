using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mult;
            Console.Write("Enter A number: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 12; i++)
            {
              mult = num * i;
              Console.WriteLine( num + "*" + i + "=" + mult );
            }
            Console.ReadLine();
        }

    }
}
