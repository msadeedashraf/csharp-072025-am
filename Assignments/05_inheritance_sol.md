# Inheritance Assignment – Solutions and Explanation

## 1. Bank Account System

```csharp
class BankAccount
{
    public string AccountNumber;
    public double Balance;

    public virtual void Deposit(double amount) { Balance += amount; }
    public virtual void Withdraw(double amount) { Balance -= amount; }
}

class SavingsAccount : BankAccount
{
    public double InterestRate = 0.03;
    public double CalculateInterest() => Balance * InterestRate;
}

class CheckingAccount : BankAccount
{
    public double OverdraftLimit = 500;
    public override void Withdraw(double amount)
    {
        if (Balance + OverdraftLimit >= amount)
            Balance -= amount;
    }
}
```

**Why Inheritance?**  
`SavingsAccount` and `CheckingAccount` are both types of `BankAccount`, sharing deposit and withdraw methods. Inheritance avoids code duplication and provides flexibility for specialized behavior.

---

## 2. Educational Institution Staff

```csharp
class Staff
{
    public string Name;
    public int ID;
    public virtual void ShowRole() => Console.WriteLine("General staff");
}

class Teacher : Staff
{
    public string Subject;
    public override void ShowRole() => Console.WriteLine("Teaches subject: " + Subject);
}

class Administrator : Staff
{
    public override void ShowRole() => Console.WriteLine("Manages school");
}

class Janitor : Staff
{
    public override void ShowRole() => Console.WriteLine("Maintains cleanliness");
}
```

**Why Inheritance?**  
All types of staff have common fields like Name and ID, so base class `Staff` makes structure consistent and manageable.

---

## 3. Vehicle Management

```csharp
class Vehicle
{
    public string Make;
    public string Model;
    public int Year;
}

class Car : Vehicle
{
    public int NumberOfDoors;
}

class Truck : Vehicle
{
    public double CargoCapacity;
}

class Motorcycle : Vehicle
{
    public int NumberOfWheels = 2;
}
```

**Why Inheritance?**  
All vehicles share common properties, so defining once in `Vehicle` saves code and helps create a polymorphic structure.

---

## 4. Online Store System

```csharp
class Product
{
    public string Name;
    public double Price;
}

class Book : Product
{
    public string Author;
}

class Electronics : Product
{
    public string Brand;
}

class Clothing : Product
{
    public string Size;
}
```

**Why Inheritance?**  
`Book`, `Electronics`, and `Clothing` are all products. Inheritance helps generalize the store catalog and allows handling of all products polymorphically.

---

## 5. Hospital Management System

```csharp
class Person
{
    public string Name;
    public int ID;
}

class Doctor : Person
{
    public string Specialty;
}

class Nurse : Person
{
    public string Department;
}

class Patient : Person
{
    public string Diagnosis;
}
```

**Why Inheritance?**  
Doctors, nurses, and patients are all people and share attributes like name and ID. Inheritance ensures reusability and cleaner code.