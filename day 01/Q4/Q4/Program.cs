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
            int n,fn1=0,fn2=1,output;
            Console.Write("Enter Number -: ");
            n = int.Parse(Console.ReadLine());  

              if(n>=1)
              {
                   Console.Write(fn1 + " ");
              }

                 if(n>=2)
                 {
                      Console.Write(fn2 + " ");
                 }
                   do
                   {
                      output = fn1 + fn2;
                      fn1 = fn2;
                      fn2 = output;
                      n--;
                      Console.Write(output + " ");
                   } while (n > 1);
            Console.ReadLine();   
        }
    }
}
