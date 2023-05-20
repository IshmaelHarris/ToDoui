using System;
using System.Collections.Generic;

public class TodoList
{
    private List<TodoItem> items;

    public TodoList()
    {
        items = new List<TodoItem>();
    }

    public void AddItem(string description)
    {
        items.Add(new TodoItem(description));
    }

    public void RemoveItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items.RemoveAt(index);
        }
    }

    public void MarkItemAsCompleted(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index].IsCompleted = true;
        }
    }

    public void MarkItemAsNotCompleted(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index].IsCompleted = false;
        }
    }

    public void EditItemDescription(int index, string newDescription)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index].Description = newDescription;
        }
    }

    public void DisplayItems()
    {
        for (int i = 0; i < items.Count; i++)
        {
            string status = items[i].IsCompleted ? "Completed" : "Not Completed";
            Console.WriteLine($"{i + 1}. {items[i].Description} - {status}");
        }
        // Console.WriteLine("---");
    }
}
