// See https://aka.ms/new-console-template for more information
/*
int x = 50;
int y = 90;
int result = x + y;
Console.WriteLine(result);
*/

/*
int x, y, z;
x = 10;
y = 50;
z = 60;

Console.WriteLine(z+y-x);
*/
/*
int x, y, z;

x=y=z = 10;

Console.WriteLine(z+y+x);
*/

/*
int myBillAmount = 100;
int tipAmount = 15;
int totalBillAmount = myBillAmount + tipAmount;
Console.WriteLine("My Total Bill is " + totalBillAmount);
*/

//Tip Calculator
/*
Console.WriteLine("Tip Amount\n\n\n");
Console.WriteLine("##########\n\n\n");
Console.Write("Please input the Bill Amount: ");
string billAmount = Console.ReadLine();
Console.Write("Please input the Tip Amount: ");
string tipAmount = Console.ReadLine();


//int totalBillAmount =  Convert.ToInt32(billAmount) + Convert.ToInt32(tipAmount);

int totalBillAmount = int.Parse(billAmount) + int.Parse(tipAmount);

Console.WriteLine("My Total Bill is " + totalBillAmount);
*/

//Loan Calculator
            Console.WriteLine("Loan Calculator\n");
            Console.WriteLine("##########\n");
            Console.Write("Please input the Loan Amount: ");
            string loanAmountInput = Console.ReadLine();
            double loanAmount = double.Parse(loanAmountInput);


            Console.Write("Please input the annual Rate %: ");
            string rateInput = Console.ReadLine();
            double annualRate = double.Parse(rateInput);


            Console.Write("Please input the No. of Months: ");
            string monthsInput = Console.ReadLine();
            double months = double.Parse(monthsInput);

double monthlyRate = (annualRate / 100) / 12;

double monthlyPayment = loanAmount * 
                             (monthlyRate * Math.Pow(1 + monthlyRate, months)) / 
                             (Math.Pow(1 + monthlyRate, months) - 1);
        

            Console.WriteLine("Your Monthly Payment is : " + monthlyPayment);
        