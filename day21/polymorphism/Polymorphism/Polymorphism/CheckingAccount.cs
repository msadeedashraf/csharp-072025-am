using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class CheckingAccount : BankAccount
    {
        public double OverdraftLimit = 500; 

        public override void Withdraw(double amount)
        {
            if (Balance + OverdraftLimit >= amount)
            { 
                Balance -= amount;
            }

        }

    }
}
