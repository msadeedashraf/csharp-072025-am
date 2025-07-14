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

