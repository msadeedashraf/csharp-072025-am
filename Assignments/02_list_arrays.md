# C# Arrays and Lists - Practical Assignments

## 🌱 Practical Example

### Fruit Shop Inventory

Imagine you are building a small app for a fruit shop. You need to store and process the inventory.

- Use an **array** to store a *fixed set of fruits* (names).
- Use a **list** to track *incoming fruit orders* (which can grow/shrink).

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Array: fixed fruits available in shop
        string[] fruits = { "Apple", "Banana", "Orange", "Mango" };
        Console.WriteLine("Available fruits:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"- {fruit}");
        }

        // List: incoming orders
        List<string> orders = new List<string>();

        // Simulate adding orders
        orders.Add("Apple");
        orders.Add("Mango");
        orders.Add("Banana");

        Console.WriteLine("\nCustomer orders:");
        foreach (var order in orders)
        {
            Console.WriteLine($"- {order}");
        }

        // Remove an order (customer changed mind)
        orders.Remove("Banana");

        Console.WriteLine("\nUpdated orders after removal:");
        foreach (var order in orders)
        {
            Console.WriteLine($"- {order}");
        }

        // Count orders
        Console.WriteLine($"\nTotal orders: {orders.Count}");
    }
}
```

---

## ✍️ Assignment 1: Student Grades with Arrays

### Instructions
- Ask user how many students are in the class.
- Use an **array** to store each student’s grade (integer between 0-100).
- Calculate and print:
  - The average grade.
  - The highest and lowest grade.
- Print all grades.

### Concepts Practiced
- Declaring arrays
- Reading input
- Iterating over arrays
- Finding min, max, average

---

## ✍️ Assignment 2: To-Do List Manager with Lists

### Instructions
- Build a console-based to-do list app using a **List<string>**.
- Show a menu:
  ```
  1. Add a new task
  2. Remove a task
  3. View all tasks
  4. Exit
  ```
- Keep running until user chooses to exit.
- When adding, append to list.
- When removing, let user enter the task name to remove.

## 🚀 Extra Challenges

### 🔥 Challenge 1: Grocery Price Calculator with Arrays
- Create a program that:
  - Stores the names of grocery items in a string array.
  - Stores their prices in a parallel double array.
  - Prints each item with its price.
  - Calculates and prints the total bill.
- Example output:
  ```
  Milk: $2.50
  Bread: $1.80
  Eggs: $3.20
  Total: $7.50
  ```

### 🔥 Challenge 2: Classroom Attendance with Lists
- Write a console app to track attendance.
- Use a `List<string>` to store student names as they enter.
- Each time the program runs, let the teacher type a student name.
- If the teacher types "done", stop input and print all names present.
- Example session:
  ```
  Enter student name (or 'done' to finish): Alice
  Enter student name (or 'done' to finish): Bob
  Enter student name (or 'done' to finish): done

  Students present today:
  - Alice
  - Bob
  ```

✅ You can extend these challenges by adding sorting, duplicate checks, or writing the data to a file.
