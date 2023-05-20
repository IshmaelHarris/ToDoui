
using System;
using System.Collections.Generic;

public class TodoList
{
    private List<TodoItem> items = new List<TodoItem>();

    public void Add(string description)
    {
        TodoItem item = new TodoItem(description);
        items.Add(item);
    }

    public void Remove(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items.RemoveAt(index);
        }
    }

    public void Finish(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index].IsCompleted = true;
        }
    }

    public void Undo(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index].IsCompleted = false;
        }
    }

    public void Edit(int index, string newDescription)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index].Description = newDescription;
        }
    }

    public void Display()
    {
        for (int i = 0; i < items.Count; i++)
        {
            string status = items[i].IsCompleted ? "Completed" : "Not Completed";
            Console.WriteLine($"{i + 1}. {items[i].Description} - {status}");
        }
    }
}