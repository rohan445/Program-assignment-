//Section F 
// Todo list mini project 


using System;

class Program
{
    static void Main()
    {
        todolist();
    }
    static void todolist()
    {
        string[] tasks = new string[100]; // fixed size
        int count = 0;

        while (true)
        {
            Console.WriteLine("\n1. Add Task\n2. View Tasks\n3. Remove Task\n4. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Add
                    if (count < tasks.Length)
                    {
                        Console.Write("Enter task: ");
                        tasks[count] = Console.ReadLine();
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Task list is full!");
                    }
                    break;

                case "2": // View
                    if (count == 0)
                    {
                        Console.WriteLine("No tasks available.");
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        }
                    }
                    break;

                case "3": // Remove
                    Console.Write("Enter task number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    if (index >= 0 && index < count)
                    {
                        // Shift elements left
                        for (int i = index; i < count - 1; i++)
                        {
                            tasks[i] = tasks[i + 1];
                        }

                        tasks[count - 1] = null;
                        count--;

                        Console.WriteLine("Task removed.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}