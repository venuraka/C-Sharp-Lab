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
            int number = 0, total = 0;
            do 
            {
                Console.Write("Enter positive number-: ");
                number = int.Parse(Console.ReadLine());
                total = total + number;
                Console.WriteLine("Total is -:" + total);
            }while (number > 0);

              Console.WriteLine("ERROR");
              Console.WriteLine("Total is -:" + total);
            
            Console.ReadLine();
        }
    }
}

