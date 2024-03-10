// public static class Priority {
//     public static void Test() {
//         // TODO Problem 2 - Write and run test cases and fix the code to match requirements
//         // Example of creating and using the priority queue
//         var priorityQueue = new PriorityQueue();
//         Console.WriteLine(priorityQueue);

//         // Test Cases

//         // Test 1
//         // Scenario: 
//         // Expected Result: 
//         Console.WriteLine("Test 1");

//         // Defect(s) Found: 

//         Console.WriteLine("---------");

//         // Test 2
//         // Scenario: 
//         // Expected Result: 
//         Console.WriteLine("Test 2");

//         // Defect(s) Found: 

//         Console.WriteLine("---------");

//         // Add more Test Cases As Needed Below
//     }
// }

using System;

public static class Priority
{
    public static void Test()
    {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine("Initial queue: " + priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add items to the queue and dequeue them.
        // Expected Result: The items are dequeued in the correct order.
        priorityQueue.Enqueue("Item 1", 3);
        priorityQueue.Enqueue("Item 2", 1);
        priorityQueue.Enqueue("Item 3", 2);
        Console.WriteLine("Test 1:");
        Console.WriteLine("Expected: Item 2 (Pri:1)");
        Console.WriteLine("Actual: " + priorityQueue.Dequeue());
        Console.WriteLine("Expected: Item 3 (Pri:2)");
        Console.WriteLine("Actual: " + priorityQueue.Dequeue());
        Console.WriteLine("Expected: Item 1 (Pri:3)");
        Console.WriteLine("Actual: " + priorityQueue.Dequeue());
        Console.WriteLine("Queue after dequeue: " + priorityQueue);
        Console.WriteLine("---------");

        // Test 2
        // Scenario: Try to dequeue from an empty queue.
        // Expected Result: An error message should be displayed.
        Console.WriteLine("Test 2:");
        Console.WriteLine("Expected: An error message for empty queue");
        Console.WriteLine("Actual: " + priorityQueue.Dequeue());
        Console.WriteLine("---------");

        // Test 3
        // Scenario: Add multiple items with the same high priority.
        // Expected Result: The item closest to the front of the queue should be dequeued first.
        priorityQueue.Enqueue("Item 4", 2);
        priorityQueue.Enqueue("Item 5", 2);
        Console.WriteLine("Test 3:");
        Console.WriteLine("Expected: Item 4 (Pri:2)");
        Console.WriteLine("Actual: " + priorityQueue.Dequeue());
        Console.WriteLine("Expected: Item 5 (Pri:2)");
        Console.WriteLine("Actual: " + priorityQueue.Dequeue());
        Console.WriteLine("Queue after dequeue: " + priorityQueue);
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}
