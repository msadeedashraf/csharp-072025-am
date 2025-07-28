using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BankAccount
    {
        public  string  AccountNo { get; set; }
        public  string  Title { get; set; }
        public  double  Balance { get; set; }

        public virtual void Deposit( double amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public virtual  void CheckBalance()
        {

            Console.WriteLine($"Account Title : {Title}");
            Console.WriteLine($"Account Number : {AccountNo}");
            if (Balance < 0)
            {
                Console.WriteLine("You account is in overdraft");
            }
            else if (Balance > -500)
            {
                Console.WriteLine("You account has reached the overdraft limit");
            }

            Console.WriteLine($"My Balance : {Balance}");

        }
    }
}
