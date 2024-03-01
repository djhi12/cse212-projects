﻿using System;


namespace Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n======================\nSorting\n======================");
            Sorting.Run();

            Console.WriteLine("\n======================\nStandardDeviation\n======================");
            StandardDeviation.Run();

            Console.WriteLine("\n======================\nSearch\n======================");
            Search.Run();
        }
    }
}