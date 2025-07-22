# C# OOP Practice Assignments – Constructors, Classes, Methods

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

---

## 🔁 Bonus Ideas (For All Assignments)

- Use lists/arrays to manage multiple objects.
- Use `static` methods to count instances.
- Use `ToString()` to simplify printing.

---
