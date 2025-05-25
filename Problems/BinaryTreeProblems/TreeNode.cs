using System;
using System.Collections.Generic; // For Queue in BFS

// Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    // Optional: A helper method to print a tree (e.g., using BFS for readability)
    public void PrintTreeBFS()
    {
        if (this == null)
        {
            Console.WriteLine("[]");
            return;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(this);
        List<string> values = new List<string>();

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();
            if (current != null)
            {
                values.Add(current.val.ToString());
                queue.Enqueue(current.left);
                queue.Enqueue(current.right);
            }
            else
            {
                values.Add("null"); // Indicate null children for visual tree structure
            }
        }

        // Clean up trailing nulls if it's a complete tree
        while (values.Count > 0 && values[values.Count - 1] == "null")
        {
            values.RemoveAt(values.Count - 1);
        }

        Console.WriteLine($"[{string.Join(", ", values)}]");
    }
}