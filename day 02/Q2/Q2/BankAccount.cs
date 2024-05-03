using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class BankAccount
    {
        public int AccountNumber;
        public int Balance=1000;

        public void Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            int amount = int.Parse(Console.ReadLine());
            Balance=Balance+amount;
            Console.WriteLine("Amount deposited successfully,your balance is "+Balance);

        }
    }
}
