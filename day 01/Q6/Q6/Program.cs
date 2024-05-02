using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Name -: ");
            string name = Console.ReadLine();

            Console.Write("Enter The Marks -: ");
            int marks = int.Parse(Console.ReadLine());

           if (marks >100||marks<0)
            {
                Console.WriteLine("Invalid Marks");
            }
           else if (marks >= 75)
            {
                Console.WriteLine(name + " Grade A");
            }
           else if (marks >= 60)
            {
                Console.WriteLine(name + " Grade B");
            }
           else if (marks >= 50)
            {
                Console.WriteLine(name + " Grade C");
            }
           else if (marks >= 40)
            {
                Console.WriteLine(name + " Grade D");
            }
           else
            {
                Console.WriteLine(name + " Grade F");
            } 
           Console.ReadLine();
        }
    }
}
