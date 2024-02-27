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

    }
}
