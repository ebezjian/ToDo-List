using ToDoList.Models;
using System;
using System.Collections.Generic;

public class Program
{ 
  public static void Main()
  {
    Console.WriteLine("Welcome to the To Do List.");
    Console.WriteLine("Would you like to add a task to your list or view your list?(Add/View/End)");
    string answer = Console.ReadLine();
    if (answer == "Add" || answer == "add")
    {
      AddListItem();

    }
    else if (answer == "view")
    {
        ShowList();
    }
    else 
    {
        Console.WriteLine("ByEEE");
    }
  }

  
  static void AddListItem()
  {
    Console.WriteLine("NEW LIST ITEM");
    Console.WriteLine("Describe your task!");
    string description = Console.ReadLine();
    Item newTask = new Item (description);
    Console.WriteLine("Would you like to add a task to your list or view your list?(Add/View)");
    string answer = Console.ReadLine();
    if (answer == "Add" || answer == "add")
    {
      AddListItem();

    }
    else if (answer == "view")
    {
        ShowList();
    }
    
  }
  static void ShowList()
  {
    List<Item> newList = Item.GetAll();
    foreach (Item item in newList)
    {
      Console.WriteLine(item.Description);
    }
    Console.WriteLine("Would you like to add a task to your list or view your list?(Add/View)");
    string answer = Console.ReadLine();
    if (answer == "Add" || answer == "add")
    {
      AddListItem();

    }
    else if (answer == "view")
    {
        ShowList();
    }
  }  
}