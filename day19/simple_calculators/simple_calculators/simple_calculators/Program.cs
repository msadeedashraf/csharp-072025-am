namespace Simple_calculator
{
    internal class Program
    {

        static void Main(string[] arg)
        {
          /*  
          int x = 50;
          int y = 50;
          int z = 50;
          Console.WriteLine(x + y + z);
          Console.ReadKey();
          */

            /*
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
            Console.ReadKey();
            */


            /*
             int billAmount = 100;
             int tipAmount = 15;
            int totalBillAmount = billAmount+tipAmount;
            Console.WriteLine(totalBillAmount);
            Console.ReadKey();
             */

            /*
             //Tip Calculator
            Console.WriteLine("Tip Amount\n\n\n");
            Console.WriteLine("##########\n\n\n");
            Console.Write("Please input the Bill Amount: ");
            string billAmount = Console.ReadLine();

            Console.Write("Please input the Tip Amount: ");
            string tipAmount = Console.ReadLine();


            
            int totalBillAmount = int.Parse(billAmount)  + Convert.ToInt32(tipAmount);

            Console.WriteLine("Your Bill Total including the Tip is : " + totalBillAmount);
            Console.ReadKey();
            */


            /*
             //Loan Calculator
            Console.WriteLine("Loan Calculator\n");
            Console.WriteLine("##########\n");
            Console.Write("Please input the Loan Amount: ");
            string loanAmount = Console.ReadLine();

            Console.Write("Please input the Rate %: ");
            string rate = Console.ReadLine();


            Console.Write("Please input the No. of Months: ");
            string months = Console.ReadLine();


            int monthlyPayment = 1000;

            Console.WriteLine("Your Monthly Payment is : " + monthlyPayment);
            Console.ReadKey();
            */

            /*
            Console.WriteLine("This is the first Line.");
            Console.WriteLine("This is the second Line.");
            */

            /*
            int firstName;
            //firstName = Convert.ToInt32( "12");
            firstName = 12;
            Console.WriteLine(firstName);
            */

            /*
            //Currency Calculator
            double myUSD = 100;
            double myCAD = 100;
            double conversion = 0.78;

            Console.WriteLine("\t\t\tCurrency Convertor\n");
            Console.WriteLine("Please input USD amount");
            myUSD = Convert.ToDouble(Console.ReadLine());


            myCAD =  myUSD/conversion;
            //Console.WriteLine(myUSD + " USD Converted into " + Math.Round(myCAD,4 )+ " CAD");
            Console.WriteLine($"{myUSD} USD Converted into {Math.Round(myCAD, 4)} CAD");
            */

            //Age Calculator
            DateTime todayDate = DateTime.Now;
            int currentYear = todayDate.Year;

            Console.WriteLine("\t\tAge Convertor\n");
            Console.WriteLine("Please input your DOB:");
            DateTime myDOB = Convert.ToDateTime(Console.ReadLine());
            int myDOBYear = myDOB.Year;


            int myAge = currentYear - myDOBYear;
            Console.WriteLine($"Your are {myAge} year old");
           



        }

    }


}