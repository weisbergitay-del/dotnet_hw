using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VipAccount : Account
    {

        public VipAccount(int accountNumber, double balance) : base(accountNumber, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && (balance - amount) >= -5000)
            {
                balance -= amount;
                Console.WriteLine(balance);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal: Exceeds overdraft limit of -5000.");
            }
        }
    }
}

