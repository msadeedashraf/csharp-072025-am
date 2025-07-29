using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSol
{
    internal class CheckingAccount : BankAccount
    {
        public decimal TransactionFee { get; set; }

        public CheckingAccount(string accNum, string holder, decimal intialBalance, decimal fee)
            : base(accNum, holder, intialBalance)
        {
            TransactionFee = fee;
        }

        public override void Withdraw(decimal amount)
        {
            decimal totalAmount = amount + TransactionFee;
            if (amount > 0 && totalAmount <= Balance)
            { 
            Balance -= totalAmount;
            }
        }


    }
}
