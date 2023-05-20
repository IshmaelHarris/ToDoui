using System;

class Program
{
    public static void Main(string[] args)
    {
        TodoList todoList = new TodoList();

        while (true)

        {
            Console.WriteLine("---");
            todoList.DisplayItems();
            Console.WriteLine("---");

            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. Mark item as completed");
            Console.WriteLine("4. Mark item as not completed");
            Console.WriteLine("5. Edit item description");
            Console.WriteLine("6. Display items");
            Console.WriteLine("7. Quit");

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
                    Console.WriteLine("Enter the index of the item to mark as not completed:");
                    int indexToMarkAsNotCompleted = int.Parse(Console.ReadLine()) - 1;
                    todoList.MarkItemAsNotCompleted(indexToMarkAsNotCompleted);

                    break;
                case "5":
                    Console.WriteLine("Enter the index of the item to edit:");
                    int indexToEdit = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Enter the new description for the item:");
                    string newDescription = Console.ReadLine();
                    todoList.EditItemDescription(indexToEdit, newDescription);

                    break;
                case "6":

                    break;
                case "7":
                    return;
            }
        }
    }
}