using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Bankaccount
    {
    public string accountHolder;
    public string accountNumber;
    private double balance;

    public Bankaccount(string name, string accNumber, double initialBalance)
    {
        accountHolder = name;
        accountNumber = accNumber;
        balance = initialBalance;
    }

    public void Deposit(double amount) {

            balance += amount;
            Console.WriteLine($"{amount} deposited");
        
        
        }
    public void Withdraw(double amount) 
        {
            /* TODO */
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawn");
            }

            

        }
        public void CheckBalance() 
        { 
            /* TODO */ 
            Console.WriteLine($"Your Balance is : {balance}");
        }
    public void PrintAccountDetails() 
        {
            /* Optional */
            Console.WriteLine($"Account Holder : {accountHolder}");
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Current Balance: {balance}");


        }
    }
}
