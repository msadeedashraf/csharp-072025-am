// See https://aka.ms/new-console-template for more information
List<string> tasks = new List<string>();

bool running = true;

while (running)
{
    Console.WriteLine("\n--- To-Do List Menu ---");
    Console.WriteLine("1. Add a new task");
    Console.WriteLine("2. Remove a task");
    Console.WriteLine("3. View all tasks");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter new task");
            string newTask = Console.ReadLine();
            tasks.Add(newTask);
            Console.WriteLine("Task added successfully.");
            break;
        case "2":
            Console.WriteLine("Enter the task to be removed");
            string removeTask = Console.ReadLine();
            if (tasks.Remove(removeTask))
                Console.WriteLine("Task removed");
            else
                Console.WriteLine("Task not Found");
            break;
        case "3":
            Console.WriteLine("\n Your Tasks:");
            foreach (var task in tasks)
                Console.WriteLine($"\n {task}");

            if (tasks.Count == 0)
                Console.WriteLine("No tasks yet");
            break;
        case "4":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid Option. Try again");
            break;


    }



}

Console.WriteLine("Goodbye!");

