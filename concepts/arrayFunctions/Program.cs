using System;

namespace arrayFunctions
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Length: Gets the total number of elements in the array.
            int[] numbers = { 1, 2, 3, 4, 5 };
            int length = numbers.Length; // length will be 5

            Console.WriteLine(length);

            // Clone: Creates a shallow copy of the array.
            int[] numbersClone = { 1, 2, 3, 4, 5 };
            int[] copy = (int[])numbersClone.Clone();

            foreach (var item in copy)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // CopyTo: Copies the elements of one array to another array.
            int[] source = { 1, 2, 3, 4, 5 };
            int[] destination = new int[5];
            source.CopyTo(destination, 0);

            foreach (var item in destination)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Sort: Sorts the elements of the array.
            int[] numbersSort = { 5, 3, 1, 4, 2 };
            Array.Sort(numbersSort); // numbersSort will be sorted in ascending order

            foreach (var item in numbersSort)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // IndexOf: Searches for the specified object and returns the index of the first occurrence within the entire array.
            int[] numbersIndexOf = { 1, 2, 3, 4, 5 };
            int index = Array.IndexOf(numbersIndexOf, 3); // index will be 2

            Console.WriteLine(index);

            // Reverse: Reverses the order of the elements in the entire one-dimensional array.
            int[] numbersReverse = { 1, 2, 3, 4, 5 };
            Array.Reverse(numbersReverse); // numbersReverse will be { 5, 4, 3, 2, 1 }

            foreach (var item in numbersReverse)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Clear: Sets a range of elements in the array to zero, false, or null, depending on the element type.
            int[] numbersClear = { 1, 2, 3, 4, 5 };
            Array.Clear(numbersClear, 0, numbersClear.Length); // Clears the entire array

            foreach (var item in numbersClear)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
