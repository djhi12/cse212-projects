using System.Collections;

public class LinkedList : IEnumerable<int>
{
    private Node? _head;
    private Node? _tail;

    /// <summary>
    /// Insert a new node at the front (i.e. the head) of the linked list.
    /// </summary>
    public void InsertHead(int value)
    {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        // If the list is not empty, then only head will be affected.
        else
        {
            newNode.Next = _head; // Connect new node to the previous head
            _head.Prev = newNode; // Connect the previous head to the new node
            _head = newNode; // Update the head to point to the new node
        }
    }

    /// <summary>
    /// Insert a new node at the back (i.e. the tail) of the linked list.
    /// </summary>
    public void InsertTail(int value)
    {
        // Create a new node with the given value
        Node newNode = new Node(value);

        // If the list is empty, both head and tail should point to the new node
        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            // Otherwise, set the next of the current tail to the new node
            _tail.Next = newNode;
            // Set the previous of the new node to the current tail
            newNode.Prev = _tail;
            // Update the tail to be the new node
            _tail = newNode;
        }

        // // Create a new instance of the LinkedList class
        // LinkedList list = new LinkedList();

        // // Insert some values using InsertTail
        // list.InsertTail(10);
        // list.InsertTail(20);
        // list.InsertTail(30);

        // // Check if the head and tail are not null
        // Console.WriteLine($"Head and tail are not null: {list.HeadAndTailAreNotNull()}");

        // // Print the linked list to verify the insertion
        // Console.WriteLine($"Linked list after InsertTail: {list}");

        // Expected output:
        // Head and tail are not null: True
        // Linked list after InsertTail: <LinkedList>{10, 20, 30}

    }


    /// <summary>
    /// Remove the first node (i.e. the head) of the linked list.
    /// </summary>
    public void RemoveHead()
    {
        // If the list has only one item in it, then set head and tail 
        // to null resulting in an empty list.  This condition will also
        // cover an empty list.  Its okay to set to null again.
        if (_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        // If the list has more than one item in it, then only the head
        // will be affected.
        else if (_head is not null)
        {
            _head.Next!.Prev = null; // Disconnect the second node from the first node
            _head = _head.Next; // Update the head to point to the second node
        }
    }


    /// <summary>
    /// Remove the last node (i.e. the tail) of the linked list.
    /// </summary>
    public void RemoveTail()
    {
        // If the list is empty, there is nothing to remove
        if (_head is null)
            return;

        // If the list has only one node, set both head and tail to null
        if (_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            // Check if _tail is not null before accessing its properties
            if (_tail is not null)
            {
                // Set the previous node of the current tail as the new tail
                _tail = _tail.Prev;
                // If _tail is not null after the assignment, set its Next property to null
                if (_tail is not null)
                    _tail.Next = null;
            }
        }

        // // Create a new instance of the LinkedList class
        // LinkedList list = new LinkedList();

        // // Insert some values using InsertTail
        // list.InsertTail(10);
        // list.InsertTail(20);
        // list.InsertTail(30);

        // // Check if the head and tail are not null
        // Console.WriteLine($"Head and tail are not null: {list.HeadAndTailAreNotNull()}");

        // // Print the linked list before removal
        // Console.WriteLine($"Linked list before RemoveTail: {list}");

        // // Remove the tail
        // list.RemoveTail();

        // // Print the linked list after removal
        // Console.WriteLine($"Linked list after RemoveTail: {list}");

        // Expected output:
        // Head and tail are not null: True
        // Linked list before RemoveTail: <LinkedList>{10, 20, 30}
        // Linked list after RemoveTail: <LinkedList>{10, 20}

    }

    /// <summary>
    /// Insert 'newValue' after the first occurrence of 'value' in the linked list.
    /// </summary>
    public void InsertAfter(int value, int newValue)
    {
        // Search for the node that matches 'value' by starting at the 
        // head of the list.
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Data == value)
            {
                // If the location of 'value' is at the end of the list,
                // then we can call insert_tail to add 'new_value'
                if (curr == _tail)
                {
                    InsertTail(newValue);
                }
                // For any other location of 'value', need to create a 
                // new node and reconnect the links to insert.
                else
                {
                    Node newNode = new(newValue);
                    newNode.Prev = curr; // Connect new node to the node containing 'value'
                    newNode.Next = curr.Next; // Connect new node to the node after 'value'
                    curr.Next!.Prev = newNode; // Connect node after 'value' to the new node
                    curr.Next = newNode; // Connect the node containing 'value' to the new node
                }

                return; // We can exit the function after we insert
            }

            curr = curr.Next; // Go to the next node to search for 'value'
        }
    }

    /// <summary>
    /// Remove the first node that contains 'value'.
    /// </summary>
    public void Remove(int value)
    {
        // Start searching for the node containing the value from the head
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Data == value)
            {
                // If the node to remove is the head, use RemoveHead method
                if (curr == _head)
                {
                    RemoveHead();
                }
                // If the node to remove is the tail, use RemoveTail method
                else if (curr == _tail)
                {
                    RemoveTail();
                }
                // For any other node in the middle of the list
                else
                {
                    curr.Prev!.Next = curr.Next; // Update the previous node's next reference
                    curr.Next!.Prev = curr.Prev; // Update the next node's previous reference
                }
                return; // Exit the function after removing the node
            }
            curr = curr.Next; // Move to the next node
        }

        // // Create a new instance of the LinkedList class
        // LinkedList list = new LinkedList();

        // // Insert some values using InsertTail
        // list.InsertTail(10);
        // list.InsertTail(20);
        // list.InsertTail(30);

        // // Print the linked list before removal
        // Console.WriteLine($"Linked list before Remove: {list}");

        // // Remove a node with value 20
        // list.Remove(20);

        // // Print the linked list after removal
        // Console.WriteLine($"Linked list after Remove: {list}");

        // Expected output:
        // Linked list before Remove: <LinkedList>{10, 20, 30}
        // Linked list after Remove: <LinkedList>{10, 30}

    }


    /// <summary>
    /// Search for all instances of 'oldValue' and replace the value to 'newValue'.
    /// </summary>
    public void Replace(int oldValue, int newValue)
    {
        // Start searching for nodes containing oldValue from the head
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Data == oldValue)
            {
                // Replace the value with newValue
                curr.Data = newValue;
            }
            curr = curr.Next; // Move to the next node
        }

        // Create a new instance of the LinkedList class
        // LinkedList list = new LinkedList();

        // // Insert some values using InsertTail
        // list.InsertTail(10);
        // list.InsertTail(20);
        // list.InsertTail(30);

        // // Print the linked list before replacement
        // Console.WriteLine($"Linked list before Replace: {list}");

        // // Replace all occurrences of oldValue 20 with newValue 25
        // list.Replace(20, 25);

        // // Print the linked list after replacement
        // Console.WriteLine($"Linked list after Replace: {list}");

        // Expected output:
        // Linked list before Replace: <LinkedList>{10, 20, 30}
        // Linked list after Replace: <LinkedList>{10, 25, 30}

    }


    /// <summary>
    /// Yields all values in the linked list
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        // call the generic version of the method
        return this.GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the Linked List
    /// </summary>
    public IEnumerator<int> GetEnumerator()
    {
        var curr = _head; // Start at the beginning since this is a forward iteration.
        while (curr is not null)
        {
            yield return curr.Data; // Provide (yield) each item to the user
            curr = curr.Next; // Go forward in the linked list
        }
    }

    /// <summary>
    /// Iterate backward through the Linked List
    /// </summary>
    public IEnumerable Reverse()
    {
        var curr = _tail; // Start at the end of the list
        while (curr != null)
        {
            yield return curr.Data; // Provide the value of the current node
            curr = curr.Prev; // Move to the previous node
        }

    }


    public override string ToString()
    {
        return "<LinkedList>{" + string.Join(", ", this) + "}";
    }

    // Just for testing.
    public Boolean HeadAndTailAreNull()
    {
        return _head is null && _tail is null;
    }

    // Just for testing.
    public Boolean HeadAndTailAreNotNull()
    {
        return _head is not null && _tail is not null;
    }
}