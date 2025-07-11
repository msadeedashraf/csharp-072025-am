// See https://aka.ms/new-console-template for more information
string method = "A";

do
{

    Console.WriteLine("\t\tFour Function Calculator\n");
    Console.WriteLine("Please input your prefered operation \n\t\t A for Addition \n\t\t S for Subtraction \n\t\t D for Divide\n\t\t M for Multiply\n\t\t Q to Quit the program");




    method = Console.ReadLine();


    method = method.ToUpper();

    if (method == "A" || method == "D" || method == "S" || method == "M" )
    {
        if (method == "A")
        {
            Console.WriteLine("You are about to Add two numbers: ");
        }
        else if (method == "S")
        {
            Console.WriteLine("You are about to Subtract two numbers: ");

        }
        else if (method == "D")
        {
            Console.WriteLine("You are about to Multiply two numbers: ");
        }
        else if (method == "M")
        {
            Console.WriteLine("You are about to Divide two numbers: ");
        }

        

        Console.WriteLine("Please input the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please input the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());


        if (method.ToUpper() == "A")
        {
            

            Console.WriteLine($"Your Result after addition is : {num1 + num2}");
            Console.WriteLine("Press any key to continue calculating...\nYou can press 'Q' to quit");
            method = Console.ReadLine();
            method = method.ToUpper();

        }
        else if (method.ToUpper() == "S")
        {
            
            Console.WriteLine($"Your Result after addition is : {num1 - num2}");
            Console.WriteLine("Press any key to continue calculating...\nYou can press 'Q' to quit");
            method = Console.ReadLine();
            method = method.ToUpper();
        }

        else if (method.ToUpper() == "M")
        {
            
            Console.WriteLine($"Your Result after addition is : {num1 * num2}");
            Console.WriteLine("Press any key to continue calculating...\nYou can press 'Q' to quit");
            method = Console.ReadLine();
            method = method.ToUpper();
        }

        else if (method.ToUpper() == "D")
        {
           
            Console.WriteLine($"Your Result after addition is : {num1 / num2}");
            Console.WriteLine("Press any key to continue calculating...\nYou can press 'Q' to quit");
            method = Console.ReadLine();
            method = method.ToUpper();
        }


    }
    
    else if (method == "Q")
    {
       break;
    }
    else
    {
        Console.WriteLine("Invalid input press any key to go back to calculator \n\t\t or press Q to quiting the program");
        method = Console.ReadLine();
        method = method.ToUpper();
      
    }

}

while (method != "Q");



Console.WriteLine("Thank you for using the calculator");












