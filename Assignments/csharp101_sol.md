# 🚀 Basic C# Projects with Solutions

This document provides three beginner-friendly C# assignments **with full solutions** to practice variables, data types, loops, conditional logic, switch, and the ternary operator.

---

## 🔥 Assignment 1: Simple Grade Calculator

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks (0-100): ");
        int marks = int.Parse(Console.ReadLine());

        char grade;

        if (marks >= 90) grade = 'A';
        else if (marks >= 80) grade = 'B';
        else if (marks >= 70) grade = 'C';
        else if (marks >= 60) grade = 'D';
        else if (marks >= 50) grade = 'E';
        else grade = 'F';

        switch (grade)
        {
            case 'A': Console.WriteLine("Excellent work!"); break;
            case 'B': Console.WriteLine("Great job!"); break;
            case 'C': Console.WriteLine("Good effort."); break;
            case 'D': Console.WriteLine("Keep trying."); break;
            case 'E': Console.WriteLine("Pass, but needs improvement."); break;
            case 'F': Console.WriteLine("Fail. Better luck next time."); break;
        }

        string result = marks >= 50 ? "Pass" : "Fail";
        Console.WriteLine($"Result: {result}");
    }
}
```

---

## 🚀 Assignment 2: Number Analyzer

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("How many numbers will you enter? ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            Console.Write($"Enter number {i}: ");
            int num = int.Parse(Console.ReadLine());

            string evenOdd = (num % 2 == 0) ? "Even" : "Odd";

            string posNegZero;
            if (num > 0) posNegZero = "Positive";
            else if (num < 0) posNegZero = "Negative";
            else posNegZero = "Zero";

            Console.WriteLine($"{num} is {evenOdd} and {posNegZero}");
        }
    }
}
```

---

## 💫 Assignment 3: Simple ATM Simulator

```csharp
using System;

class Program
{
    static void Main()
    {
        double balance = 1000;
        int choice;

        do
        {
            Console.WriteLine("\n1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your balance is: ${balance}");
                    break;
                case 2:
                    Console.Write("Enter amount to deposit: ");
                    double deposit = double.Parse(Console.ReadLine());
                    if (deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine($"Deposit successful. New balance: ${balance}");
                    }
                    else
                        Console.WriteLine("Invalid deposit amount.");
                    break;
                case 3:
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    Console.WriteLine(withdraw <= balance && withdraw > 0
                        ? $"Withdrawal successful. New balance: ${balance -= withdraw}"
                        : "Insufficient funds or invalid amount.");
                    break;
                case 4:
                    Console.WriteLine("Thank you for using our ATM.");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        } while (choice != 4);
    }
}
```

---

🚀 **Happy coding!** Try modifying these projects to add more features like transaction history or multiple users.

