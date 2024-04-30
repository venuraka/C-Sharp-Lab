using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;i<=10;i++) 
            {
                Console.Write("Enter A Number -: ");
                int number = int.Parse(Console.ReadLine());
                if(number % 2  == 0) 
                {
                    Console.WriteLine("Number " + number + " is a even number");
                }
                else 
                {
                    Console.WriteLine("Number " + number + " is a odd number");
                }
            }
        }
    }
}
