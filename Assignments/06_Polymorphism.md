## C# OOP Assignments: Inheritance (Banking Theme)

### Overview
These assignments will help students understand **inheritance** in C# by applying it in a real-world context: **Banking systems**. Students should already be familiar with classes, constructors, fields, and properties.

---

### Assignment 1: Create a Base BankAccount Class

**Objective:** Learn how to define a base class and use constructors and properties.

**Instructions:**
- Create a class named `BankAccount`.
- Add the following fields and properties:
  - `AccountNumber` (string, public get, private set)
  - `AccountHolderName` (string, public get/set)
  - `Balance` (decimal, public get only)
- Add a constructor that accepts `accountNumber`, `accountHolderName`, and `initialBalance`.
- Add a method `Deposit(decimal amount)` that increases the balance.
- Add a method `Withdraw(decimal amount)` that decreases the balance (if sufficient funds).

---

### Assignment 2: Create a Derived Class for SavingsAccount

**Objective:** Understand how to create derived classes.

**Instructions:**
- Create a class `SavingsAccount` that inherits from `BankAccount`.
- Add an `InterestRate` property (decimal, get/set).
- Add a method `ApplyInterest()` that increases the balance based on the interest rate.

---

### Assignment 3: Create a Derived Class for CheckingAccount

**Objective:** Learn how to override methods.

**Instructions:**
- Create a class `CheckingAccount` that inherits from `BankAccount`.
- Add a `TransactionFee` property.
- Override the `Withdraw(decimal amount)` method to deduct the fee every time a withdrawal is made.

---

### Assignment 4: Polymorphism in Action

**Objective:** Use base class references to access derived class objects.

**Instructions:**
- In `Main`, create a list of `BankAccount` type.
- Add instances of `SavingsAccount` and `CheckingAccount` to the list.
- Loop through the list and call `Deposit()` and `Withdraw()` on each account.
- Use type casting to access `SavingsAccount.ApplyInterest()`.

---

### Assignment 5: Abstract Base Class with Template Method

**Objective:** Explore abstract classes and the Template Method pattern.

**Instructions:**
- Convert `BankAccount` into an abstract class.
- Make `Withdraw` an abstract method.
- Let `SavingsAccount` and `CheckingAccount` implement their own versions.
- Ensure `Deposit()` is implemented in base class.

---

### Submission
Submit the following:
- Your `.cs` file(s) with complete working solutions.
- Screenshots or output demonstrating the execution of your code.

---

### Bonus (Optional): Advanced Inheritance
- Add a `BusinessAccount` class that supports overdraft.
- Add interface `ITransferable` for transferring funds between accounts.

---

Happy Coding! 🚀

