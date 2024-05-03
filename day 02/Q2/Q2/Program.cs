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
            Console.Write("Enter the account number -: ");
            int accountNumber = int.Parse(Console.ReadLine());

            BankAccount account1 = new BankAccount();
            account1.AccountNumber = accountNumber;

            account1.Deposit();

            Console.ReadLine();
        }
    }
}
