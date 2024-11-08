using System;

namespace soc_todo_app;

public class TodoList
{
    private TodoItem[] items = new TodoItem[100];
    private int count = 0;

    public void AddItem(string description)
    {
        // items.Add(new TodoItem(description));
        items[count] = new TodoItem(description);
        count++;
    }

    public void MarkItemComplete(int index)
    {
        if (index >= 0 && index < count)
        {
            items[index].MarkComplete();
        }
        else
        {
            Console.WriteLine("Invalid item index.");
        }
    }

    public TodoItem[] GetAllItems()
    {
        TodoItem[] returnItems = new TodoItem[count];
        for (int i = 0; i < count; i++)
        {
            returnItems[i] = items[i];
        }
        return returnItems;
    }

}
