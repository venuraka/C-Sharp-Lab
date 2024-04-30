using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating Area Of A Rectangle");

            Console.Write("Enter length -: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter width -: ");
            double width = double.Parse(Console.ReadLine());

            double answer = Area(length, width);

            Console.Write("Area Of The Rectanglee is -: " + answer);
            Console.ReadLine();
        }
        static double Area(double n1, double n2)
        {
            double area=n1*n2;  
            return area;
        }
    }
}
