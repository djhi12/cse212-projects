using System;

class Program
{
    static void Main()
    {
        int n = 10;
        Console.WriteLine($"Fibonacci sequence up to {n}:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}


