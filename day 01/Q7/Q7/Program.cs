using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
         static int balance = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ATM Machine");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Deposit Money");
            Console.WriteLine("4. Exit");
            
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    checkbalance();
                    break;
                case 2:
                    withdrawmoney();
                    break;
                case 3:
                    depositmoney();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadLine();
        }
        static void checkbalance()
        {
            Console.WriteLine("Your balance is: " + balance);
        }
        static void withdrawmoney()
        {
            Console.WriteLine("Enter the amount to withdraw: ");
            int amount = int.Parse(Console.ReadLine());
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("Amount withdrawn successfully");
                Console.WriteLine("Balance is Rs" + balance);
            }
        } 
        static void depositmoney()
        {
            Console.WriteLine("Enter the amount to deposit: ");
            int amount = int.Parse(Console.ReadLine());
            balance = balance + amount;
            Console.WriteLine("Amount deposited successfully");
            Console.WriteLine("Balance is " + balance);
        }

    }
} 
