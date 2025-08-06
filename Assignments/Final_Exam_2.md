
# C# Coding-Based Case Study Exam

This exam consists of 10 practical, scenario-based coding problems designed to assess students' understanding of C# 101 fundamentals, object-oriented programming, lambda expressions, list manipulation, file operations, and generics. 

- Attempt any 5
  
---

## Case Study 1: Class and Object Creation
**Scenario:**  
You are building a simple address book application.  
**Task:**  
Create a `Contact` class with the following properties: `Name`, `Email`, and `PhoneNumber`. Instantiate three contact objects and print their details to the console.

---

## Case Study 2: Constructors and Methods
**Scenario:**  
Extend the Address Book functionality.  
**Task:**  
Add a constructor to the `Contact` class that initializes all fields. Add a method `PrintContact()` to display the contact’s details in a formatted way. Create a list of contacts and print them.

---

## Case Study 3: Inheritance
**Scenario:**  
You're designing a vehicle rental system.  
**Task:**  
Create a base class `Vehicle` with properties `Make`, `Model`, and `Year`. Create derived classes `Car` and `Motorcycle`, each with an additional property. Demonstrate polymorphism by overriding a method called `DisplayInfo()`.

---

## Case Study 4: Lists and Lambda Expressions
**Scenario:**  
You're working with a list of integers to analyze test scores.  
**Task:**  
Create a list of integers. Use a lambda expression to filter and display scores greater than 75.

---

## Case Study 5: LINQ and Custom Objects
**Scenario:**  
You have a list of `Student` objects with `Name` and `Marks`.  
**Task:**  
Use LINQ and lambda expressions to:
1. Find students with marks > 80.
2. Count how many students have passed (marks >= 50).

---

## Case Study 6: File Reading
**Scenario:**  
You are creating a log viewer.  
**Task:**  
Read a file named `log.txt` and print each line to the console.

---

## Case Study 7: File Writing
**Scenario:**  
You want to save a contact list to a file.  
**Task:**  
Write the details of multiple contacts (from Case Study 1) into a file named `contacts.txt`, one contact per line.

---

## Case Study 8: Generics
**Scenario:**  
You're building a type-safe container.  
**Task:**  
Create a generic class `Box<T>` that can hold any type of data. Add methods to `AddItem(T item)` and `GetItem()`. Demonstrate usage with strings and integers.

---

## Case Study 9: Encapsulation and Validation
**Scenario:**  
You are designing a bank account system.  
**Task:**  
Create a class `BankAccount` with private fields `accountNumber` and `balance`. Use properties to ensure the balance cannot be negative. Add a method `Deposit(decimal amount)` and `Withdraw(decimal amount)` with validation.

---

## Case Study 10: Static Members and Utility Class
**Scenario:**  
You want to create a utility class for math operations.  
**Task:**  
Create a static class `MathUtils` with methods `Add(int a, int b)` and `Factorial(int n)`. Use these methods in your `Main()` function.

---
