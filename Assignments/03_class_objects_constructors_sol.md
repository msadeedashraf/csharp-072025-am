# C# OOP Practice Assignments – Constructors, Classes, Methods

These exercises help students strengthen their understanding of C# object-oriented programming concepts, including class design, constructors, fields, methods, and access modifiers.

---

## 🏦 Assignment 1: BankAccount Simulator

### Objective
Build a basic `BankAccount` class with common banking features.

### Class Structure

```csharp
class BankAccount
{
    public string accountHolder;
    public string accountNumber;
    private double balance;

    public BankAccount(string name, string accNumber, double initialBalance)
    {
        accountHolder = name;
        accountNumber = accNumber;
        balance = initialBalance;
    }

    public void Deposit(double amount) { /* TODO */ }
    public void Withdraw(double amount) { /* TODO */ }
    public void CheckBalance() { /* TODO */ }
    public void PrintAccountDetails() { /* Optional */ }
}
```

### Tasks

1. Create 2 `BankAccount` objects.
2. Perform deposit and withdrawal operations.
3. Print final balance and account details.

### Solution

```
using System;

class BankAccount
{
    public string accountHolder;
    public string accountNumber;
    private double balance;

    public BankAccount(string name, string accNumber, double initialBalance)
    {
        accountHolder = name;
        accountNumber = accNumber;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"{amount} deposited.");
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"{amount} withdrawn.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Balance: {balance}");
    }

    public void PrintAccountDetails()
    {
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Current Balance: {balance}");
    }

    static void Main()
    {
        BankAccount acc1 = new BankAccount("Sadeed", "001", 1000);
        acc1.Deposit(500);
        acc1.Withdraw(300);
        acc1.CheckBalance();
        acc1.PrintAccountDetails();
    }
}
```

---

## 🎓 Assignment 2: Student Report Card

### Objective
Create a class to store and report student grades.

### Class Structure

```csharp
class StudentReport
{
    private string studentName;
    private int subject1, subject2, subject3;

    public StudentReport(string name, int s1, int s2, int s3)
    {
        studentName = name;
        subject1 = s1;
        subject2 = s2;
        subject3 = s3;
    }

    public double CalculateAverage() { /* TODO */ }
    public string GetGrade() { /* TODO */ }
    public void PrintReport() { /* TODO */ }
}
```

### Tasks

1. Create at least 2 student reports.
2. Calculate and print their averages and grades.
3. Use if-else logic to assign grades (A, B, C, etc.)

### Solution

```
using System;

class StudentReport
{
    private string studentName;
    private int subject1, subject2, subject3;

    public StudentReport(string name, int s1, int s2, int s3)
    {
        studentName = name;
        subject1 = s1;
        subject2 = s2;
        subject3 = s3;
    }

    public double CalculateAverage()
    {
        return (subject1 + subject2 + subject3) / 3.0;
    }

    public string GetGrade()
    {
        double avg = CalculateAverage();
        if (avg >= 90) return "A";
        else if (avg >= 80) return "B";
        else if (avg >= 70) return "C";
        else if (avg >= 60) return "D";
        else return "F";
    }

    public void PrintReport()
    {
        Console.WriteLine($"Student: {studentName}");
        Console.WriteLine($"Average: {CalculateAverage()}");
        Console.WriteLine($"Grade: {GetGrade()}");
    }

    static void Main()
    {
        StudentReport s1 = new StudentReport("Ali", 85, 78, 92);
        s1.PrintReport();

        StudentReport s2 = new StudentReport("Sara", 66, 70, 72);
        s2.PrintReport();
    }
}
```

---

## 📚 Assignment 3: Library Book Manager

### Objective
Simulate book borrowing in a library.

### Class Structure

```csharp
class LibraryBook
{
    public string title;
    public string author;
    private bool isAvailable;

    public LibraryBook(string bookTitle, string bookAuthor)
    {
        title = bookTitle;
        author = bookAuthor;
        isAvailable = true;
    }

    public void BorrowBook() { /* TODO */ }
    public void ReturnBook() { /* TODO */ }
    public void GetStatus() { /* TODO */ }
}
```

### Tasks

1. Create 2-3 book objects.
2. Simulate borrowing and returning.
3. Print book availability status.

### Solution

```
using System;

class LibraryBook
{
    public string title;
    public string author;
    private bool isAvailable;

    public LibraryBook(string bookTitle, string bookAuthor)
    {
        title = bookTitle;
        author = bookAuthor;
        isAvailable = true;
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine($"{title} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"{title} is currently not available.");
        }
    }

    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine($"{title} has been returned.");
    }

    public void GetStatus()
    {
        Console.WriteLine($"{title} by {author} is " + (isAvailable ? "available." : "not available."));
    }

    static void Main()
    {
        LibraryBook book1 = new LibraryBook("Clean Code", "Robert C. Martin");
        book1.GetStatus();
        book1.BorrowBook();
        book1.GetStatus();
        book1.ReturnBook();
        book1.GetStatus();

        LibraryBook book2 = new LibraryBook("Atomic Habits", "James Clear");
        book2.BorrowBook();
    }
}
```
---
