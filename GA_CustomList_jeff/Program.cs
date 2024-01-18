
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Custom List Class Example");

        // Test CustomList
        CustomList<string> myList = new CustomList<string>();
        myList.Add("Hello");
        myList.AddAtIndex("World", 1);

        // More tests for adding, removing, and retrieving items
        myList.Add("!");
        myList.AddAtIndex("C#", 1);

        Console.WriteLine($"Count: {myList.Count}");
        Console.WriteLine($"Item at index 2: {myList.GetItem(2)}");

        myList.Remove("World");

        Console.WriteLine($"Count after removal: {myList.Count}");

        Console.ReadLine(); // Keep console window open
    }
}
