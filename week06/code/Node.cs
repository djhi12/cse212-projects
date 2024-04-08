public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // If the value is less than the current node's value, go left
        if (value < Data)
        {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        // If the value is greater than the current node's value, go right
        else if (value > Data)
        {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If the value is equal to the current node's value, do nothing (already exists)
        // You can choose to throw an exception or handle duplicates differently if desired
    }

    public bool Contains(int value)
    {
        // If the current node's value is equal to the target value, return true
        if (value == Data)
            return true;

        // If the target value is less than the current node's value, search left
        if (value < Data)
        {
            // If left node is null, the value doesn't exist in the tree
            if (Left is null)
                return false;
            // Recursively search in the left subtree
            return Left.Contains(value);
        }
        // If the target value is greater than the current node's value, search right
        else
        {
            // If right node is null, the value doesn't exist in the tree
            if (Right is null)
                return false;
            // Recursively search in the right subtree
            return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Base case: if the node is null, return 0
        if (this == null)
            return 0;

        // Recursively calculate the height of the left and right subtrees
        int leftHeight = (Left == null) ? 0 : Left.GetHeight();
        int rightHeight = (Right == null) ? 0 : Right.GetHeight();

        // Return the maximum height between the left and right subtrees, plus 1 for the current node
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}