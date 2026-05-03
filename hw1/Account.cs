using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Account
    {
        protected int accountNumber;
        protected double balance;
        public Account(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine(balance);
            }
            else
            {
                Console.WriteLine("Not enough money");
            }

        }
    }
}
