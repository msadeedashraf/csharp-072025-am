namespace BankAccount
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            //Console.WriteLine("Hello World");
            Bankaccount accout1 = new Bankaccount("Sadeed","0012311123",500);
            accout1.CheckBalance();
            accout1.Deposit(1000);
            accout1.CheckBalance();
            accout1.Withdraw(300);
            accout1.Withdraw(300);
            accout1.Withdraw(300);
            accout1.Withdraw(300);
            accout1.Withdraw(300);
            accout1.PrintAccountDetails();
            accout1.Withdraw(300);




        }

    }


}