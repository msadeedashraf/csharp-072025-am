# 🚗 C# OOP Practice Assignments – Classes, Properties, Constructors, and Methods

These assignments reinforce students’ understanding of:
- Classes and Objects
- Constructors
- Properties (get, set, init, private set)
- Methods inside classes
- Working with real-world object-oriented models

---

## 🏎️ Assignment 1: Car Showroom Manager

### Objective
Create a `Car` class that models real-world car details and actions.

### Class Structure

```csharp
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; }
    public int Speed { get; private set; }
    public string Color { get; set; }

    public Car(string make, string model, int year, string color, int speed)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
        Speed = speed;
    }

    public void Accelerate(int increment)
    {
        Speed += increment;
    }

    public void Brake(int decrement)
    {
        Speed -= decrement;
        if (Speed < 0) Speed = 0;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"{Make} {Model} ({Year}), Color: {Color}, Speed: {Speed} km/h");
    }
}
```

### Tasks
1. Create 2–3 car objects.
2. Accelerate and brake each car.
3. Print details after each action using `PrintDetails()`.

---

## 👨‍🎓 Assignment 2: Student Grade Tracker

### Objective
Simulate a report card using a class and grade calculation logic.

### Class Structure

```csharp
class Student
{
    public string Name { get; set; }
    public int Subject1 { get; set; }
    public int Subject2 { get; set; }
    public int Subject3 { get; set; }

    public Student(string name, int s1, int s2, int s3)
    {
        Name = name;
        Subject1 = s1;
        Subject2 = s2;
        Subject3 = s3;
    }

    public double CalculateAverage()
    {
        return (Subject1 + Subject2 + Subject3) / 3.0;
    }

    public string GetGrade()
    {
        double avg = CalculateAverage();
        if (avg >= 85) return "A";
        else if (avg >= 70) return "B";
        else if (avg >= 50) return "C";
        else return "F";
    }

    public void PrintReport()
    {
        Console.WriteLine($"{Name} - Average: {CalculateAverage()}, Grade: {GetGrade()}");
    }
}
```

### Tasks
1. Create at least 2 student objects.
2. Use `PrintReport()` to show their average and grade.

---

## 📚 Assignment 3: Library Book Tracker

### Objective
Create a class to manage the borrowing and returning of books.

### Class Structure

```csharp
class LibraryBook
{
    public string Title { get; }
    public string Author { get; }
    private bool IsAvailable;

    public LibraryBook(string title, string author)
    {
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Title} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"{Title} is not available.");
        }
    }

    public void ReturnBook()
    {
        IsAvailable = true;
        Console.WriteLine($"{Title} has been returned.");
    }

    public void GetStatus()
    {
        string status = IsAvailable ? "Available" : "Not Available";
        Console.WriteLine($"{Title} by {Author} is {status}.");
    }
}
```

### Tasks
1. Create 2–3 book objects.
2. Simulate borrowing and returning.
3. Call `GetStatus()` to check availability.

---

## 🔁 Bonus Challenges (Optional)

- Use a list to store multiple objects (cars, students, or books).
- Create a static counter in each class to track total created objects.
- Override `ToString()` in each class to simplify printing details.
- Create a simple CLI menu to interact with the objects.

---
