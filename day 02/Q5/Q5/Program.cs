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
            LibraryBook book1 = new LibraryBook();
          

            Console.Write("Enter the tiltle of the book-: ");
            string title = Console.ReadLine();
            title = book1.Title;
            
            Console.Write("Is this book available (true/false): ");
            bool available = bool.Parse(Console.ReadLine());
            book1.BorrowBook(available);
            Console.ReadLine();
        }
    }
}
