# 🎓 C# Enum Example: Role-Based Access Control

## ✅ Use Case: User Role Management in a Company System

In many real-world applications, users are assigned different roles such as **Admin**, **Manager**, **Employee**, or **Guest**. These roles determine access rights to various parts of the system.

Using an `enum` in C# is a clean, type-safe, and maintainable way to manage these user roles.

---

## 📌 Step 1: Define the Enum

```csharp
public enum UserRole
{
    Guest,
    Employee,
    Manager,
    Admin
}
```

---

## 📌 Step 2: Create the User Class Using the Enum

```csharp
public class User
{
    public string Name { get; set; }
    public UserRole Role { get; set; }

    public void AccessDashboard()
    {
        switch (Role)
        {
            case UserRole.Admin:
                Console.WriteLine("Access to admin dashboard granted.");
                break;
            case UserRole.Manager:
                Console.WriteLine("Access to manager dashboard granted.");
                break;
            case UserRole.Employee:
                Console.WriteLine("Access to employee dashboard granted.");
                break;
            case UserRole.Guest:
                Console.WriteLine("Limited access. Upgrade your role to get more features.");
                break;
        }
    }

    public bool CanEditUsers()
    {
        return Role == UserRole.Admin || Role == UserRole.Manager;
    }
}
```

---

## 📌 Step 3: Using the User Class

```csharp
class Program
{
    static void Main(string[] args)
    {
        var user1 = new User { Name = "John", Role = UserRole.Employee };
        var user2 = new User { Name = "Sara", Role = UserRole.Admin };

        user1.AccessDashboard();
        user2.AccessDashboard();

        Console.WriteLine($"{user1.Name} can edit users? {user1.CanEditUsers()}");
        Console.WriteLine($"{user2.Name} can edit users? {user2.CanEditUsers()}");
    }
}
```

---

## ✅ Benefits of Using Enum

- ✅ **Clarity**: Easy to read and understand.
- ✅ **Type Safety**: Prevents typos and invalid values.
- ✅ **Maintainability**: Adding new roles is straightforward.
- ✅ **Scalability**: Works great with large-scale RBAC systems.

---

## 🧠 Summary

Enums provide a simple and powerful way to handle constant sets of values. In this example, we've used them to manage user roles in an access control system—an essential pattern in many business and enterprise applications.
