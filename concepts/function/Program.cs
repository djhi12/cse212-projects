using System;

public class Program
{
    static void Main(string[] args)
    {

        // Call the function and store the result
        int result = AddNumbers(5, 3);

        // Print the resul
        Console.WriteLine("The result is: " + result);
    }

    // Function to add two numbers and return the result
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}
