using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class LibraryBook
    {
        public string Title;
        public string Author;
        public bool Available;


        public void BorrowBook(bool Available)
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine("Book borrowed.");
            }
            else
            {
                Console.WriteLine("Book not available.");
            }
        }
    }
    }
