using System;

namespace OOP_Assignments
{
    // ---------------- Assignment 1 ----------------
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
            Console.WriteLine($"{Make} {Model} ({Year}) - Color: {Color}, Speed: {Speed} km/h");
        }
    }

    // ---------------- Assignment 2 ----------------
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
            Console.WriteLine($"{Name} - Average: {CalculateAverage():0.0}, Grade: {GetGrade()}");
        }
    }

    // ---------------- Assignment 3 ----------------
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
                Console.WriteLine($"✅ {Title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"❌ {Title} is not available.");
            }
        }

        public void ReturnBook()
        {
            IsAvailable = true;
            Console.WriteLine($"🔁 {Title} has been returned.");
        }

        public void GetStatus()
        {
            string status = IsAvailable ? "Available ✅" : "Not Available ❌";
            Console.WriteLine($"📚 {Title} by {Author} is {status}");
        }
    }

    // ---------------- Main Method ----------------
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------ Assignment 1: Car Showroom ------
            Console.WriteLine("=== Car Showroom ===");
            Car car1 = new Car("Toyota", "Camry", 2022, "Black", 120);
            Car car2 = new Car("Honda", "Civic", 2023, "Blue", 100);

            car1.Accelerate(20);
            car2.Brake(30);

            car1.PrintDetails();
            car2.PrintDetails();

            Console.WriteLine();

            // ------ Assignment 2: Student Report ------
            Console.WriteLine("=== Student Report ===");
            Student student1 = new Student("Ali", 90, 85, 95);
            Student student2 = new Student("Sara", 60, 75, 70);

            student1.PrintReport();
            student2.PrintReport();

            Console.WriteLine();

            // ------ Assignment 3: Library Books ------
            Console.WriteLine("=== Library Books ===");
            LibraryBook book1 = new LibraryBook("The Alchemist", "Paulo Coelho");
            LibraryBook book2 = new LibraryBook("Atomic Habits", "James Clear");

            book1.GetStatus();
            book1.BorrowBook();
            book1.GetStatus();
            book1.ReturnBook();
            book1.GetStatus();

            Console.WriteLine();

            book2.GetStatus();
            book2.BorrowBook();
            book2.BorrowBook(); // Trying again
        }
    }
}
