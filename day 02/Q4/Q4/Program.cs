using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product product1 =new product("Laptop", 1000);
            product product2 =new product("Mobile", 500);

            Console.WriteLine("Product is " + product1.ProductName + " and price is " + product1.Price);    
            Console.WriteLine("Product is " + product2.ProductName + " and price is " + product2.Price);
            Console.ReadLine();
        }
    }
}
