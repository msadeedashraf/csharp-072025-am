using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSol
{
    internal class BusinessAccount : BankAccount , ITransferable
    {

        public  decimal OverdraftLimit { get; set; }

        public BusinessAccount(string accNum, string holder, decimal initialBalance, decimal overdraftLimit)
        : base(accNum, holder, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(decimal amount)
        {
           if (amount > 0 && (Balance - amount) >= -OverdraftLimit) 
                Balance -= amount;
        }

        public void Transfer(BankAccount toAccount, decimal amount) 
        {
            if (amount > 0 && (Balance - amount) >= -OverdraftLimit)
            {
                Withdraw(amount);
                toAccount.Deposit(amount);
            }
        }

    }
}
