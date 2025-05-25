class Program
{
    // Helper method to create a binary tree from an array (level-order representation)
    // Example: [3,9,20,null,null,15,7]
    public static TreeNode CreateTreeFromArray(int?[] arr)
    {
        if (arr == null || arr.Length == 0 || arr[0] == null)
        {
            return null;
        }

        TreeNode root = new TreeNode(arr[0].Value);
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int i = 1;
        while (queue.Count > 0 && i < arr.Length)
        {
            TreeNode current = queue.Dequeue();

            // Left child
            if (i < arr.Length && arr[i] != null)
            {
                current.left = new TreeNode(arr[i].Value);
                queue.Enqueue(current.left);
            }
            i++;

            // Right child
            if (i < arr.Length && arr[i] != null)
            {
                current.right = new TreeNode(arr[i].Value);
                queue.Enqueue(current.right);
            }
            i++;
        }
        return root;
    }

    static void Main(string[] args)
    {
        //Solution sol = new Solution();
        LeafSimilar_Solution sol = new LeafSimilar_Solution();

        // --- Test Case 1: Simple Tree ---
        Console.WriteLine("--- Test Case 1: Simple Tree ---");
        int?[] arr1 = [3,5,1,6,2,9,8,null,null,7,4]; // Represents:
        int?[] arr2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]; // Represents:
        //      3
        //     / \
        //    9  20
        //       / \
        //      15  7
        TreeNode tree1 = CreateTreeFromArray(arr1);
        TreeNode tree2 = CreateTreeFromArray(arr2);
        Console.WriteLine($"{sol.LeafSimilar(tree1, tree2)}");
        // Console.Write("Tree 1 (BFS representation): ");
        // tree1?.PrintTreeBFS();

        // // Console.WriteLine($"Pre-order (Recursive): {string.Join(", ", sol.PreorderTraversal(tree1))}");

        // Console.WriteLine("---------------------------------\n");

        // // --- Test Case 2: Unbalanced Tree ---
        // Console.WriteLine("--- Test Case 2: Unbalanced Tree ---");
        // int?[] arr2 = { 1, 2, 3, 4, 5, null, 6, 7 }; // Represents:
        // //        1
        // //       / \
        // //      2   3
        // //     / \   \
        // //    4   5   6
        // //   /
        // //  7
        // TreeNode tree2 = CreateTreeFromArray(arr2);
        // Console.Write("Tree 2 (BFS representation): ");
        // tree2?.PrintTreeBFS();

        // Console.WriteLine("---------------------------------\n");

        // --- Test Case 3: Empty Tree ---
        Console.WriteLine("--- Test Case 3: Empty Tree ---");
        int?[] arr3 = { };
        TreeNode tree3 = CreateTreeFromArray(arr3);
        Console.Write("Tree 3 (BFS representation): ");
        tree3?.PrintTreeBFS();


        Console.WriteLine("---------------------------------\n");

        // --- Test Case 4: Single Node Tree ---
        Console.WriteLine("--- Test Case 4: Single Node Tree ---");
        int?[] arr4 = { 10 };
        TreeNode tree4 = CreateTreeFromArray(arr4);
        Console.Write("Tree 4 (BFS representation): ");
        tree4?.PrintTreeBFS();

        Console.WriteLine("---------------------------------\n");

        // Add more test cases as needed
    }
}