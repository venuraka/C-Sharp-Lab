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
            Book book1 = new Book();
            Book book2 = new Book();

            book1.Title = "diary of a wimpy kid";
            book1.Author = "Jeff Kinney";

            book2.Title = "Harry Potter";
            book2.Author = "J.K. Rowling";

            Console.WriteLine("1 st book is " + book1.Title + " By " + book1.Author);
            Console.WriteLine("2 nd book is " + book2.Title + " By " + book2.Author);
            Console.ReadLine();
        }
    }
}
