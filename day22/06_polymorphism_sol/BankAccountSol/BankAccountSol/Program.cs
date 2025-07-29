namespace BankAccountSol
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            SavingsAccount sa = new SavingsAccount("AT493536691083252419", "Chris Magan", 1000, 0.05m);
            CheckingAccount ca = new CheckingAccount("AT249667556199763644", "Alex Bob", 2000, 2m);
            BusinessAccount ba = new BusinessAccount("AT804552428146743548", "Alice Peter", 800, 500);    


            List<BankAccount> accounts = new List<BankAccount> { sa, ca, ba};

            Console.WriteLine("===== Performing Transactions ====");
            
            foreach( var account in accounts)
            {
                account.Deposit(300);
                account.Withdraw(200);

                if (account is SavingsAccount savings)
                {

                    savings.ApplyInterest();
                }
                Console.WriteLine($"{account.AccountHolderName} ( {account.GetType().Name}  ) - Balance : {account.Balance}");
            }

            Console.WriteLine("\n === Transfer  Funds from Business to Savings ===");
            ba.Transfer(sa, 400);

            //Final balances

            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.AccountHolderName} ( {account.GetType().Name}  ) - Final Balance : {account.Balance}");
            }




        }

    }
}
