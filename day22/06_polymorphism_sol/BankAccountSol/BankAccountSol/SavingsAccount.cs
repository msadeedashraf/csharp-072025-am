using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSol
{
    internal class SavingsAccount : BankAccount
    {
        public decimal  IntrestRate { get; set; }

        public SavingsAccount(string accNum, string holder, decimal intialBalance, decimal intrestRate)
            : base(accNum, holder, intialBalance)
        {
            IntrestRate = intrestRate;

        }

        public void ApplyInterest()
        {
            Balance += Balance * IntrestRate;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <=Balance)
            {
                Balance -= amount;
            }
        }



    }
}
