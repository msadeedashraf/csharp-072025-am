1. Create a 4 function Calculator ![link](/Assets/Four-Function-Calculator.png)
2. Create a Program that can help you deposit/withdraw the amount from a Account Balance ![link](/Assets/Bank-Acount-Deposit-Withdrawal.png)
3. Convert the user temperature from C to F and F to C;
4. int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");


5. Create a class called LibraryBook that represents a book in a library system. The class should have the following properties and methods:

Properties:

Title (string): The title of the book.
Author (string): The author of the book.
ISBN (string): The ISBN of the book.
IsCheckedOut (bool): Tracks whether the book is currently checked out.
Constructor: Create a constructor that initializes the title, author, and ISBN. By default, set IsCheckedOut to false.

Methods:

CheckOut(): If the book is not already checked out, set IsCheckedOut to true and display a message indicating the book has been checked out. If the book is already checked out, display a message stating it is not available.
ReturnBook(): If the book is currently checked out, set IsCheckedOut to false and display a message indicating the book has been returned. If the book is already in the library, display a message stating it is already available.
DisplayBookInfo(): Print the book information, including title, author, ISBN, and whether it is currently available.
Usage Example:

Create an instance of LibraryBook in a Main method with a sample title, author, and ISBN.
Call DisplayBookInfo() to display the book details.
Call CheckOut() and ReturnBook() to test the book's **status** and re-display the information.

Requirements:
1. Implement the LibraryBook class with the required properties, constructor, and methods.
2. Ensure that the CheckOut and ReturnBook methods update the IsCheckedOut status correctly.
3. Test your program by creating a sample book in the Main method and performing a sequence of actions.

Extra Challenge: Add validation in the CheckOut and ReturnBook methods to ensure a book cannot be checked out or returned if it is in an inappropriate state.

6. Final Projects [link](https://www.codewithfaraz.com/csharp-projects?page=1).
   >Check the projects on the following [link](https://www.codewithfaraz.com/csharp-projects?page=1) and pick any two project and create them.
   >You can also pick any other project and get is assigned for submission.


7. Book Page 300. In the following exercise, you’ll define a simple class hierarchy for modeling different types of vehicles. You’ll define a base class named Vehicle and derived classes named Airplane and Car. You will define common methods named StartEngine and StopEngine in the Vehicle class, and you’ll add some methods to both of the derived classes that are specific to those classes. Finally, you’ll add a virtual method named Drive to the Vehicle class and override the default implementation of this method in both of the derived classes.