using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate account class
            Account myAccount = new Account();
            double currentAmount = 0.0;

            //save money in current account
            currentAmount = myAccount.setAccountBalance(1000.0);
            Console.WriteLine($"Current amount: {currentAmount}");

            //withdraw 200.00
            currentAmount = myAccount.withdrawFromAccount(200.00);
            Console.WriteLine($"Current amount: {currentAmount}");

            //get balance
            currentAmount = myAccount.getAccountBalance();
            Console.WriteLine($"Current amount: {currentAmount}");
            Console.ReadLine();
        }
    }
}
