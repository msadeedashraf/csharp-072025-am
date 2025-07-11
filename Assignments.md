# 🚀 Basic C# Projects for Practicing Fundamentals

---

## 🔥 Assignment 1: Simple Grade Calculator

### ✅ Concepts Covered

- Variables, data types
- Conditional logic (`if-else`)
- `switch` statement
- Ternary operator

### 💡 Description

Write a console application that:

- Takes user input for a student’s marks (0-100).
- Calculates the letter grade based on the marks.
- Uses `switch` to print motivational messages.
- Uses a ternary operator to indicate pass/fail (>50).

### 🎯 Requirements

- Prompt user: `Enter marks (0-100): `
- Determine grade:
  - `A` for `90-100`
  - `B` for `80-89`
  - `C` for `70-79`
  - `D` for `60-69`
  - `E` for `50-59`
  - `F` for `<50`
- Use `switch` on the grade character to print messages:
  - `A` -> "Excellent work!"
  - `B` -> "Great job!"
  - `C` -> "Good effort."
  - `D` -> "Keep trying."
  - `E` -> "Pass, but needs improvement."
  - `F` -> "Fail. Better luck next time."
- Use ternary operator to print: `Pass` or `Fail`.

---

## 🚀 Assignment 2: Number Analyzer

### ✅ Concepts Covered

- Variables, types
- Loops (`for` or `while`)
- Conditional logic (`if-else`)
- Modulus operator `%`
- Nested conditionals

### 💡 Description

Create a console program that:

- Asks the user how many numbers they want to enter.
- Takes that many numbers in a loop.
- For each number, prints whether it is:
  - Even or odd.
  - Positive, negative, or zero.

### 🎯 Example Interaction

```
How many numbers will you enter? 3
Enter number 1: -5
-5 is Odd and Negative
Enter number 2: 0
0 is Even and Zero
Enter number 3: 12
12 is Even and Positive
```

---

## 💫 Assignment 3: Simple ATM Simulator

### ✅ Concepts Covered

- Variables, data types
- Loops (`do-while` or `while`)
- `switch` statement
- `if-else` for input validation
- Ternary operator

### 💡 Description

Simulate a basic ATM system:

- Starts with an initial balance (e.g., `$1000`).
- Repeats a menu until user chooses to exit.

### 🎯 Menu Options

```
1. Check Balance
2. Deposit
3. Withdraw
4. Exit
```

- Use `switch` to handle each option.
- Ensure:
  - No negative deposits.
  - Withdrawal does not exceed balance.
- Use ternary operator for withdrawal:
  - Print "Withdrawal successful" or "Insufficient funds".

### 📝 Sample Flow

```
Your balance is: $1000
Choose option:
1. Check Balance
2. Deposit
3. Withdraw
4. Exit
> 2
Enter amount to deposit: 200
Deposit successful. New balance: $1200
```

---

## ✅ Summary Table

| Project          | Core Concepts Practiced                                   |
| ---------------- | --------------------------------------------------------- |
| Grade Calculator | `if-else`, `switch`, `ternary`, variables, input, types   |
| Number Analyzer  | loops, `if-else`, modulus, nested conditionals, variables |
| ATM Simulator    | loops, `switch`, `if-else`, `ternary`, input validation   |

---



