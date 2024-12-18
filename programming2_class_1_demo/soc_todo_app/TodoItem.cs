using System;

namespace soc_todo_app;

// This class is only concerned with modelling the todo item
public class TodoItem
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public TodoItem(string description)
    {
        Description = description;
        IsCompleted = false;
    }

    public void MarkComplete()
    {
        IsCompleted = true;
    }

    public override string ToString()
    {
        return $"{Description} - {(IsCompleted ? "Completed" : "Pending")}";
    }
}
