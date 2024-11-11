using System;

namespace soc_todo_app;

// This class is responsible for the user interface (UI) concern
// No handling of data or persistence is present in this class
public class TodoUI
{
    private TodoList toDoList = new TodoList();

    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\nTo-Do Application:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task Complete");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    MarkTaskComplete();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    private void AddTask()
    {
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();
        toDoList.AddItem(description);
        Console.WriteLine("Task added.");
    }

    private void ViewTasks()
    {
        Console.WriteLine("\nTo-Do List:");
        var items = toDoList.GetAllItems();
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
    }

    private void MarkTaskComplete()
    {
        ViewTasks();
        Console.Write("Enter task number to mark as complete: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            toDoList.MarkItemComplete(index - 1);
            Console.WriteLine("Task marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
