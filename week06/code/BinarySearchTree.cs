using System.Collections;

public class BinarySearchTree : IEnumerable<int>
{
    private Node? _root;

    /// <summary>
    /// Insert a new node in the BST.
    /// </summary>
    public void Insert(int value)
    {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_root is null)
            _root = newNode;
        // If the list is not empty, then only head will be affected.
        else
            _root.Insert(value);
    }

    /// <summary>
    /// Check to see if the tree contains a certain value
    /// </summary>
    /// <param name="value">The value to look for</param>
    /// <returns>true if found, otherwise false</returns>
    public bool Contains(int value)
    {
        return _root != null && _root.Contains(value);
    }

    /// <summary>
    /// Yields all values in the tree
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        // call the generic version of the method
        return GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the BST
    /// </summary>
    public IEnumerator<int> GetEnumerator()
    {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    private void TraverseForward(Node? node, List<int> values)
    {
        if (node is not null)
        {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    /// <summary>
    /// Iterate backward through the BST.
    /// </summary>
    public IEnumerable Reverse()
    {
        var numbers = new List<int>();
        TraverseBackward(_root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    private void TraverseBackward(Node? node, List<int> values)
    {
        if (node is not null)
        {
            TraverseBackward(node.Right, values); // Traverse right subtree first
            values.Add(node.Data); // Add current node's value
            TraverseBackward(node.Left, values); // Traverse left subtree
        }
    }

    public IEnumerable<int> Reversed()
    {
        var numbers = new List<int>();
        TraverseBackward(_root, numbers);
        return numbers;
    }

    /// <summary>
    /// Get the height of the tree
    /// </summary>
    public int GetHeight()
    {
        if (_root is null)
            return 0;
        return _root.GetHeight();
    }

    public override string ToString()
    {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }

    public static void InsertMiddle(BinarySearchTree bst, List<int> sortedList, int first, int last)
    {
        if (first <= last)
        {
            int middle = (first + last) / 2; // Calculate the middle index
            bst.Insert(sortedList[middle]); // Insert the middle element to the tree

            // Recursively insert elements from the left and right halves
            InsertMiddle(bst, sortedList, first, middle - 1); // Left half
            InsertMiddle(bst, sortedList, middle + 1, last); // Right half
        }
    }


}
