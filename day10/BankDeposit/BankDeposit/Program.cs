// See https://aka.ms/new-console-template for more information
double myBalance = 1000;
Console.WriteLine($"My Opening Balance is :{myBalance}");
string transactionType = "D";

Console.WriteLine($"Press 'D' for deposit and 'W' for Withdrawal and 'Q' to quit ");
transactionType = Convert.ToString(Console.ReadLine()).ToUpper();

do
{

    if (transactionType == "D")
    {

        double credit = 0;

        Console.WriteLine("Enter the Deposit Amount");
        credit = Convert.ToDouble(Console.ReadLine());

        myBalance = myBalance + credit;
        Console.WriteLine($"My New Balance is :{myBalance}");
        Console.WriteLine($"Do you want to still deposit or Withdrawal.\nPress 'D' for deposit and 'W' for Withdrawal or 'Q' to quit ");
        transactionType = Convert.ToString(Console.ReadLine()).ToUpper();
    }
    else if (transactionType == "W")
    {

        double debit = 0;

        Console.WriteLine("Enter the Withdrawal Amount");
        debit = Convert.ToDouble(Console.ReadLine());

        myBalance = myBalance - debit;

        Console.WriteLine($"My New Balance is :{myBalance}");
        Console.WriteLine($"Do you want to still deposit or Withdrawal.\nPress 'D' for deposit and 'W' for Withdrawal or 'Q' to quit ");
        transactionType = Convert.ToString(Console.ReadLine()).ToUpper();

    }
    else if (transactionType == "Q")
    {
        break;
    }


    else
    {
        Console.WriteLine("Press 'D' to Deposit or 'W' for Withdrawal and 'Q' to quit.");
        transactionType = Convert.ToString(Console.ReadLine()).ToUpper();

    }



}
while (transactionType != "Q");


Console.WriteLine("Thank you for using our bank");




//transactionType = transactionType.ToUpper();








