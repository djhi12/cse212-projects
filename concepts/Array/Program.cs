using System;

public class Program
{
    static void Main(string[] args)
    {
        // CREATING A DYNAMIC ARRAY OF INTEGERS
        Console.WriteLine("\nCREATING A DYNAMIC ARRAY OF INTEGERS");
        List<int> dynamicArrayInt = new List<int>();

        // Adding elements to the dynamic array
        dynamicArrayInt.Add(10);
        dynamicArrayInt.Add(20);
        dynamicArrayInt.Add(30);

        // Accessing elements of the dynamic array
        Console.WriteLine("Elements of the dynamic array:");

        foreach (int num in dynamicArrayInt)
        {
            Console.WriteLine(num);
        }

        // Removing an element from the dynamic array
        dynamicArrayInt.Remove(20);

        // Accessing elements after removal
        Console.WriteLine("\nElements after removing 20:");

        foreach (int num in dynamicArrayInt)
        {
            Console.WriteLine(num);
        }


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


        // ARRAY INSERT
        Console.WriteLine("\nCREATING A DYNAMIC ARRAY OF INSERT");

    }
}
