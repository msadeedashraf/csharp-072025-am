using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSol
{
    internal abstract class BankAccount
    {

        public  string  AccountNumber { get; private set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get;  protected set; }

        public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;

        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public abstract void Withdraw(decimal amount);
       
    }
}
