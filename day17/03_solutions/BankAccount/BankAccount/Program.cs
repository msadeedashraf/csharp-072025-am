namespace BankAccount
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            //Console.WriteLine("Hello World");
            Bankaccount account1 = new Bankaccount("Sadeed","0012311123",500);
            account1.CheckBalance();
            account1.Deposit(1000);
            account1.CheckBalance();
            account1.Withdraw(300);
            account1.Withdraw(300);
            account1.Withdraw(300);
            account1.Withdraw(300);
            account1.Withdraw(300);
            account1.PrintAccountDetails();
            account1.Withdraw(300);




        }

    }


}