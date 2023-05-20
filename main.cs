using System;

class Program
{
    public static void Main(string[] args)
{
    TodoList todoList = new TodoList();

    while (true)
    {
        Console.WriteLine("1. Add item");
        Console.WriteLine("2. Remove item");
        Console.WriteLine("3. Mark item as completed");
        Console.WriteLine("4. Display items");
        Console.WriteLine("5. Quit");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.WriteLine("Enter the description of the new item:");
                string description = Console.ReadLine();
                todoList.AddItem(description);
                break;
            case "2":
                Console.WriteLine("Enter the index of the item to remove:");
                int indexToRemove = int.Parse(Console.ReadLine()) - 1;
                todoList.RemoveItem(indexToRemove);
                break;
            case "3":
                Console.WriteLine("Enter the index of the item to mark as completed:");
                int indexToMarkAsCompleted = int.Parse(Console.ReadLine()) - 1;
                todoList.MarkItemAsCompleted(indexToMarkAsCompleted);
                break;
            case "4":
                todoList.DisplayItems();
                break;
            case "5":
                return;
        }
    }
}
}