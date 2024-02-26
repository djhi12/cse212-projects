using System;

public class Arrays
{
    static void Main(string[] args)
    {
        // Create a dynamic array using List<T>
        List<int> numbers = new List<int>();

        // Add elements to the dynamic array
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        // Access and modify elements in the dynamic array
        Console.WriteLine("Elements in the dynamic array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Add more elements
        numbers.Add(4);
        numbers.Add(5);

        // Remove an element
        numbers.Remove(2);

        // Access and display the modified dynamic array
        Console.WriteLine("Modified elements in the dynamic array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
