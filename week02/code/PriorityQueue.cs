// public class PriorityQueue {
//     private List<PriorityItem> _queue = new();

//     /// <summary>
//     /// Add a new value to the queue with an associated priority.  The
//     /// node is always added to the back of the queue irregardless of 
//     /// the priority.
//     /// </summary>
//     /// <param name="value">The value</param>
//     /// <param name="priority">The priority</param>
//     public void Enqueue(string value, int priority) {
//         var newNode = new PriorityItem(value, priority);
//         _queue.Add(newNode);
//     }

//     public String Dequeue() {
//         if (_queue.Count == 0) // Verify the queue is not empty
//         {
//             Console.WriteLine("The queue is empty.");
//             return null;
//         }

//         // Find the index of the item with the highest priority to remove
//         var highPriorityIndex = 0;
//         for (int index = 1; index < _queue.Count - 1; index++) {
//             if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
//                 highPriorityIndex = index;
//         }

//         // Remove and return the item with the highest priority
//         var value = _queue[highPriorityIndex].Value;
//         return value;
//     }

//     public override string ToString() {
//         return $"[{string.Join(", ", _queue)}]";
//     }
// }

// internal class PriorityItem {
//     internal string Value { get; set; }
//     internal int Priority { get; set; }

//     internal PriorityItem(string value, int priority) {
//         Value = value;
//         Priority = priority;
//     }

//     public override string ToString() {
//         return $"{Value} (Pri:{Priority})";
//     }
// }

using System;
using System.Collections.Generic;

public class PriorityQueue
{
    private List<PriorityItem> _queue = new List<PriorityItem>();

    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        int i;
        for (i = 0; i < _queue.Count; i++)
        {
            if (priority > _queue[i].Priority)
            {
                break;
            }
        }
        _queue.Insert(i, newNode);
    }

    public string Dequeue()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("The queue is empty.");
            return null;
        }
        var value = _queue[0].Value;
        _queue.RemoveAt(0);
        return value;
    }

    public override string ToString()
    {
        List<string> items = new List<string>();
        foreach (var item in _queue)
        {
            items.Add($"{item.Value} (Pri:{item.Priority})");
        }
        return $"[{string.Join(", ", items)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }
}
