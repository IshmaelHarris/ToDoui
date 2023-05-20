using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        TodoList todoList = new TodoList();

        while (true)
        {
            Console.WriteLine("---");
            todoList.Display();
          // make it say "Begin Your Journey" before there are any tasks and disappears after
            Console.WriteLine("---");

            Console.WriteLine("/a - Add task");
            Console.WriteLine("/r - Remove task");
            Console.WriteLine("/f - Finish task");
            Console.WriteLine("/u - Undo finish");
            Console.WriteLine("/e - Edit task");
            Console.WriteLine("/d - Display task");
            Console.WriteLine("/q - Quit program");

            string input = Console.ReadLine();

            switch (input)
            {
                case "/a":
                    Console.WriteLine("Enter the description of the new item:");
                    string description = Console.ReadLine();
                    todoList.Add(description);
                    break;
                case "/r":
                    Console.WriteLine("Enter the number of the item to remove:");
                    int indexToRemove = int.Parse(Console.ReadLine()) - 1;
                    todoList.Remove(indexToRemove);
                    break;
                case "/f":
                    Console.WriteLine("Enter the number of the item to mark as completed:");
                    int indexToFinish = int.Parse(Console.ReadLine()) - 1;
                    todoList.Finish(indexToFinish);
                    break;
                case "/u":
                    Console.WriteLine("Enter the number of the item to mark as not completed:");
                    int indexToUndo = int.Parse(Console.ReadLine()) - 1;
                    todoList.Undo(indexToUndo);
                    break;
                case "/e":
                    Console.WriteLine("Enter the number of the item to edit:");
                    int indexToEdit = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Enter the new description:");
                    string newDescription = Console.ReadLine();
                    todoList.Edit(indexToEdit, newDescription);
                    break;
                case "/d":
                    todoList.Display();
                    break;
                case "/q":
                    return;
            }
        }
    }
}