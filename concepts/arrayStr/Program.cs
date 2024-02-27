using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {

        // CREATING A DYNAMIC ARRAY OF STRINGS
        Console.WriteLine("\nCREATING A DYNAMIC ARRAY OF STRINGS");
        List<string> dynamicArrayStr = new List<string>();

        // Adding elements to the dynamic array
        dynamicArrayStr.Add("Hello");
        dynamicArrayStr.Add("World");
        dynamicArrayStr.Add("!");

        // Insert another string
        int indexNum = 0;
        string elementToInsert = "Bye";

        // 
        dynamicArrayStr.Insert(indexNum, elementToInsert);

        // Accessing elements of the dynamic array
        Console.WriteLine("Elements of the dynamic array:");

        foreach (string str in dynamicArrayStr)
        {
            Console.WriteLine(str);
        }

        // Removing an element from the dynamic array
        dynamicArrayStr.Remove("World");

        // Accessing elements after removal
        Console.WriteLine("\nElements after removing 'World':");
        foreach (string str in dynamicArrayStr)
        {
            Console.WriteLine(str);
        }

        // Call the FindBob method and print the result
        Console.WriteLine("Is 'Bob' found in the list? " + FindBob(dynamicArrayStr) + "\n");
    }

    // Define FindBob as a separate method outside Main
    static bool FindBob(List<string> dynamicArrayStr)
    {
        foreach (var name in dynamicArrayStr)
        {
            if (name == "Bob")
            {
                return true;
            }
        }

        return false;
    }
}
